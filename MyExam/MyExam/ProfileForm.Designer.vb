﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProfileForm
    Inherits MyExam.BaseMainForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.ProfileTabPage = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ConfirmEditTextBox = New System.Windows.Forms.TextBox()
        Me.ConfirmEditLabel = New System.Windows.Forms.Label()
        Me.ErrorConfirmChangePasswordLabel = New System.Windows.Forms.Label()
        Me.ChangePasswordConfirmTextBox = New System.Windows.Forms.TextBox()
        Me.ChangePasswordConfirmLabel = New System.Windows.Forms.Label()
        Me.ErrorChangePasswordLabel = New System.Windows.Forms.Label()
        Me.ChangePasswordTextBox = New System.Windows.Forms.TextBox()
        Me.ChangePasswordLabel = New System.Windows.Forms.Label()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.ErrorAnswerLabel = New System.Windows.Forms.Label()
        Me.ErrorQuestionLabel = New System.Windows.Forms.Label()
        Me.ErrorEmailLabel = New System.Windows.Forms.Label()
        Me.ErrorPasswordLabel = New System.Windows.Forms.Label()
        Me.AnswerTextBox = New System.Windows.Forms.TextBox()
        Me.QuestionTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.AnswerLabel = New System.Windows.Forms.Label()
        Me.QuestionLabel = New System.Windows.Forms.Label()
        Me.EmailLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.TestListTabPage = New System.Windows.Forms.TabPage()
        Me.TestListTreeView = New System.Windows.Forms.TreeView()
        Me.TestScoreTabPage = New System.Windows.Forms.TabPage()
        Me.TestScoreTreeView = New System.Windows.Forms.TreeView()
        Me.TabControl.SuspendLayout()
        Me.ProfileTabPage.SuspendLayout()
        Me.TestListTabPage.SuspendLayout()
        Me.TestScoreTabPage.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.ProfileTabPage)
        Me.TabControl.Controls.Add(Me.TestListTabPage)
        Me.TabControl.Controls.Add(Me.TestScoreTabPage)
        Me.TabControl.Location = New System.Drawing.Point(12, 49)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(660, 400)
        Me.TabControl.TabIndex = 7
        '
        'ProfileTabPage
        '
        Me.ProfileTabPage.Controls.Add(Me.Label6)
        Me.ProfileTabPage.Controls.Add(Me.ConfirmEditTextBox)
        Me.ProfileTabPage.Controls.Add(Me.ConfirmEditLabel)
        Me.ProfileTabPage.Controls.Add(Me.ErrorConfirmChangePasswordLabel)
        Me.ProfileTabPage.Controls.Add(Me.ChangePasswordConfirmTextBox)
        Me.ProfileTabPage.Controls.Add(Me.ChangePasswordConfirmLabel)
        Me.ProfileTabPage.Controls.Add(Me.ErrorChangePasswordLabel)
        Me.ProfileTabPage.Controls.Add(Me.ChangePasswordTextBox)
        Me.ProfileTabPage.Controls.Add(Me.ChangePasswordLabel)
        Me.ProfileTabPage.Controls.Add(Me.EditButton)
        Me.ProfileTabPage.Controls.Add(Me.ErrorAnswerLabel)
        Me.ProfileTabPage.Controls.Add(Me.ErrorQuestionLabel)
        Me.ProfileTabPage.Controls.Add(Me.ErrorEmailLabel)
        Me.ProfileTabPage.Controls.Add(Me.ErrorPasswordLabel)
        Me.ProfileTabPage.Controls.Add(Me.AnswerTextBox)
        Me.ProfileTabPage.Controls.Add(Me.QuestionTextBox)
        Me.ProfileTabPage.Controls.Add(Me.EmailTextBox)
        Me.ProfileTabPage.Controls.Add(Me.PasswordTextBox)
        Me.ProfileTabPage.Controls.Add(Me.UsernameTextBox)
        Me.ProfileTabPage.Controls.Add(Me.AnswerLabel)
        Me.ProfileTabPage.Controls.Add(Me.QuestionLabel)
        Me.ProfileTabPage.Controls.Add(Me.EmailLabel)
        Me.ProfileTabPage.Controls.Add(Me.PasswordLabel)
        Me.ProfileTabPage.Controls.Add(Me.UsernameLabel)
        Me.ProfileTabPage.Location = New System.Drawing.Point(4, 29)
        Me.ProfileTabPage.Name = "ProfileTabPage"
        Me.ProfileTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.ProfileTabPage.Size = New System.Drawing.Size(652, 367)
        Me.ProfileTabPage.TabIndex = 0
        Me.ProfileTabPage.Text = "ข้อมูลส่วนตัว"
        Me.ProfileTabPage.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(476, 272)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(15, 20)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "*"
        Me.Label6.Visible = False
        '
        'ConfirmEditTextBox
        '
        Me.ConfirmEditTextBox.Location = New System.Drawing.Point(328, 269)
        Me.ConfirmEditTextBox.Name = "ConfirmEditTextBox"
        Me.ConfirmEditTextBox.Size = New System.Drawing.Size(142, 26)
        Me.ConfirmEditTextBox.TabIndex = 46
        Me.ConfirmEditTextBox.UseSystemPasswordChar = True
        '
        'ConfirmEditLabel
        '
        Me.ConfirmEditLabel.AutoSize = True
        Me.ConfirmEditLabel.Location = New System.Drawing.Point(47, 275)
        Me.ConfirmEditLabel.Name = "ConfirmEditLabel"
        Me.ConfirmEditLabel.Size = New System.Drawing.Size(257, 20)
        Me.ConfirmEditLabel.TabIndex = 45
        Me.ConfirmEditLabel.Text = "กรุณาใส่รหัสผ่าน หากต้องการแก้ไขข้อมูล:"
        '
        'ErrorConfirmChangePasswordLabel
        '
        Me.ErrorConfirmChangePasswordLabel.AutoSize = True
        Me.ErrorConfirmChangePasswordLabel.ForeColor = System.Drawing.Color.Red
        Me.ErrorConfirmChangePasswordLabel.Location = New System.Drawing.Point(476, 230)
        Me.ErrorConfirmChangePasswordLabel.Name = "ErrorConfirmChangePasswordLabel"
        Me.ErrorConfirmChangePasswordLabel.Size = New System.Drawing.Size(15, 20)
        Me.ErrorConfirmChangePasswordLabel.TabIndex = 44
        Me.ErrorConfirmChangePasswordLabel.Text = "*"
        Me.ErrorConfirmChangePasswordLabel.Visible = False
        '
        'ChangePasswordConfirmTextBox
        '
        Me.ChangePasswordConfirmTextBox.Location = New System.Drawing.Point(328, 227)
        Me.ChangePasswordConfirmTextBox.Name = "ChangePasswordConfirmTextBox"
        Me.ChangePasswordConfirmTextBox.Size = New System.Drawing.Size(142, 26)
        Me.ChangePasswordConfirmTextBox.TabIndex = 43
        Me.ChangePasswordConfirmTextBox.UseSystemPasswordChar = True
        '
        'ChangePasswordConfirmLabel
        '
        Me.ChangePasswordConfirmLabel.AutoSize = True
        Me.ChangePasswordConfirmLabel.Location = New System.Drawing.Point(150, 233)
        Me.ChangePasswordConfirmLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ChangePasswordConfirmLabel.Name = "ChangePasswordConfirmLabel"
        Me.ChangePasswordConfirmLabel.Size = New System.Drawing.Size(126, 20)
        Me.ChangePasswordConfirmLabel.TabIndex = 42
        Me.ChangePasswordConfirmLabel.Text = "ยืนยัน รหัสผ่านใหม่:"
        '
        'ErrorChangePasswordLabel
        '
        Me.ErrorChangePasswordLabel.AutoSize = True
        Me.ErrorChangePasswordLabel.ForeColor = System.Drawing.Color.Red
        Me.ErrorChangePasswordLabel.Location = New System.Drawing.Point(476, 198)
        Me.ErrorChangePasswordLabel.Name = "ErrorChangePasswordLabel"
        Me.ErrorChangePasswordLabel.Size = New System.Drawing.Size(15, 20)
        Me.ErrorChangePasswordLabel.TabIndex = 41
        Me.ErrorChangePasswordLabel.Text = "*"
        Me.ErrorChangePasswordLabel.Visible = False
        '
        'ChangePasswordTextBox
        '
        Me.ChangePasswordTextBox.Location = New System.Drawing.Point(328, 195)
        Me.ChangePasswordTextBox.Name = "ChangePasswordTextBox"
        Me.ChangePasswordTextBox.Size = New System.Drawing.Size(142, 26)
        Me.ChangePasswordTextBox.TabIndex = 40
        Me.ChangePasswordTextBox.UseSystemPasswordChar = True
        '
        'ChangePasswordLabel
        '
        Me.ChangePasswordLabel.AutoSize = True
        Me.ChangePasswordLabel.Location = New System.Drawing.Point(174, 198)
        Me.ChangePasswordLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ChangePasswordLabel.Name = "ChangePasswordLabel"
        Me.ChangePasswordLabel.Size = New System.Drawing.Size(102, 20)
        Me.ChangePasswordLabel.TabIndex = 39
        Me.ChangePasswordLabel.Text = "เปลี่ยนรหัสผ่าน:"
        '
        'EditButton
        '
        Me.EditButton.AutoSize = True
        Me.EditButton.Location = New System.Drawing.Point(273, 318)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(88, 30)
        Me.EditButton.TabIndex = 38
        Me.EditButton.Text = "แก้ไขข้อมูล"
        Me.EditButton.UseVisualStyleBackColor = True
        '
        'ErrorAnswerLabel
        '
        Me.ErrorAnswerLabel.AutoSize = True
        Me.ErrorAnswerLabel.ForeColor = System.Drawing.Color.Red
        Me.ErrorAnswerLabel.Location = New System.Drawing.Point(521, 152)
        Me.ErrorAnswerLabel.Name = "ErrorAnswerLabel"
        Me.ErrorAnswerLabel.Size = New System.Drawing.Size(15, 20)
        Me.ErrorAnswerLabel.TabIndex = 37
        Me.ErrorAnswerLabel.Text = "*"
        Me.ErrorAnswerLabel.Visible = False
        '
        'ErrorQuestionLabel
        '
        Me.ErrorQuestionLabel.AutoSize = True
        Me.ErrorQuestionLabel.ForeColor = System.Drawing.Color.Red
        Me.ErrorQuestionLabel.Location = New System.Drawing.Point(521, 120)
        Me.ErrorQuestionLabel.Name = "ErrorQuestionLabel"
        Me.ErrorQuestionLabel.Size = New System.Drawing.Size(15, 20)
        Me.ErrorQuestionLabel.TabIndex = 36
        Me.ErrorQuestionLabel.Text = "*"
        Me.ErrorQuestionLabel.Visible = False
        '
        'ErrorEmailLabel
        '
        Me.ErrorEmailLabel.AutoSize = True
        Me.ErrorEmailLabel.ForeColor = System.Drawing.Color.Red
        Me.ErrorEmailLabel.Location = New System.Drawing.Point(521, 88)
        Me.ErrorEmailLabel.Name = "ErrorEmailLabel"
        Me.ErrorEmailLabel.Size = New System.Drawing.Size(15, 20)
        Me.ErrorEmailLabel.TabIndex = 35
        Me.ErrorEmailLabel.Text = "*"
        Me.ErrorEmailLabel.Visible = False
        '
        'ErrorPasswordLabel
        '
        Me.ErrorPasswordLabel.AutoSize = True
        Me.ErrorPasswordLabel.ForeColor = System.Drawing.Color.Red
        Me.ErrorPasswordLabel.Location = New System.Drawing.Point(476, 56)
        Me.ErrorPasswordLabel.Name = "ErrorPasswordLabel"
        Me.ErrorPasswordLabel.Size = New System.Drawing.Size(15, 20)
        Me.ErrorPasswordLabel.TabIndex = 33
        Me.ErrorPasswordLabel.Text = "*"
        Me.ErrorPasswordLabel.Visible = False
        '
        'AnswerTextBox
        '
        Me.AnswerTextBox.Location = New System.Drawing.Point(328, 149)
        Me.AnswerTextBox.Name = "AnswerTextBox"
        Me.AnswerTextBox.Size = New System.Drawing.Size(187, 26)
        Me.AnswerTextBox.TabIndex = 31
        '
        'QuestionTextBox
        '
        Me.QuestionTextBox.Location = New System.Drawing.Point(328, 117)
        Me.QuestionTextBox.Name = "QuestionTextBox"
        Me.QuestionTextBox.Size = New System.Drawing.Size(187, 26)
        Me.QuestionTextBox.TabIndex = 30
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Location = New System.Drawing.Point(328, 85)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(187, 26)
        Me.EmailTextBox.TabIndex = 29
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Location = New System.Drawing.Point(328, 53)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(142, 26)
        Me.PasswordTextBox.TabIndex = 27
        Me.PasswordTextBox.UseSystemPasswordChar = True
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.Enabled = False
        Me.UsernameTextBox.Location = New System.Drawing.Point(328, 21)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(142, 26)
        Me.UsernameTextBox.TabIndex = 26
        '
        'AnswerLabel
        '
        Me.AnswerLabel.AutoSize = True
        Me.AnswerLabel.Location = New System.Drawing.Point(126, 152)
        Me.AnswerLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AnswerLabel.Name = "AnswerLabel"
        Me.AnswerLabel.Size = New System.Drawing.Size(150, 20)
        Me.AnswerLabel.TabIndex = 25
        Me.AnswerLabel.Text = "คำตอบ เมื่อลืมรหัสผ่าน:"
        '
        'QuestionLabel
        '
        Me.QuestionLabel.AutoSize = True
        Me.QuestionLabel.Location = New System.Drawing.Point(126, 120)
        Me.QuestionLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.QuestionLabel.Name = "QuestionLabel"
        Me.QuestionLabel.Size = New System.Drawing.Size(150, 20)
        Me.QuestionLabel.TabIndex = 24
        Me.QuestionLabel.Text = "คำถาม เมื่อลืมรหัสผ่าน:"
        '
        'EmailLabel
        '
        Me.EmailLabel.AutoSize = True
        Me.EmailLabel.Location = New System.Drawing.Point(231, 88)
        Me.EmailLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.EmailLabel.Name = "EmailLabel"
        Me.EmailLabel.Size = New System.Drawing.Size(45, 20)
        Me.EmailLabel.TabIndex = 23
        Me.EmailLabel.Text = "อีเมล:"
        '
        'PasswordLabel
        '
        Me.PasswordLabel.AutoSize = True
        Me.PasswordLabel.Location = New System.Drawing.Point(214, 56)
        Me.PasswordLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(62, 20)
        Me.PasswordLabel.TabIndex = 21
        Me.PasswordLabel.Text = "รหัสผ่าน:"
        '
        'UsernameLabel
        '
        Me.UsernameLabel.AutoSize = True
        Me.UsernameLabel.Location = New System.Drawing.Point(221, 24)
        Me.UsernameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(55, 20)
        Me.UsernameLabel.TabIndex = 20
        Me.UsernameLabel.Text = "ชื่อผู้ใช้:"
        '
        'TestListTabPage
        '
        Me.TestListTabPage.Controls.Add(Me.TestListTreeView)
        Me.TestListTabPage.Location = New System.Drawing.Point(4, 29)
        Me.TestListTabPage.Name = "TestListTabPage"
        Me.TestListTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.TestListTabPage.Size = New System.Drawing.Size(652, 367)
        Me.TestListTabPage.TabIndex = 1
        Me.TestListTabPage.Text = "ข้อสอบที่สร้าง"
        Me.TestListTabPage.UseVisualStyleBackColor = True
        '
        'TestListTreeView
        '
        Me.TestListTreeView.Location = New System.Drawing.Point(6, 6)
        Me.TestListTreeView.Name = "TestListTreeView"
        Me.TestListTreeView.Size = New System.Drawing.Size(640, 355)
        Me.TestListTreeView.TabIndex = 0
        '
        'TestScoreTabPage
        '
        Me.TestScoreTabPage.Controls.Add(Me.TestScoreTreeView)
        Me.TestScoreTabPage.Location = New System.Drawing.Point(4, 29)
        Me.TestScoreTabPage.Name = "TestScoreTabPage"
        Me.TestScoreTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.TestScoreTabPage.Size = New System.Drawing.Size(652, 367)
        Me.TestScoreTabPage.TabIndex = 2
        Me.TestScoreTabPage.Text = "ข้อสอบที่เคยทำ"
        Me.TestScoreTabPage.UseVisualStyleBackColor = True
        '
        'TestScoreTreeView
        '
        Me.TestScoreTreeView.Location = New System.Drawing.Point(6, 6)
        Me.TestScoreTreeView.Name = "TestScoreTreeView"
        Me.TestScoreTreeView.Size = New System.Drawing.Size(640, 355)
        Me.TestScoreTreeView.TabIndex = 1
        '
        'ProfileForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.ClientSize = New System.Drawing.Size(684, 461)
        Me.Controls.Add(Me.TabControl)
        Me.Name = "ProfileForm"
        Me.Text = "ข้อมูลส่วนตัว - MyExam"
        Me.Controls.SetChildIndex(Me.TabControl, 0)
        Me.TabControl.ResumeLayout(False)
        Me.ProfileTabPage.ResumeLayout(False)
        Me.ProfileTabPage.PerformLayout()
        Me.TestListTabPage.ResumeLayout(False)
        Me.TestScoreTabPage.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl As TabControl
    Friend WithEvents ProfileTabPage As TabPage
    Friend WithEvents TestListTabPage As TabPage
    Friend WithEvents TestScoreTabPage As TabPage
    Friend WithEvents TestListTreeView As TreeView
    Friend WithEvents TestScoreTreeView As TreeView
    Friend WithEvents ErrorAnswerLabel As Label
    Friend WithEvents ErrorQuestionLabel As Label
    Friend WithEvents ErrorEmailLabel As Label
    Friend WithEvents ErrorPasswordLabel As Label
    Friend WithEvents AnswerTextBox As TextBox
    Friend WithEvents QuestionTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents AnswerLabel As Label
    Friend WithEvents QuestionLabel As Label
    Friend WithEvents EmailLabel As Label
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents UsernameLabel As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ConfirmEditTextBox As TextBox
    Friend WithEvents ConfirmEditLabel As Label
    Friend WithEvents ErrorConfirmChangePasswordLabel As Label
    Friend WithEvents ChangePasswordConfirmTextBox As TextBox
    Friend WithEvents ChangePasswordConfirmLabel As Label
    Friend WithEvents ErrorChangePasswordLabel As Label
    Friend WithEvents ChangePasswordTextBox As TextBox
    Friend WithEvents ChangePasswordLabel As Label
    Friend WithEvents EditButton As Button
End Class
