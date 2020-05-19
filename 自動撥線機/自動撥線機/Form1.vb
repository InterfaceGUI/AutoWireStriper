Imports System.ComponentModel
Imports isPLC_Modbus

Public Class Form1
    Dim selectComPort As String = ""
    Dim connected As Boolean = False
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ts_progressBar_connection.Size = New Size(200, 20)
        TabControl1.Size = New Size(1019, 520)
        TabControl1.Location = New Point(4, -34)

    End Sub

#Region "PanelMove"
    Dim DMouseD As Boolean = False
    Dim OMouseL As Point
    Private Sub Panel2_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel2.MouseMove, Label5.MouseMove
        If DMouseD Then
            Me.Location = Me.Location + New Point(e.X, e.Y) - OMouseL
        End If
    End Sub

    Private Sub Panel2_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel2.MouseUp, Label5.MouseUp
        DMouseD = False
    End Sub

    Private Sub Panel2_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel2.MouseDown, Label5.MouseDown
        If e.Button = MouseButtons.Left Then
            DMouseD = True
            OMouseL = New Point(e.X, e.Y)

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.WindowState = FormWindowState.Minimized
        Me.Visible = False
    End Sub

#End Region

#Region "連線程式區塊"

    '按下了tssb_SerialPorts(下拉是選單左邊的那個) 按鈕
    Private Sub tssb_SerialPorts_ButtonClick(sender As Object, e As EventArgs) Handles tssb_SerialPorts.ButtonClick

        If connected Then

            Try
                tssb_SerialPorts.Image = ImageList_usbStatus.Images(0)
                IO.isPLC_SerialPort.Close()
                tssb_SerialPorts.Text = "連線 (" & selectComPort & ")"
                connected = False
            Catch ex As Exception

            End Try


        Else
            If selectComPort = "" Then
                Exit Sub
            End If

            Try

                If BackgroundWorker_connect.IsBusy Then
                    Exit Sub
                End If
                BackgroundWorker_connect.RunWorkerAsync()
                ts_progressBar_connection.Visible = True


            Catch ex As Exception
                MsgBox("錯誤", ex.Message, MsgBoxStyle.Exclamation)
                connected = False
                tssb_SerialPorts.Text = "無法連線至 (" & selectComPort & ")"
                ts_progressBar_connection.Visible = False
                tssb_SerialPorts.Image = ImageList_usbStatus.Images(2)
                Exit Sub
            End Try

            connected = True
            tssb_SerialPorts.Text = "正在連線至 (" & selectComPort & ")"

        End If



    End Sub
    Dim BackgroundWorkerConnect_isSuccess As Boolean = False
    '背景處理程序
    Private Sub BackgroundWorker_connect_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker_connect.DoWork
        Try
            IO = New isPLC_Connect(selectComPort, 1)
            BackgroundWorkerConnect_isSuccess = True

        Catch ex As Exception
            BackgroundWorkerConnect_isSuccess = False
        End Try


    End Sub
    Private Sub BackgroundWorker_connect_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker_connect.RunWorkerCompleted
        If Not BackgroundWorkerConnect_isSuccess Then
            MsgBox("無法連線!", MsgBoxStyle.Exclamation, "錯誤")
            connected = False
            tssb_SerialPorts.Text = "無法連線至 (" & selectComPort & ")"
            ts_progressBar_connection.Visible = False
            tssb_SerialPorts.Image = ImageList_usbStatus.Images(2)
            Exit Sub
        End If
        Dim Version As String = ""

        For Each x In IO.ReadVersion()
            Version += x & "."
        Next

        ts_progressBar_connection.Visible = False
        tssb_SerialPorts.Text = "以連線至 (" & selectComPort & ") 版本：" & Mid(Version, 1, Len(Version) - 1)
        tssb_SerialPorts.Image = ImageList_usbStatus.Images(1)
    End Sub


    '下方是下拉是選單選了物品
    Private Sub tssb_SerialPorts_DropDownItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles tssb_SerialPorts.DropDownItemClicked
        Dim PortName As String = e.ClickedItem.Text

        If PortName = "未找到以連接的端口" Then
            selectComPort = ""
            Exit Sub
        End If
        selectComPort = PortName
        tssb_SerialPorts.Text = "連線 (" & selectComPort & ")"

    End Sub


    ' tssb_SerialPorts 的下拉是選單被打開 會調用下方的函數，並取的目前的端口 更新夏拉是選單內的物品
    Private Sub tssb_SerialPorts_DropDownOpening(sender As Object, e As EventArgs) Handles tssb_SerialPorts.DropDownOpening
        tssb_SerialPorts.DropDownItems.Clear()

        If connected Then
            Exit Sub
        End If

        '將端口加入到下方的Combox(tssb_SeialPorts)
        If System.IO.Ports.SerialPort.GetPortNames.Count <> 0 Then
            For Each port In System.IO.Ports.SerialPort.GetPortNames
                tssb_SerialPorts.DropDownItems.Add(port)
            Next
        Else
            tssb_SerialPorts.DropDownItems.Add("未找到以連接的端口")
        End If

    End Sub

#End Region

    Dim clientPoint As Point
    Dim PL_Size As Int16 = 230
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        clientPoint = PointToClient(Cursor.Position)

        If Panel3.DisplayRectangle.Contains(clientPoint) Then

            If PL_Size < 276 Then
                PL_Size += 8
            End If

            Panel3.Size = New Size(PL_Size, Panel3.Size.Height)

        Else

            If PL_Size > 74 Then
                PL_Size -= 8
            End If

            Panel3.Size = New Size(PL_Size, Panel3.Size.Height)

        End If
    End Sub

    Private Sub Button4_Click(sender As Button, e As EventArgs) Handles Button4.Click, Button5.Click, Button6.Click, Button7.Click
        Select Case sender.Tag
            Case "0"
                TabControl1.SelectedIndex = 0
            Case "1"
                TabControl1.SelectedIndex = 1
            Case "2"
                TabControl1.SelectedIndex = 2
            Case "3"
                TabControl1.SelectedIndex = 3
        End Select

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button7.Click, Button6.Click, Button5.Click, Button4.Click

    End Sub
End Class
