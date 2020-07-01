<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ts_progressBar_connection = New System.Windows.Forms.ToolStripProgressBar()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel6 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.ToolStripStatusLabel7 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel8 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lb_rc = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lb_step = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lb_lcount = New System.Windows.Forms.Label()
        Me.lb_cycle = New System.Windows.Forms.Label()
        Me.lb_long2 = New System.Windows.Forms.Label()
        Me.lb_long = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.NumericUpDown4 = New System.Windows.Forms.NumericUpDown()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NumericUpDown3 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.ImageList_usbStatus = New System.Windows.Forms.ImageList(Me.components)
        Me.BackgroundWorker_connect = New System.ComponentModel.BackgroundWorker()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_ReadStatus = New System.Windows.Forms.Timer(Me.components)
        Me.bwork_readstatus = New System.ComponentModel.BackgroundWorker()
        Me.IsPLC_IO_Card1 = New YSKControlLibrary.isPLC_IO_Card(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.pb_open = New System.Windows.Forms.PictureBox()
        Me.pb_feed = New System.Windows.Forms.PictureBox()
        Me.pb_red = New System.Windows.Forms.PictureBox()
        Me.btn_stop = New System.Windows.Forms.Button()
        Me.btn_start = New System.Windows.Forms.Button()
        Me.pb_Green = New System.Windows.Forms.PictureBox()
        Me.pb_Yellow = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.tssb_SerialPorts = New System.Windows.Forms.ToolStripSplitButton()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.NumericUpDown4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.pb_open, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_feed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_red, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_Green, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_Yellow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1019, 34)
        Me.Panel2.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("微軟正黑體", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(88, 2)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(826, 28)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "[宇創客工作室] Automated Wirestrip Machine"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StatusStrip1
        '
        Me.StatusStrip1.AutoSize = False
        Me.StatusStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.StatusStrip1.Font = New System.Drawing.Font("Microsoft JhengHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.tssb_SerialPorts, Me.ts_progressBar_connection, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel4, Me.ToolStripStatusLabel5, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel6, Me.ToolStripProgressBar1, Me.ToolStripStatusLabel7, Me.ToolStripStatusLabel8})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 518)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1025, 32)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 8
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Microsoft JhengHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(95, 26)
        Me.ToolStripStatusLabel1.Text = "連線端口："
        '
        'ts_progressBar_connection
        '
        Me.ts_progressBar_connection.Margin = New System.Windows.Forms.Padding(1, 6, 1, 6)
        Me.ts_progressBar_connection.MarqueeAnimationSpeed = 30
        Me.ts_progressBar_connection.Maximum = 1
        Me.ts_progressBar_connection.Name = "ts_progressBar_connection"
        Me.ts_progressBar_connection.Size = New System.Drawing.Size(10, 20)
        Me.ts_progressBar_connection.Step = 1
        Me.ts_progressBar_connection.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.ts_progressBar_connection.Value = 1
        Me.ts_progressBar_connection.Visible = False
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(15, 26)
        Me.ToolStripStatusLabel2.Text = "|"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Font = New System.Drawing.Font("Microsoft JhengHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(90, 26)
        Me.ToolStripStatusLabel4.Text = "機台狀態 : "
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.Font = New System.Drawing.Font("Microsoft JhengHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ToolStripStatusLabel5.ForeColor = System.Drawing.Color.Green
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(61, 26)
        Me.ToolStripStatusLabel5.Text = "已停止"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(15, 26)
        Me.ToolStripStatusLabel3.Text = "|"
        '
        'ToolStripStatusLabel6
        '
        Me.ToolStripStatusLabel6.Font = New System.Drawing.Font("Microsoft JhengHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ToolStripStatusLabel6.Name = "ToolStripStatusLabel6"
        Me.ToolStripStatusLabel6.Size = New System.Drawing.Size(61, 26)
        Me.ToolStripStatusLabel6.Text = "進度："
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Margin = New System.Windows.Forms.Padding(1, 6, 1, 6)
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(250, 20)
        '
        'ToolStripStatusLabel7
        '
        Me.ToolStripStatusLabel7.Font = New System.Drawing.Font("Microsoft JhengHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ToolStripStatusLabel7.Name = "ToolStripStatusLabel7"
        Me.ToolStripStatusLabel7.Size = New System.Drawing.Size(38, 26)
        Me.ToolStripStatusLabel7.Text = "0/0"
        '
        'ToolStripStatusLabel8
        '
        Me.ToolStripStatusLabel8.Name = "ToolStripStatusLabel8"
        Me.ToolStripStatusLabel8.Size = New System.Drawing.Size(15, 26)
        Me.ToolStripStatusLabel8.Text = "|"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Location = New System.Drawing.Point(3, 36)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel1.Size = New System.Drawing.Size(1019, 482)
        Me.Panel1.TabIndex = 9
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Button7)
        Me.Panel3.Controls.Add(Me.Button6)
        Me.Panel3.Controls.Add(Me.Button5)
        Me.Panel3.Controls.Add(Me.Button4)
        Me.Panel3.Location = New System.Drawing.Point(0, -3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(82, 485)
        Me.Panel3.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.TabControl1.Location = New System.Drawing.Point(4, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1024, 486)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 34)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1016, 448)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.pb_open)
        Me.GroupBox2.Controls.Add(Me.pb_feed)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.lb_rc)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.lb_step)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.lb_lcount)
        Me.GroupBox2.Controls.Add(Me.lb_cycle)
        Me.GroupBox2.Controls.Add(Me.lb_long2)
        Me.GroupBox2.Controls.Add(Me.lb_long)
        Me.GroupBox2.Location = New System.Drawing.Point(351, 25)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(647, 428)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "狀態"
        '
        'Label17
        '
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label17.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label17.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label17.Location = New System.Drawing.Point(367, 157)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(100, 30)
        Me.Label17.TabIndex = 5
        Me.Label17.Text = "開鉗子"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label14.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label14.Location = New System.Drawing.Point(367, 41)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(100, 30)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "進料感測"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label13.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label13.Location = New System.Drawing.Point(250, 157)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(100, 30)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "RC馬達"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lb_rc
        '
        Me.lb_rc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_rc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lb_rc.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lb_rc.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lb_rc.Location = New System.Drawing.Point(250, 187)
        Me.lb_rc.Name = "lb_rc"
        Me.lb_rc.Size = New System.Drawing.Size(100, 60)
        Me.lb_rc.TabIndex = 2
        Me.lb_rc.Text = "0"
        Me.lb_rc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label10.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label10.Location = New System.Drawing.Point(136, 157)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 30)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Step"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lb_step
        '
        Me.lb_step.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_step.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lb_step.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lb_step.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lb_step.Location = New System.Drawing.Point(136, 187)
        Me.lb_step.Name = "lb_step"
        Me.lb_step.Size = New System.Drawing.Size(100, 60)
        Me.lb_step.TabIndex = 2
        Me.lb_step.Text = "0"
        Me.lb_step.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label9.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label9.Location = New System.Drawing.Point(22, 157)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 30)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "剩餘次數"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label7.Location = New System.Drawing.Point(250, 41)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 30)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "循環次數"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label4.Location = New System.Drawing.Point(22, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 30)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "剝除長度"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(136, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 30)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "剝線長度"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lb_lcount
        '
        Me.lb_lcount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_lcount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lb_lcount.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lb_lcount.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lb_lcount.Location = New System.Drawing.Point(22, 187)
        Me.lb_lcount.Name = "lb_lcount"
        Me.lb_lcount.Size = New System.Drawing.Size(100, 60)
        Me.lb_lcount.TabIndex = 0
        Me.lb_lcount.Text = "0"
        Me.lb_lcount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lb_cycle
        '
        Me.lb_cycle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_cycle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lb_cycle.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lb_cycle.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lb_cycle.Location = New System.Drawing.Point(250, 71)
        Me.lb_cycle.Name = "lb_cycle"
        Me.lb_cycle.Size = New System.Drawing.Size(100, 60)
        Me.lb_cycle.TabIndex = 0
        Me.lb_cycle.Text = "0"
        Me.lb_cycle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lb_long2
        '
        Me.lb_long2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_long2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lb_long2.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lb_long2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lb_long2.Location = New System.Drawing.Point(22, 71)
        Me.lb_long2.Name = "lb_long2"
        Me.lb_long2.Size = New System.Drawing.Size(100, 60)
        Me.lb_long2.TabIndex = 0
        Me.lb_long2.Text = "0"
        Me.lb_long2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lb_long
        '
        Me.lb_long.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_long.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lb_long.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lb_long.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lb_long.Location = New System.Drawing.Point(136, 71)
        Me.lb_long.Name = "lb_long"
        Me.lb_long.Size = New System.Drawing.Size(100, 60)
        Me.lb_long.TabIndex = 0
        Me.lb_long.Text = "0"
        Me.lb_long.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.pb_red)
        Me.GroupBox1.Controls.Add(Me.btn_stop)
        Me.GroupBox1.Controls.Add(Me.btn_start)
        Me.GroupBox1.Controls.Add(Me.pb_Green)
        Me.GroupBox1.Controls.Add(Me.pb_Yellow)
        Me.GroupBox1.Location = New System.Drawing.Point(86, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(243, 288)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "監視"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.Button8)
        Me.TabPage2.Controls.Add(Me.NumericUpDown4)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.NumericUpDown3)
        Me.TabPage2.Controls.Add(Me.NumericUpDown2)
        Me.TabPage2.Controls.Add(Me.NumericUpDown1)
        Me.TabPage2.Controls.Add(Me.PictureBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 34)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1016, 448)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(86, 368)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(196, 67)
        Me.Button8.TabIndex = 3
        Me.Button8.Text = "設定!"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'NumericUpDown4
        '
        Me.NumericUpDown4.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.NumericUpDown4.Location = New System.Drawing.Point(813, 363)
        Me.NumericUpDown4.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown4.Name = "NumericUpDown4"
        Me.NumericUpDown4.Size = New System.Drawing.Size(79, 47)
        Me.NumericUpDown4.TabIndex = 1
        Me.NumericUpDown4.Tag = "4"
        Me.NumericUpDown4.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("微軟正黑體", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label11.Location = New System.Drawing.Point(722, 368)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(99, 36)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "次數："
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("微軟正黑體", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label6.Location = New System.Drawing.Point(907, 277)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 31)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "mm"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("微軟正黑體", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.Location = New System.Drawing.Point(166, 277)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 31)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "mm"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微軟正黑體", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(569, 274)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 31)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "mm"
        '
        'NumericUpDown3
        '
        Me.NumericUpDown3.Enabled = False
        Me.NumericUpDown3.Location = New System.Drawing.Point(862, 274)
        Me.NumericUpDown3.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown3.Name = "NumericUpDown3"
        Me.NumericUpDown3.Size = New System.Drawing.Size(44, 34)
        Me.NumericUpDown3.TabIndex = 1
        Me.NumericUpDown3.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Location = New System.Drawing.Point(484, 274)
        Me.NumericUpDown2.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NumericUpDown2.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(79, 34)
        Me.NumericUpDown2.TabIndex = 1
        Me.NumericUpDown2.Tag = "2"
        Me.NumericUpDown2.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(111, 274)
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(49, 34)
        Me.NumericUpDown1.TabIndex = 1
        Me.NumericUpDown1.Tag = "1"
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TabPage3.Location = New System.Drawing.Point(4, 34)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1016, 448)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "TabPage3"
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TabPage4.Controls.Add(Me.PictureBox6)
        Me.TabPage4.Controls.Add(Me.GroupBox5)
        Me.TabPage4.Controls.Add(Me.GroupBox4)
        Me.TabPage4.Controls.Add(Me.GroupBox3)
        Me.TabPage4.Controls.Add(Me.Label15)
        Me.TabPage4.Controls.Add(Me.PictureBox3)
        Me.TabPage4.Controls.Add(Me.Label12)
        Me.TabPage4.Controls.Add(Me.Label8)
        Me.TabPage4.Location = New System.Drawing.Point(4, 34)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1016, 448)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "TabPage4"
        '
        'ImageList_usbStatus
        '
        Me.ImageList_usbStatus.ImageStream = CType(resources.GetObject("ImageList_usbStatus.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList_usbStatus.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList_usbStatus.Images.SetKeyName(0, "icons8-usb-on-26.png")
        Me.ImageList_usbStatus.Images.SetKeyName(1, "icons8-usb-connected-26.png")
        Me.ImageList_usbStatus.Images.SetKeyName(2, "icons8-usb-disconnected-26.png")
        '
        'BackgroundWorker_connect
        '
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'Timer_ReadStatus
        '
        '
        'bwork_readstatus
        '
        Me.bwork_readstatus.WorkerSupportsCancellation = True
        '
        'IsPLC_IO_Card1
        '
        Me.IsPLC_IO_Card1.PortName = Nothing
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("微軟正黑體", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label8.Location = New System.Drawing.Point(95, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 56)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "關於"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label12.Location = New System.Drawing.Point(99, 61)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(873, 1)
        Me.Label12.TabIndex = 2
        '
        'Label15
        '
        Me.Label15.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label15.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label15.Location = New System.Drawing.Point(3, 415)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(1010, 30)
        Me.Label15.TabIndex = 4
        Me.Label15.Text = "宇創客工作室版權所有"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LinkLabel1.Location = New System.Drawing.Point(3, 145)
        Me.LinkLabel1.Margin = New System.Windows.Forms.Padding(3, 0, 3, 10)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.LinkLabel1.Size = New System.Drawing.Size(144, 50)
        Me.LinkLabel1.TabIndex = 6
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "RasHag"
        Me.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.PictureBox2)
        Me.GroupBox3.Controls.Add(Me.LinkLabel1)
        Me.GroupBox3.Font = New System.Drawing.Font("微軟正黑體", 16.2!, System.Drawing.FontStyle.Bold)
        Me.GroupBox3.Location = New System.Drawing.Point(383, 81)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(150, 198)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "程式設計"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.PictureBox4)
        Me.GroupBox4.Font = New System.Drawing.Font("微軟正黑體", 16.2!, System.Drawing.FontStyle.Bold)
        Me.GroupBox4.Location = New System.Drawing.Point(549, 81)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(150, 198)
        Me.GroupBox4.TabIndex = 7
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "機構設計"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label16)
        Me.GroupBox5.Controls.Add(Me.PictureBox5)
        Me.GroupBox5.Font = New System.Drawing.Font("微軟正黑體", 16.2!, System.Drawing.FontStyle.Bold)
        Me.GroupBox5.Location = New System.Drawing.Point(714, 81)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(150, 198)
        Me.GroupBox5.TabIndex = 7
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "顧問"
        '
        'Label16
        '
        Me.Label16.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label16.Location = New System.Drawing.Point(3, 145)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(144, 50)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "天空之痕"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label18
        '
        Me.Label18.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label18.Location = New System.Drawing.Point(3, 145)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(144, 50)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "多多壞壞"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Button7
        '
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.White
        Me.Button7.Image = Global.自動撥線機.My.Resources.Resources.icons8_about_64
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.Location = New System.Drawing.Point(-2, 255)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(290, 77)
        Me.Button7.TabIndex = 1
        Me.Button7.Tag = "3"
        Me.Button7.Text = "About    "
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Image = Global.自動撥線機.My.Resources.Resources.icons8_joystick_64
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(-2, 172)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(290, 77)
        Me.Button6.TabIndex = 1
        Me.Button6.Tag = "2"
        Me.Button6.Text = "Manual    "
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button6.UseVisualStyleBackColor = True
        Me.Button6.Visible = False
        '
        'Button5
        '
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Image = Global.自動撥線機.My.Resources.Resources.icons8_tune_64
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(-2, 89)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(290, 77)
        Me.Button5.TabIndex = 1
        Me.Button5.Tag = "1"
        Me.Button5.Text = "Settings    "
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Image = Global.自動撥線機.My.Resources.Resources.icons8_home_64
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(-2, 6)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(290, 77)
        Me.Button4.TabIndex = 1
        Me.Button4.Tag = "0"
        Me.Button4.Text = "Home    "
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = True
        '
        'pb_open
        '
        Me.pb_open.Image = Global.自動撥線機.My.Resources.Resources.redd
        Me.pb_open.Location = New System.Drawing.Point(367, 187)
        Me.pb_open.Name = "pb_open"
        Me.pb_open.Size = New System.Drawing.Size(100, 60)
        Me.pb_open.TabIndex = 7
        Me.pb_open.TabStop = False
        '
        'pb_feed
        '
        Me.pb_feed.Image = Global.自動撥線機.My.Resources.Resources.redd
        Me.pb_feed.Location = New System.Drawing.Point(367, 71)
        Me.pb_feed.Name = "pb_feed"
        Me.pb_feed.Size = New System.Drawing.Size(100, 60)
        Me.pb_feed.TabIndex = 6
        Me.pb_feed.TabStop = False
        '
        'pb_red
        '
        Me.pb_red.Image = Global.自動撥線機.My.Resources.Resources.nl
        Me.pb_red.Location = New System.Drawing.Point(148, 199)
        Me.pb_red.Name = "pb_red"
        Me.pb_red.Size = New System.Drawing.Size(64, 64)
        Me.pb_red.TabIndex = 1
        Me.pb_red.TabStop = False
        '
        'btn_stop
        '
        Me.btn_stop.FlatAppearance.BorderSize = 0
        Me.btn_stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_stop.Image = Global.自動撥線機.My.Resources.Resources.icons8_pause_button_80
        Me.btn_stop.Location = New System.Drawing.Point(23, 176)
        Me.btn_stop.Name = "btn_stop"
        Me.btn_stop.Size = New System.Drawing.Size(80, 80)
        Me.btn_stop.TabIndex = 0
        Me.btn_stop.UseVisualStyleBackColor = True
        '
        'btn_start
        '
        Me.btn_start.FlatAppearance.BorderSize = 0
        Me.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_start.Image = Global.自動撥線機.My.Resources.Resources.icons8_circled_play_80
        Me.btn_start.Location = New System.Drawing.Point(23, 51)
        Me.btn_start.Name = "btn_start"
        Me.btn_start.Size = New System.Drawing.Size(80, 80)
        Me.btn_start.TabIndex = 0
        Me.btn_start.UseVisualStyleBackColor = True
        '
        'pb_Green
        '
        Me.pb_Green.Image = Global.自動撥線機.My.Resources.Resources.nl
        Me.pb_Green.Location = New System.Drawing.Point(148, 29)
        Me.pb_Green.Name = "pb_Green"
        Me.pb_Green.Size = New System.Drawing.Size(64, 64)
        Me.pb_Green.TabIndex = 1
        Me.pb_Green.TabStop = False
        '
        'pb_Yellow
        '
        Me.pb_Yellow.Image = Global.自動撥線機.My.Resources.Resources.nl
        Me.pb_Yellow.Location = New System.Drawing.Point(148, 114)
        Me.pb_Yellow.Name = "pb_Yellow"
        Me.pb_Yellow.Size = New System.Drawing.Size(64, 64)
        Me.pb_Yellow.TabIndex = 1
        Me.pb_Yellow.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.自動撥線機.My.Resources.Resources.未命名_2
        Me.PictureBox1.Location = New System.Drawing.Point(86, 72)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(881, 223)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.自動撥線機.My.Resources.Resources.aasdasd
        Me.PictureBox6.Location = New System.Drawing.Point(99, 241)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(266, 227)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 8
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox5.Image = Global.自動撥線機.My.Resources.Resources._60dd2184e4f64de7f45073a8309ad2d9
        Me.PictureBox5.Location = New System.Drawing.Point(3, 39)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(144, 94)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 0
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.自動撥線機.My.Resources.Resources._6304126
        Me.PictureBox4.Location = New System.Drawing.Point(3, 39)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(144, 94)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 0
        Me.PictureBox4.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox2.Image = Global.自動撥線機.My.Resources.Resources._6304001
        Me.PictureBox2.Location = New System.Drawing.Point(3, 39)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(144, 94)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.自動撥線機.My.Resources.Resources._169657121_108340540545735_6884104664430673920_n
        Me.PictureBox3.Location = New System.Drawing.Point(99, 81)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(266, 154)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 3
        Me.PictureBox3.TabStop = False
        '
        'tssb_SerialPorts
        '
        Me.tssb_SerialPorts.Font = New System.Drawing.Font("Microsoft JhengHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.tssb_SerialPorts.Image = Global.自動撥線機.My.Resources.Resources.icons8_usb_on_26
        Me.tssb_SerialPorts.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tssb_SerialPorts.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tssb_SerialPorts.Name = "tssb_SerialPorts"
        Me.tssb_SerialPorts.Size = New System.Drawing.Size(155, 30)
        Me.tssb_SerialPorts.Text = "連線 (COM?)"
        Me.tssb_SerialPorts.ToolTipText = "選擇端口"
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(920, -1)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(34, 34)
        Me.Button3.TabIndex = 2
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.Enabled = False
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(953, -1)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(34, 34)
        Me.Button2.TabIndex = 2
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(986, -1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(34, 34)
        Me.Button1.TabIndex = 2
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(1025, 550)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel2.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.NumericUpDown4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.pb_open, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_feed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_red, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_Green, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_Yellow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents Label5 As Label
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents tssb_SerialPorts As ToolStripSplitButton
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As ToolStripStatusLabel
    Friend WithEvents ImageList_usbStatus As ImageList
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel6 As ToolStripStatusLabel
    Friend WithEvents ToolStripProgressBar1 As ToolStripProgressBar
    Friend WithEvents ToolStripStatusLabel7 As ToolStripStatusLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BackgroundWorker_connect As System.ComponentModel.BackgroundWorker
    Friend WithEvents ts_progressBar_connection As ToolStripProgressBar
    Friend WithEvents ToolStripStatusLabel8 As ToolStripStatusLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents btn_start As Button
    Friend WithEvents btn_stop As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents pb_red As PictureBox
    Friend WithEvents pb_Green As PictureBox
    Friend WithEvents pb_Yellow As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents lb_rc As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lb_step As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lb_lcount As Label
    Friend WithEvents lb_cycle As Label
    Friend WithEvents lb_long2 As Label
    Friend WithEvents lb_long As Label
    Friend WithEvents Timer_ReadStatus As Timer
    Friend WithEvents pb_open As PictureBox
    Friend WithEvents pb_feed As PictureBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents NumericUpDown3 As NumericUpDown
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents bwork_readstatus As System.ComponentModel.BackgroundWorker
    Friend WithEvents NumericUpDown4 As NumericUpDown
    Friend WithEvents Label11 As Label
    Friend WithEvents Button8 As Button
    Friend WithEvents IsPLC_IO_Card1 As YSKControlLibrary.isPLC_IO_Card
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label15 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents PictureBox6 As PictureBox
End Class
