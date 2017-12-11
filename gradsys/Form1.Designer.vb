<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
		Me.btnCompute = New System.Windows.Forms.Button()
		Me.btnExit = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.txtFirstname = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.txtLastname = New System.Windows.Forms.TextBox()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.txtAttendTotal = New System.Windows.Forms.TextBox()
		Me.txtAttendperc = New System.Windows.Forms.TextBox()
		Me.txtAttend1 = New System.Windows.Forms.TextBox()
		Me.GroupBox3 = New System.Windows.Forms.GroupBox()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.txtQuiz2 = New System.Windows.Forms.TextBox()
		Me.txtQuiz2total = New System.Windows.Forms.TextBox()
		Me.txtQuiz2perc = New System.Windows.Forms.TextBox()
		Me.GroupBox4 = New System.Windows.Forms.GroupBox()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.txtProject = New System.Windows.Forms.TextBox()
		Me.txtProjecttotal = New System.Windows.Forms.TextBox()
		Me.txtProjectperc = New System.Windows.Forms.TextBox()
		Me.GroupBox5 = New System.Windows.Forms.GroupBox()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.txtFinalexam = New System.Windows.Forms.TextBox()
		Me.txtFinalexamtotal = New System.Windows.Forms.TextBox()
		Me.txtFinalexamperc = New System.Windows.Forms.TextBox()
		Me.GroupBox6 = New System.Windows.Forms.GroupBox()
		Me.txtFinalgrade = New System.Windows.Forms.TextBox()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.txtRemark = New System.Windows.Forms.TextBox()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.txtQuiz1total = New System.Windows.Forms.TextBox()
		Me.txtQuiz1 = New System.Windows.Forms.TextBox()
		Me.txtQuiz1perc = New System.Windows.Forms.TextBox()
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.btnClear = New System.Windows.Forms.Button()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.btnSave = New System.Windows.Forms.Button()
		Me.btnLoad = New System.Windows.Forms.Button()
		Me.btnShowdeets = New System.Windows.Forms.Button()
		Me.FRST = New System.Windows.Forms.Button()
		Me.NXT = New System.Windows.Forms.Button()
		Me.LAST = New System.Windows.Forms.Button()
		Me.PREV = New System.Windows.Forms.Button()
		Me.btnDelete = New System.Windows.Forms.Button()
		Me.btnUpdate = New System.Windows.Forms.Button()
		Me.txtStudentID = New System.Windows.Forms.TextBox()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.GroupBox1.SuspendLayout()
		Me.GroupBox3.SuspendLayout()
		Me.GroupBox4.SuspendLayout()
		Me.GroupBox5.SuspendLayout()
		Me.GroupBox6.SuspendLayout()
		Me.GroupBox2.SuspendLayout()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel1.SuspendLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'btnCompute
		'
		Me.btnCompute.Font = New System.Drawing.Font("Agency FB", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnCompute.ForeColor = System.Drawing.Color.Black
		Me.btnCompute.Location = New System.Drawing.Point(328, 585)
		Me.btnCompute.Name = "btnCompute"
		Me.btnCompute.Size = New System.Drawing.Size(106, 28)
		Me.btnCompute.TabIndex = 0
		Me.btnCompute.Text = "Compute &Grades"
		Me.btnCompute.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.ToolTip1.SetToolTip(Me.btnCompute, "COMPUTE GRADES" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    Automatically compute all the " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "grades of specefic students.")
		Me.btnCompute.UseVisualStyleBackColor = True
		'
		'btnExit
		'
		Me.btnExit.Font = New System.Drawing.Font("Agency FB", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnExit.ForeColor = System.Drawing.Color.Black
		Me.btnExit.Location = New System.Drawing.Point(544, 616)
		Me.btnExit.Name = "btnExit"
		Me.btnExit.Size = New System.Drawing.Size(107, 29)
		Me.btnExit.TabIndex = 1
		Me.btnExit.Text = "&Exit Program"
		Me.btnExit.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.ToolTip1.SetToolTip(Me.btnExit, "EXIT PROGRAM")
		Me.btnExit.UseVisualStyleBackColor = True
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Agency FB", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.White
		Me.Label1.Location = New System.Drawing.Point(222, 71)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(71, 24)
		Me.Label1.TabIndex = 2
		Me.Label1.Text = "Firstname:"
		'
		'txtFirstname
		'
		Me.txtFirstname.Location = New System.Drawing.Point(298, 76)
		Me.txtFirstname.Name = "txtFirstname"
		Me.txtFirstname.Size = New System.Drawing.Size(144, 20)
		Me.txtFirstname.TabIndex = 3
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Agency FB", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.ForeColor = System.Drawing.Color.White
		Me.Label2.Location = New System.Drawing.Point(455, 71)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(69, 24)
		Me.Label2.TabIndex = 4
		Me.Label2.Text = "Lastname:"
		'
		'txtLastname
		'
		Me.txtLastname.Location = New System.Drawing.Point(529, 76)
		Me.txtLastname.Name = "txtLastname"
		Me.txtLastname.Size = New System.Drawing.Size(155, 20)
		Me.txtLastname.TabIndex = 6
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.Label3)
		Me.GroupBox1.Controls.Add(Me.txtAttendTotal)
		Me.GroupBox1.Controls.Add(Me.txtAttendperc)
		Me.GroupBox1.Controls.Add(Me.txtAttend1)
		Me.GroupBox1.Font = New System.Drawing.Font("Agency FB", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.GroupBox1.ForeColor = System.Drawing.Color.White
		Me.GroupBox1.Location = New System.Drawing.Point(13, 103)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(228, 51)
		Me.GroupBox1.TabIndex = 7
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Attendance        20          Percent         10%"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.ForeColor = System.Drawing.Color.White
		Me.Label3.Location = New System.Drawing.Point(14, 22)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(48, 15)
		Me.Label3.TabIndex = 10
		Me.Label3.Text = "Score:"
		'
		'txtAttendTotal
		'
		Me.txtAttendTotal.BackColor = System.Drawing.Color.Red
		Me.txtAttendTotal.Location = New System.Drawing.Point(168, 19)
		Me.txtAttendTotal.Name = "txtAttendTotal"
		Me.txtAttendTotal.ReadOnly = True
		Me.txtAttendTotal.Size = New System.Drawing.Size(46, 25)
		Me.txtAttendTotal.TabIndex = 12
		Me.txtAttendTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'txtAttendperc
		'
		Me.txtAttendperc.BackColor = System.Drawing.Color.Red
		Me.txtAttendperc.Location = New System.Drawing.Point(116, 19)
		Me.txtAttendperc.Name = "txtAttendperc"
		Me.txtAttendperc.ReadOnly = True
		Me.txtAttendperc.Size = New System.Drawing.Size(46, 25)
		Me.txtAttendperc.TabIndex = 11
		Me.txtAttendperc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'txtAttend1
		'
		Me.txtAttend1.AcceptsTab = True
		Me.txtAttend1.Location = New System.Drawing.Point(64, 19)
		Me.txtAttend1.Name = "txtAttend1"
		Me.txtAttend1.Size = New System.Drawing.Size(46, 25)
		Me.txtAttend1.TabIndex = 3
		'
		'GroupBox3
		'
		Me.GroupBox3.Controls.Add(Me.Label5)
		Me.GroupBox3.Controls.Add(Me.txtQuiz2)
		Me.GroupBox3.Controls.Add(Me.txtQuiz2total)
		Me.GroupBox3.Controls.Add(Me.txtQuiz2perc)
		Me.GroupBox3.Font = New System.Drawing.Font("Agency FB", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.GroupBox3.ForeColor = System.Drawing.Color.White
		Me.GroupBox3.Location = New System.Drawing.Point(12, 223)
		Me.GroupBox3.Name = "GroupBox3"
		Me.GroupBox3.Size = New System.Drawing.Size(228, 54)
		Me.GroupBox3.TabIndex = 8
		Me.GroupBox3.TabStop = False
		Me.GroupBox3.Text = "Quiz 2               50          Percent         20%"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.ForeColor = System.Drawing.Color.White
		Me.Label5.Location = New System.Drawing.Point(18, 22)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(48, 15)
		Me.Label5.TabIndex = 18
		Me.Label5.Text = "Score:"
		'
		'txtQuiz2
		'
		Me.txtQuiz2.Location = New System.Drawing.Point(65, 19)
		Me.txtQuiz2.Name = "txtQuiz2"
		Me.txtQuiz2.Size = New System.Drawing.Size(46, 25)
		Me.txtQuiz2.TabIndex = 5
		'
		'txtQuiz2total
		'
		Me.txtQuiz2total.BackColor = System.Drawing.Color.Red
		Me.txtQuiz2total.Location = New System.Drawing.Point(169, 19)
		Me.txtQuiz2total.Name = "txtQuiz2total"
		Me.txtQuiz2total.ReadOnly = True
		Me.txtQuiz2total.Size = New System.Drawing.Size(46, 25)
		Me.txtQuiz2total.TabIndex = 19
		Me.txtQuiz2total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'txtQuiz2perc
		'
		Me.txtQuiz2perc.BackColor = System.Drawing.Color.Red
		Me.txtQuiz2perc.Location = New System.Drawing.Point(117, 19)
		Me.txtQuiz2perc.Name = "txtQuiz2perc"
		Me.txtQuiz2perc.ReadOnly = True
		Me.txtQuiz2perc.Size = New System.Drawing.Size(46, 25)
		Me.txtQuiz2perc.TabIndex = 20
		Me.txtQuiz2perc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'GroupBox4
		'
		Me.GroupBox4.Controls.Add(Me.Label6)
		Me.GroupBox4.Controls.Add(Me.txtProject)
		Me.GroupBox4.Controls.Add(Me.txtProjecttotal)
		Me.GroupBox4.Controls.Add(Me.txtProjectperc)
		Me.GroupBox4.Font = New System.Drawing.Font("Agency FB", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.GroupBox4.ForeColor = System.Drawing.Color.White
		Me.GroupBox4.Location = New System.Drawing.Point(12, 284)
		Me.GroupBox4.Name = "GroupBox4"
		Me.GroupBox4.Size = New System.Drawing.Size(228, 51)
		Me.GroupBox4.TabIndex = 8
		Me.GroupBox4.TabStop = False
		Me.GroupBox4.Text = "Project              100          Percent        30%"
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.ForeColor = System.Drawing.Color.White
		Me.Label6.Location = New System.Drawing.Point(15, 22)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(48, 15)
		Me.Label6.TabIndex = 22
		Me.Label6.Text = "Score:"
		'
		'txtProject
		'
		Me.txtProject.Location = New System.Drawing.Point(65, 19)
		Me.txtProject.Name = "txtProject"
		Me.txtProject.Size = New System.Drawing.Size(46, 25)
		Me.txtProject.TabIndex = 6
		'
		'txtProjecttotal
		'
		Me.txtProjecttotal.BackColor = System.Drawing.Color.Red
		Me.txtProjecttotal.Location = New System.Drawing.Point(169, 19)
		Me.txtProjecttotal.Name = "txtProjecttotal"
		Me.txtProjecttotal.ReadOnly = True
		Me.txtProjecttotal.Size = New System.Drawing.Size(46, 25)
		Me.txtProjecttotal.TabIndex = 24
		Me.txtProjecttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'txtProjectperc
		'
		Me.txtProjectperc.BackColor = System.Drawing.Color.Red
		Me.txtProjectperc.Location = New System.Drawing.Point(117, 19)
		Me.txtProjectperc.Name = "txtProjectperc"
		Me.txtProjectperc.ReadOnly = True
		Me.txtProjectperc.Size = New System.Drawing.Size(46, 25)
		Me.txtProjectperc.TabIndex = 23
		Me.txtProjectperc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'GroupBox5
		'
		Me.GroupBox5.Controls.Add(Me.Label7)
		Me.GroupBox5.Controls.Add(Me.txtFinalexam)
		Me.GroupBox5.Controls.Add(Me.txtFinalexamtotal)
		Me.GroupBox5.Controls.Add(Me.txtFinalexamperc)
		Me.GroupBox5.Font = New System.Drawing.Font("Agency FB", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.GroupBox5.ForeColor = System.Drawing.Color.White
		Me.GroupBox5.Location = New System.Drawing.Point(12, 341)
		Me.GroupBox5.Name = "GroupBox5"
		Me.GroupBox5.Size = New System.Drawing.Size(228, 57)
		Me.GroupBox5.TabIndex = 8
		Me.GroupBox5.TabStop = False
		Me.GroupBox5.Text = "Final Exam         100          Percent        30%"
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.ForeColor = System.Drawing.Color.White
		Me.Label7.Location = New System.Drawing.Point(15, 22)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(48, 15)
		Me.Label7.TabIndex = 26
		Me.Label7.Text = "Score:"
		'
		'txtFinalexam
		'
		Me.txtFinalexam.Location = New System.Drawing.Point(65, 19)
		Me.txtFinalexam.Name = "txtFinalexam"
		Me.txtFinalexam.Size = New System.Drawing.Size(46, 25)
		Me.txtFinalexam.TabIndex = 7
		'
		'txtFinalexamtotal
		'
		Me.txtFinalexamtotal.BackColor = System.Drawing.Color.Red
		Me.txtFinalexamtotal.Location = New System.Drawing.Point(169, 19)
		Me.txtFinalexamtotal.Name = "txtFinalexamtotal"
		Me.txtFinalexamtotal.ReadOnly = True
		Me.txtFinalexamtotal.Size = New System.Drawing.Size(46, 25)
		Me.txtFinalexamtotal.TabIndex = 27
		Me.txtFinalexamtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'txtFinalexamperc
		'
		Me.txtFinalexamperc.BackColor = System.Drawing.Color.Red
		Me.txtFinalexamperc.Location = New System.Drawing.Point(116, 19)
		Me.txtFinalexamperc.Name = "txtFinalexamperc"
		Me.txtFinalexamperc.ReadOnly = True
		Me.txtFinalexamperc.Size = New System.Drawing.Size(46, 25)
		Me.txtFinalexamperc.TabIndex = 28
		Me.txtFinalexamperc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'GroupBox6
		'
		Me.GroupBox6.Controls.Add(Me.txtFinalgrade)
		Me.GroupBox6.Controls.Add(Me.Label9)
		Me.GroupBox6.Controls.Add(Me.txtRemark)
		Me.GroupBox6.Controls.Add(Me.Label8)
		Me.GroupBox6.Font = New System.Drawing.Font("Agency FB", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.GroupBox6.ForeColor = System.Drawing.Color.White
		Me.GroupBox6.Location = New System.Drawing.Point(254, 103)
		Me.GroupBox6.Name = "GroupBox6"
		Me.GroupBox6.Size = New System.Drawing.Size(228, 295)
		Me.GroupBox6.TabIndex = 9
		Me.GroupBox6.TabStop = False
		Me.GroupBox6.Text = "Final Computed"
		'
		'txtFinalgrade
		'
		Me.txtFinalgrade.BackColor = System.Drawing.Color.Red
		Me.txtFinalgrade.Font = New System.Drawing.Font("Agency FB", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtFinalgrade.Location = New System.Drawing.Point(19, 41)
		Me.txtFinalgrade.Multiline = True
		Me.txtFinalgrade.Name = "txtFinalgrade"
		Me.txtFinalgrade.ReadOnly = True
		Me.txtFinalgrade.Size = New System.Drawing.Size(192, 112)
		Me.txtFinalgrade.TabIndex = 29
		Me.txtFinalgrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label9.ForeColor = System.Drawing.Color.White
		Me.Label9.Location = New System.Drawing.Point(16, 155)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(68, 15)
		Me.Label9.TabIndex = 30
		Me.Label9.Text = "Remarks:"
		'
		'txtRemark
		'
		Me.txtRemark.BackColor = System.Drawing.Color.Red
		Me.txtRemark.Font = New System.Drawing.Font("Agency FB", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtRemark.Location = New System.Drawing.Point(19, 173)
		Me.txtRemark.Multiline = True
		Me.txtRemark.Name = "txtRemark"
		Me.txtRemark.ReadOnly = True
		Me.txtRemark.Size = New System.Drawing.Size(192, 108)
		Me.txtRemark.TabIndex = 30
		Me.txtRemark.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label8.ForeColor = System.Drawing.Color.White
		Me.Label8.Location = New System.Drawing.Point(16, 22)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(86, 15)
		Me.Label8.TabIndex = 29
		Me.Label8.Text = "Final Grade:"
		'
		'GroupBox2
		'
		Me.GroupBox2.Controls.Add(Me.Label4)
		Me.GroupBox2.Controls.Add(Me.txtQuiz1total)
		Me.GroupBox2.Controls.Add(Me.txtQuiz1)
		Me.GroupBox2.Controls.Add(Me.txtQuiz1perc)
		Me.GroupBox2.Font = New System.Drawing.Font("Agency FB", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.GroupBox2.ForeColor = System.Drawing.Color.White
		Me.GroupBox2.Location = New System.Drawing.Point(13, 162)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(228, 57)
		Me.GroupBox2.TabIndex = 8
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = "Quiz 1                50          Percent         10%"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.ForeColor = System.Drawing.Color.White
		Me.Label4.Location = New System.Drawing.Point(14, 22)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(48, 15)
		Me.Label4.TabIndex = 14
		Me.Label4.Text = "Score:"
		'
		'txtQuiz1total
		'
		Me.txtQuiz1total.BackColor = System.Drawing.Color.Red
		Me.txtQuiz1total.Location = New System.Drawing.Point(168, 19)
		Me.txtQuiz1total.Name = "txtQuiz1total"
		Me.txtQuiz1total.ReadOnly = True
		Me.txtQuiz1total.Size = New System.Drawing.Size(46, 25)
		Me.txtQuiz1total.TabIndex = 13
		Me.txtQuiz1total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'txtQuiz1
		'
		Me.txtQuiz1.AcceptsTab = True
		Me.txtQuiz1.Location = New System.Drawing.Point(64, 19)
		Me.txtQuiz1.Name = "txtQuiz1"
		Me.txtQuiz1.Size = New System.Drawing.Size(46, 25)
		Me.txtQuiz1.TabIndex = 4
		'
		'txtQuiz1perc
		'
		Me.txtQuiz1perc.BackColor = System.Drawing.Color.Red
		Me.txtQuiz1perc.Location = New System.Drawing.Point(116, 19)
		Me.txtQuiz1perc.Name = "txtQuiz1perc"
		Me.txtQuiz1perc.ReadOnly = True
		Me.txtQuiz1perc.Size = New System.Drawing.Size(46, 25)
		Me.txtQuiz1perc.TabIndex = 15
		Me.txtQuiz1perc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'DataGridView1
		'
		Me.DataGridView1.BackgroundColor = System.Drawing.Color.Black
		DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
		DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
		DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
		DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
		DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
		Me.DataGridView1.Enabled = False
		Me.DataGridView1.Location = New System.Drawing.Point(10, 431)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.DataGridView1.RowHeadersWidth = 15
		Me.DataGridView1.Size = New System.Drawing.Size(817, 123)
		Me.DataGridView1.TabIndex = 10
		'
		'Label10
		'
		Me.Label10.AutoSize = True
		Me.Label10.Font = New System.Drawing.Font("Agency FB", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label10.ForeColor = System.Drawing.Color.White
		Me.Label10.Location = New System.Drawing.Point(12, 414)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(52, 24)
		Me.Label10.TabIndex = 11
		Me.Label10.Text = "Results"
		'
		'btnClear
		'
		Me.btnClear.Font = New System.Drawing.Font("Agency FB", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnClear.ForeColor = System.Drawing.Color.Black
		Me.btnClear.Location = New System.Drawing.Point(220, 585)
		Me.btnClear.Name = "btnClear"
		Me.btnClear.Size = New System.Drawing.Size(107, 28)
		Me.btnClear.TabIndex = 12
		Me.btnClear.Text = "&Clear All Grades:"
		Me.btnClear.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.ToolTip1.SetToolTip(Me.btnClear, "CLEAR ALL" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Allows you to erase all the current details " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "that can be found in all" &
		" textbox.")
		Me.btnClear.UseVisualStyleBackColor = True
		'
		'Label11
		'
		Me.Label11.AutoSize = True
		Me.Label11.BackColor = System.Drawing.Color.White
		Me.Label11.Font = New System.Drawing.Font("Agency FB", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label11.ForeColor = System.Drawing.Color.Red
		Me.Label11.Location = New System.Drawing.Point(284, 4)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(317, 59)
		Me.Label11.TabIndex = 13
		Me.Label11.Text = "STUDENT RECORDS"
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.Color.White
		Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Panel1.Controls.Add(Me.Label11)
		Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
		Me.Panel1.Location = New System.Drawing.Point(0, 0)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(858, 65)
		Me.Panel1.TabIndex = 14
		'
		'btnSave
		'
		Me.btnSave.Font = New System.Drawing.Font("Agency FB", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnSave.ForeColor = System.Drawing.Color.Black
		Me.btnSave.Location = New System.Drawing.Point(544, 585)
		Me.btnSave.Name = "btnSave"
		Me.btnSave.Size = New System.Drawing.Size(107, 28)
		Me.btnSave.TabIndex = 15
		Me.btnSave.Text = "&Save Record"
		Me.btnSave.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.ToolTip1.SetToolTip(Me.btnSave, "SAVE RECORD" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    It allow's the user to save the new record.")
		Me.btnSave.UseVisualStyleBackColor = True
		'
		'btnLoad
		'
		Me.btnLoad.Font = New System.Drawing.Font("Agency FB", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnLoad.ForeColor = System.Drawing.Color.Black
		Me.btnLoad.Location = New System.Drawing.Point(434, 585)
		Me.btnLoad.Name = "btnLoad"
		Me.btnLoad.Size = New System.Drawing.Size(107, 28)
		Me.btnLoad.TabIndex = 16
		Me.btnLoad.Text = "&Load Students"
		Me.btnLoad.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.ToolTip1.SetToolTip(Me.btnLoad, "LOAD STUDENTS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    It loads all the student information in the datagridview." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "And" &
		" the user's are allow to view specefic student's data by" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "double clicking the ce" &
		"lls.")
		Me.btnLoad.UseVisualStyleBackColor = True
		'
		'btnShowdeets
		'
		Me.btnShowdeets.Font = New System.Drawing.Font("Agency FB", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnShowdeets.ForeColor = System.Drawing.Color.Black
		Me.btnShowdeets.Location = New System.Drawing.Point(220, 615)
		Me.btnShowdeets.Name = "btnShowdeets"
		Me.btnShowdeets.Size = New System.Drawing.Size(107, 30)
		Me.btnShowdeets.TabIndex = 17
		Me.btnShowdeets.Text = "Show Details"
		Me.btnShowdeets.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.ToolTip1.SetToolTip(Me.btnShowdeets, "SHOW DETAILS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "     Let's you to view the current detail of the specefic " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "student" &
		" you selected in the datagridview.")
		Me.btnShowdeets.UseVisualStyleBackColor = True
		'
		'FRST
		'
		Me.FRST.Font = New System.Drawing.Font("Agency FB", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FRST.ForeColor = System.Drawing.Color.Black
		Me.FRST.Location = New System.Drawing.Point(328, 652)
		Me.FRST.Name = "FRST"
		Me.FRST.Size = New System.Drawing.Size(51, 21)
		Me.FRST.TabIndex = 18
		Me.FRST.Text = "<<"
		Me.FRST.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.ToolTip1.SetToolTip(Me.FRST, "FIRST RECORD")
		Me.FRST.UseVisualStyleBackColor = True
		'
		'NXT
		'
		Me.NXT.Font = New System.Drawing.Font("Agency FB", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.NXT.ForeColor = System.Drawing.Color.Black
		Me.NXT.Location = New System.Drawing.Point(434, 652)
		Me.NXT.Name = "NXT"
		Me.NXT.Size = New System.Drawing.Size(48, 21)
		Me.NXT.TabIndex = 19
		Me.NXT.Text = ">"
		Me.NXT.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.ToolTip1.SetToolTip(Me.NXT, "NEXT")
		Me.NXT.UseVisualStyleBackColor = True
		'
		'LAST
		'
		Me.LAST.Font = New System.Drawing.Font("Agency FB", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LAST.ForeColor = System.Drawing.Color.Black
		Me.LAST.Location = New System.Drawing.Point(486, 652)
		Me.LAST.Name = "LAST"
		Me.LAST.Size = New System.Drawing.Size(51, 21)
		Me.LAST.TabIndex = 20
		Me.LAST.Text = ">>"
		Me.LAST.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.ToolTip1.SetToolTip(Me.LAST, "LAST RECORD")
		Me.LAST.UseVisualStyleBackColor = True
		'
		'PREV
		'
		Me.PREV.Font = New System.Drawing.Font("Agency FB", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.PREV.ForeColor = System.Drawing.Color.Black
		Me.PREV.Location = New System.Drawing.Point(384, 652)
		Me.PREV.Name = "PREV"
		Me.PREV.Size = New System.Drawing.Size(49, 21)
		Me.PREV.TabIndex = 21
		Me.PREV.Text = "<"
		Me.PREV.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.ToolTip1.SetToolTip(Me.PREV, "PREVIOUS")
		Me.PREV.UseVisualStyleBackColor = True
		'
		'btnDelete
		'
		Me.btnDelete.Font = New System.Drawing.Font("Agency FB", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnDelete.ForeColor = System.Drawing.Color.Black
		Me.btnDelete.Location = New System.Drawing.Point(328, 615)
		Me.btnDelete.Name = "btnDelete"
		Me.btnDelete.Size = New System.Drawing.Size(106, 30)
		Me.btnDelete.TabIndex = 22
		Me.btnDelete.Text = "Delete Record"
		Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.ToolTip1.SetToolTip(Me.btnDelete, "DELETE RECORD" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "     It delete the any unnecessary record.")
		Me.btnDelete.UseVisualStyleBackColor = True
		'
		'btnUpdate
		'
		Me.btnUpdate.Font = New System.Drawing.Font("Agency FB", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnUpdate.ForeColor = System.Drawing.Color.Black
		Me.btnUpdate.Location = New System.Drawing.Point(434, 614)
		Me.btnUpdate.Name = "btnUpdate"
		Me.btnUpdate.Size = New System.Drawing.Size(107, 32)
		Me.btnUpdate.TabIndex = 23
		Me.btnUpdate.Text = "Update Record"
		Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.ToolTip1.SetToolTip(Me.btnUpdate, "UPDATE RECORD" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "     It allows you to upadate any changes" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "you made to the current" &
		" record.")
		Me.btnUpdate.UseVisualStyleBackColor = True
		'
		'txtStudentID
		'
		Me.txtStudentID.Location = New System.Drawing.Point(90, 76)
		Me.txtStudentID.Name = "txtStudentID"
		Me.txtStudentID.Size = New System.Drawing.Size(124, 20)
		Me.txtStudentID.TabIndex = 25
		'
		'Label12
		'
		Me.Label12.AutoSize = True
		Me.Label12.Font = New System.Drawing.Font("Agency FB", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label12.ForeColor = System.Drawing.Color.White
		Me.Label12.Location = New System.Drawing.Point(10, 71)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(71, 24)
		Me.Label12.TabIndex = 24
		Me.Label12.Text = "Student ID:"
		'
		'PictureBox1
		'
		Me.PictureBox1.BackColor = System.Drawing.Color.White
		Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
		Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.PictureBox1.Location = New System.Drawing.Point(501, 122)
		Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(326, 276)
		Me.PictureBox1.TabIndex = 26
		Me.PictureBox1.TabStop = False
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.AutoSize = True
		Me.BackColor = System.Drawing.Color.Black
		Me.ClientSize = New System.Drawing.Size(858, 688)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.txtStudentID)
		Me.Controls.Add(Me.Label12)
		Me.Controls.Add(Me.btnUpdate)
		Me.Controls.Add(Me.btnDelete)
		Me.Controls.Add(Me.GroupBox4)
		Me.Controls.Add(Me.PREV)
		Me.Controls.Add(Me.LAST)
		Me.Controls.Add(Me.NXT)
		Me.Controls.Add(Me.FRST)
		Me.Controls.Add(Me.btnShowdeets)
		Me.Controls.Add(Me.btnLoad)
		Me.Controls.Add(Me.btnSave)
		Me.Controls.Add(Me.Panel1)
		Me.Controls.Add(Me.btnClear)
		Me.Controls.Add(Me.Label10)
		Me.Controls.Add(Me.DataGridView1)
		Me.Controls.Add(Me.GroupBox6)
		Me.Controls.Add(Me.GroupBox2)
		Me.Controls.Add(Me.GroupBox3)
		Me.Controls.Add(Me.GroupBox5)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.txtLastname)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.txtFirstname)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.btnExit)
		Me.Controls.Add(Me.btnCompute)
		Me.ForeColor = System.Drawing.Color.Black
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "Form1"
		Me.Text = "Grading System"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.GroupBox3.ResumeLayout(False)
		Me.GroupBox3.PerformLayout()
		Me.GroupBox4.ResumeLayout(False)
		Me.GroupBox4.PerformLayout()
		Me.GroupBox5.ResumeLayout(False)
		Me.GroupBox5.PerformLayout()
		Me.GroupBox6.ResumeLayout(False)
		Me.GroupBox6.PerformLayout()
		Me.GroupBox2.ResumeLayout(False)
		Me.GroupBox2.PerformLayout()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel1.ResumeLayout(False)
		Me.Panel1.PerformLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents btnCompute As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFirstname As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtLastname As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtAttendTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtAttendperc As System.Windows.Forms.TextBox
    Friend WithEvents txtAttend1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtQuiz1total As System.Windows.Forms.TextBox
    Friend WithEvents txtQuiz1 As System.Windows.Forms.TextBox
    Friend WithEvents txtQuiz1perc As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtQuiz2 As System.Windows.Forms.TextBox
    Friend WithEvents txtQuiz2total As System.Windows.Forms.TextBox
    Friend WithEvents txtQuiz2perc As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtProject As System.Windows.Forms.TextBox
    Friend WithEvents txtProjecttotal As System.Windows.Forms.TextBox
    Friend WithEvents txtProjectperc As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtFinalexam As System.Windows.Forms.TextBox
    Friend WithEvents txtFinalexamtotal As System.Windows.Forms.TextBox
    Friend WithEvents txtFinalexamperc As System.Windows.Forms.TextBox
    Friend WithEvents txtFinalgrade As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtRemark As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents btnShowdeets As System.Windows.Forms.Button
    Friend WithEvents FRST As System.Windows.Forms.Button
    Friend WithEvents NXT As System.Windows.Forms.Button
    Friend WithEvents LAST As System.Windows.Forms.Button
    Friend WithEvents PREV As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents txtStudentID As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents PictureBox1 As PictureBox
End Class
