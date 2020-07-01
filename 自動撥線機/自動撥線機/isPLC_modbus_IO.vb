Imports isPLC_Modbus

Module isPLC_modbus_IO
    '宣告一個 isPLC 通訊物件
    Public IO As isPLC_Connect

    '================ 輸出函式：OUT() ================
    '[功能]：設定 Y0~Y5 為 ON 或 OFF。(多載)
    '[用法]： 
    '   1.設定 Y2 為 ON：OUT(2,True)
    '   2.設定 Y2 為 OFF：OUT(2,False)
    '   3.設定 Y5~Y0 的狀態為 "010101"：OUT("010101")
    '[日期]：2019.11.07
    '================================================
    Public Sub OUT(ByVal Y_pinNumber As UInteger, ByVal state As Boolean)
        IO.SetDevice(isPLC_Connect.MemoryAddress.BY, Y_pinNumber, state)
    End Sub

    Public Sub OUT(ByVal yString As String)
        If yString.Length >= 8 Then
            yString = Right(yString, 8)
        End If
        IO.WriteData(isPLC_Connect.MemoryAddress.BY, 0, {Convert.ToByte(yString, 2)})
    End Sub

    '================ 讀取函式：Read() ================
    '[功能]：讀取 X0~X5/Y0~Y5 的狀態或 D0~D5 的數值
    '[用法]：
    '   1.讀取 X0~X5：Read("X")
    '   2.讀取 Y0~Y5：Read("Y")
    '   3.讀取 Y3：Read("Y",3)
    '[日期]：2019.07.29
    '=================================================
    Public Function Read(ByVal deviceName As String, Optional ByVal startPin As Int16 = -1, Optional ByVal dataLength As Int16 = 1) As String
        Dim str1 As String = ""
        Select Case deviceName
            Case "X"
                str1 = Convert.ToString(IO.ReadData(isPLC_Connect.MemoryAddress.BX, 0, 6)(0), 2).PadLeft(6, "0")
                If startPin = -1 Then
                    Return str1
                Else
                    Return Mid(str1, 6 - startPin, 1)
                End If
            Case "Y"
                str1 = Convert.ToString(IO.ReadData(isPLC_Connect.MemoryAddress.BY, 0, 6)(0), 2).PadLeft(6, "0")
                If startPin = -1 Then
                    Return str1
                Else
                    Return Mid(str1, 6 - startPin, 1)
                End If
            Case Else
                Return "參數錯誤！"
        End Select
    End Function

    Public Function ReadC(ByVal selectedPin As Int16) As Int16
        Dim DV() As Byte
        Dim tmpD As String
        Dim A_value As Int16
        DV = IO.ReadData(isPLC_Connect.MemoryAddress.WC, selectedPin, 2)
        tmpD = Convert.ToString(DV(0) * 256 + DV(1), 16).PadLeft(4, "0")
        A_value = Val("&H" & tmpD)
        Return A_value
    End Function


    '================ 讀取函式：ReadA() ================
    '[功能]：讀取 A0~A5(D0~D5) 的數值
    '[用法]：
    '   1.讀取 A2：ReadA(2)
    '   2.讀取 A2~A5：ReadA(2,4)
    '[日期]：2019.11.09
    '=================================================
    Public Function ReadA(ByVal selectedPin As Int16) As Int16
        Dim DV() As Byte
        Dim tmpD As String
        Dim A_value As Int16
        DV = IO.ReadData(isPLC_Connect.MemoryAddress.WD, selectedPin, 2)
        tmpD = Convert.ToString(DV(0) * 256 + DV(1), 16).PadLeft(4, "0")
        A_value = Val("&H" & tmpD)
        Return A_value
    End Function

    Public Function ReadA(Optional ByVal startPin As Int16 = -1, Optional ByVal dataLength As Int16 = 1) As Int16()
        If startPin = -1 Then
            startPin = 0
            dataLength = 6
        End If
        Dim DV() As Byte
        Dim tmpD As String
        Dim A_value(dataLength - 1) As Int16
        DV = IO.ReadData(isPLC_Connect.MemoryAddress.WD, startPin, dataLength * 2)
        For i = 0 To dataLength - 1
            tmpD = Convert.ToString(DV(2 * i) * 256 + DV(2 * i + 1), 16).PadLeft(4, "0")
            A_value(i) = Val("&H" & tmpD)
        Next
        Return A_value '回傳值為16進位
    End Function

    '============================== PWM 輸出函式 =================================
    '[功能]：設定 Y1,Y2 為PWM 輸出。(多載)
    '       PWM_ON(1或2, True/False):True 為啟動PWM功能，False為終止PWM功能
    '       PWM(1或2, 佔空比(%), 週期(us))
    '[用法]： 
    '   1.設定 Y2 為 PWM 輸出的佔空比為 40%，週期 20ms(=20000us)：PWM(2, 40, 20000)
    '   2.啟動 Y2 為 PWM：PWM_ON(2,True)
    '   3.關閉 Y2 的 PWM 功能：PWM_ON(2,False)
    '[日期]：2019.07.29
    '============================================================================
    Public Sub PWM_ON(ByVal Y_pinNumber As UInteger, Optional ByVal pwmEnable As Boolean = True)
        IO.SetDevice(isPLC_Connect.MemoryAddress.BM, Y_pinNumber, pwmEnable)
    End Sub

    Public Sub PWM(ByVal Y_pinNumber As UInteger, Optional ByVal dutyRatio As Single = 50, Optional ByVal period As UInt32 = 20000)
        Dim periodNO, dutyNo As UInteger
        dutyRatio = Math.Min(100, dutyRatio)
        periodNO = period / 4
        dutyNo = (period / 4) * (dutyRatio / 100)
        Dim DV(1) As UInteger
        DV(0) = periodNO
        DV(1) = dutyNo
        If Y_pinNumber = 1 Then
            IO.WriteData(isPLC_Connect.MemoryAddress.WD, 8, DV)
        ElseIf Y_pinNumber = 2 Then
            IO.WriteData(isPLC_Connect.MemoryAddress.WD, 10, DV)
        End If
    End Sub


End Module
