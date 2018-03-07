<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSemesterGrades
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
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblCourse1 = New System.Windows.Forms.Label()
        Me.lblCourse4 = New System.Windows.Forms.Label()
        Me.lblCourse3 = New System.Windows.Forms.Label()
        Me.lblCourse2 = New System.Windows.Forms.Label()
        Me.lblCourse5 = New System.Windows.Forms.Label()
        Me.lblCourse6 = New System.Windows.Forms.Label()
        Me.lblSemester = New System.Windows.Forms.Label()
        Me.lblCourse1GradeLetter = New System.Windows.Forms.Label()
        Me.lblCourse2GradeLetter = New System.Windows.Forms.Label()
        Me.lblCourse3GradeLetter = New System.Windows.Forms.Label()
        Me.lblCourse4GradeLetter = New System.Windows.Forms.Label()
        Me.lblCourse5GradeLetter = New System.Windows.Forms.Label()
        Me.lblCourse6GradeLetter = New System.Windows.Forms.Label()
        Me.lblAverageGradeLetter = New System.Windows.Forms.Label()
        Me.txtCourse1Grade = New System.Windows.Forms.TextBox()
        Me.txtCourse4Grade = New System.Windows.Forms.TextBox()
        Me.txtCourse3Grade = New System.Windows.Forms.TextBox()
        Me.txtCourse2Grade = New System.Windows.Forms.TextBox()
        Me.txtCourse5Grade = New System.Windows.Forms.TextBox()
        Me.txtCourse6Grade = New System.Windows.Forms.TextBox()
        Me.lblOutputErrors = New System.Windows.Forms.Label()
        Me.lblSemesterAverageGrade = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.AccessibleName = "btnCalculate"
        Me.btnCalculate.Location = New System.Drawing.Point(30, 365)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 0
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.AccessibleName = "btnReset"
        Me.btnReset.Location = New System.Drawing.Point(111, 365)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 1
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.AccessibleName = "btnExit"
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(197, 365)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblCourse1
        '
        Me.lblCourse1.AccessibleName = "lblCourse1"
        Me.lblCourse1.AutoSize = True
        Me.lblCourse1.Location = New System.Drawing.Point(27, 18)
        Me.lblCourse1.Name = "lblCourse1"
        Me.lblCourse1.Size = New System.Drawing.Size(52, 13)
        Me.lblCourse1.TabIndex = 3
        Me.lblCourse1.Text = "Course 1:"
        '
        'lblCourse4
        '
        Me.lblCourse4.AccessibleName = "lblCourse4"
        Me.lblCourse4.AutoSize = True
        Me.lblCourse4.Location = New System.Drawing.Point(27, 99)
        Me.lblCourse4.Name = "lblCourse4"
        Me.lblCourse4.Size = New System.Drawing.Size(52, 13)
        Me.lblCourse4.TabIndex = 4
        Me.lblCourse4.Text = "Course 4:"
        '
        'lblCourse3
        '
        Me.lblCourse3.AccessibleName = "lblCourse3"
        Me.lblCourse3.AutoSize = True
        Me.lblCourse3.Location = New System.Drawing.Point(27, 72)
        Me.lblCourse3.Name = "lblCourse3"
        Me.lblCourse3.Size = New System.Drawing.Size(52, 13)
        Me.lblCourse3.TabIndex = 5
        Me.lblCourse3.Text = "Course 3:"
        '
        'lblCourse2
        '
        Me.lblCourse2.AccessibleName = "lblCourse2"
        Me.lblCourse2.AutoSize = True
        Me.lblCourse2.Location = New System.Drawing.Point(27, 45)
        Me.lblCourse2.Name = "lblCourse2"
        Me.lblCourse2.Size = New System.Drawing.Size(52, 13)
        Me.lblCourse2.TabIndex = 6
        Me.lblCourse2.Text = "Course 2:"
        '
        'lblCourse5
        '
        Me.lblCourse5.AccessibleName = "lblCourse5"
        Me.lblCourse5.AutoSize = True
        Me.lblCourse5.Location = New System.Drawing.Point(27, 125)
        Me.lblCourse5.Name = "lblCourse5"
        Me.lblCourse5.Size = New System.Drawing.Size(52, 13)
        Me.lblCourse5.TabIndex = 7
        Me.lblCourse5.Text = "Course 5:"
        '
        'lblCourse6
        '
        Me.lblCourse6.AccessibleName = "lblCourse6"
        Me.lblCourse6.AutoSize = True
        Me.lblCourse6.Location = New System.Drawing.Point(27, 151)
        Me.lblCourse6.Name = "lblCourse6"
        Me.lblCourse6.Size = New System.Drawing.Size(52, 13)
        Me.lblCourse6.TabIndex = 8
        Me.lblCourse6.Text = "Course 6:"
        '
        'lblSemester
        '
        Me.lblSemester.AccessibleName = "lblSemester"
        Me.lblSemester.AutoSize = True
        Me.lblSemester.Location = New System.Drawing.Point(27, 175)
        Me.lblSemester.Name = "lblSemester"
        Me.lblSemester.Size = New System.Drawing.Size(54, 13)
        Me.lblSemester.TabIndex = 9
        Me.lblSemester.Text = "Semester:"
        '
        'lblCourse1GradeLetter
        '
        Me.lblCourse1GradeLetter.AccessibleName = "lblCourse1GradeLetter"
        Me.lblCourse1GradeLetter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCourse1GradeLetter.Location = New System.Drawing.Point(184, 15)
        Me.lblCourse1GradeLetter.Name = "lblCourse1GradeLetter"
        Me.lblCourse1GradeLetter.Size = New System.Drawing.Size(90, 20)
        Me.lblCourse1GradeLetter.TabIndex = 10
        '
        'lblCourse2GradeLetter
        '
        Me.lblCourse2GradeLetter.AccessibleName = "lblCourse2GradeLetter"
        Me.lblCourse2GradeLetter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCourse2GradeLetter.Location = New System.Drawing.Point(184, 42)
        Me.lblCourse2GradeLetter.Name = "lblCourse2GradeLetter"
        Me.lblCourse2GradeLetter.Size = New System.Drawing.Size(90, 20)
        Me.lblCourse2GradeLetter.TabIndex = 11
        '
        'lblCourse3GradeLetter
        '
        Me.lblCourse3GradeLetter.AccessibleName = "lblCourse3GradeLetter"
        Me.lblCourse3GradeLetter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCourse3GradeLetter.Location = New System.Drawing.Point(184, 69)
        Me.lblCourse3GradeLetter.Name = "lblCourse3GradeLetter"
        Me.lblCourse3GradeLetter.Size = New System.Drawing.Size(90, 20)
        Me.lblCourse3GradeLetter.TabIndex = 12
        '
        'lblCourse4GradeLetter
        '
        Me.lblCourse4GradeLetter.AccessibleName = "lblCourse4GradeLetter"
        Me.lblCourse4GradeLetter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCourse4GradeLetter.Location = New System.Drawing.Point(184, 96)
        Me.lblCourse4GradeLetter.Name = "lblCourse4GradeLetter"
        Me.lblCourse4GradeLetter.Size = New System.Drawing.Size(90, 20)
        Me.lblCourse4GradeLetter.TabIndex = 13
        '
        'lblCourse5GradeLetter
        '
        Me.lblCourse5GradeLetter.AccessibleName = "lblCourse5GradeLetter"
        Me.lblCourse5GradeLetter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCourse5GradeLetter.Location = New System.Drawing.Point(184, 121)
        Me.lblCourse5GradeLetter.Name = "lblCourse5GradeLetter"
        Me.lblCourse5GradeLetter.Size = New System.Drawing.Size(90, 20)
        Me.lblCourse5GradeLetter.TabIndex = 14
        '
        'lblCourse6GradeLetter
        '
        Me.lblCourse6GradeLetter.AccessibleName = "lblCourse6GradeLetter"
        Me.lblCourse6GradeLetter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCourse6GradeLetter.Location = New System.Drawing.Point(184, 148)
        Me.lblCourse6GradeLetter.Name = "lblCourse6GradeLetter"
        Me.lblCourse6GradeLetter.Size = New System.Drawing.Size(90, 20)
        Me.lblCourse6GradeLetter.TabIndex = 15
        '
        'lblAverageGradeLetter
        '
        Me.lblAverageGradeLetter.AccessibleName = "lblAverageGradeLetter"
        Me.lblAverageGradeLetter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverageGradeLetter.Location = New System.Drawing.Point(184, 174)
        Me.lblAverageGradeLetter.Name = "lblAverageGradeLetter"
        Me.lblAverageGradeLetter.Size = New System.Drawing.Size(90, 20)
        Me.lblAverageGradeLetter.TabIndex = 16
        '
        'txtCourse1Grade
        '
        Me.txtCourse1Grade.AccessibleName = "txtCourse1Grade"
        Me.txtCourse1Grade.Location = New System.Drawing.Point(88, 15)
        Me.txtCourse1Grade.Name = "txtCourse1Grade"
        Me.txtCourse1Grade.Size = New System.Drawing.Size(90, 20)
        Me.txtCourse1Grade.TabIndex = 17
        '
        'txtCourse4Grade
        '
        Me.txtCourse4Grade.AccessibleName = "txtCourse4Grade"
        Me.txtCourse4Grade.Location = New System.Drawing.Point(88, 96)
        Me.txtCourse4Grade.Name = "txtCourse4Grade"
        Me.txtCourse4Grade.Size = New System.Drawing.Size(90, 20)
        Me.txtCourse4Grade.TabIndex = 18
        '
        'txtCourse3Grade
        '
        Me.txtCourse3Grade.AccessibleName = "txtCourse3Grade"
        Me.txtCourse3Grade.Location = New System.Drawing.Point(88, 69)
        Me.txtCourse3Grade.Name = "txtCourse3Grade"
        Me.txtCourse3Grade.Size = New System.Drawing.Size(90, 20)
        Me.txtCourse3Grade.TabIndex = 19
        '
        'txtCourse2Grade
        '
        Me.txtCourse2Grade.AccessibleName = "txtCourse2Grade"
        Me.txtCourse2Grade.Location = New System.Drawing.Point(88, 42)
        Me.txtCourse2Grade.Name = "txtCourse2Grade"
        Me.txtCourse2Grade.Size = New System.Drawing.Size(90, 20)
        Me.txtCourse2Grade.TabIndex = 20
        '
        'txtCourse5Grade
        '
        Me.txtCourse5Grade.AccessibleName = "txtCourse5Grade"
        Me.txtCourse5Grade.Location = New System.Drawing.Point(88, 122)
        Me.txtCourse5Grade.Name = "txtCourse5Grade"
        Me.txtCourse5Grade.Size = New System.Drawing.Size(90, 20)
        Me.txtCourse5Grade.TabIndex = 21
        '
        'txtCourse6Grade
        '
        Me.txtCourse6Grade.AccessibleName = "txtCourse6Grade"
        Me.txtCourse6Grade.Location = New System.Drawing.Point(88, 148)
        Me.txtCourse6Grade.Name = "txtCourse6Grade"
        Me.txtCourse6Grade.Size = New System.Drawing.Size(90, 20)
        Me.txtCourse6Grade.TabIndex = 22
        '
        'lblOutputErrors
        '
        Me.lblOutputErrors.AccessibleName = "lblOutputErrors"
        Me.lblOutputErrors.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutputErrors.Location = New System.Drawing.Point(30, 209)
        Me.lblOutputErrors.Name = "lblOutputErrors"
        Me.lblOutputErrors.Size = New System.Drawing.Size(242, 153)
        Me.lblOutputErrors.TabIndex = 23
        '
        'lblSemesterAverageGrade
        '
        Me.lblSemesterAverageGrade.AccessibleName = "lblSemesterAverageGrade"
        Me.lblSemesterAverageGrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSemesterAverageGrade.Location = New System.Drawing.Point(88, 174)
        Me.lblSemesterAverageGrade.Name = "lblSemesterAverageGrade"
        Me.lblSemesterAverageGrade.Size = New System.Drawing.Size(90, 20)
        Me.lblSemesterAverageGrade.TabIndex = 24
        '
        'frmSemesterGrades
        '
        Me.AccessibleName = "frmSemesterGrades"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(285, 400)
        Me.Controls.Add(Me.lblSemesterAverageGrade)
        Me.Controls.Add(Me.lblOutputErrors)
        Me.Controls.Add(Me.txtCourse6Grade)
        Me.Controls.Add(Me.txtCourse5Grade)
        Me.Controls.Add(Me.txtCourse2Grade)
        Me.Controls.Add(Me.txtCourse3Grade)
        Me.Controls.Add(Me.txtCourse4Grade)
        Me.Controls.Add(Me.txtCourse1Grade)
        Me.Controls.Add(Me.lblAverageGradeLetter)
        Me.Controls.Add(Me.lblCourse6GradeLetter)
        Me.Controls.Add(Me.lblCourse5GradeLetter)
        Me.Controls.Add(Me.lblCourse4GradeLetter)
        Me.Controls.Add(Me.lblCourse3GradeLetter)
        Me.Controls.Add(Me.lblCourse2GradeLetter)
        Me.Controls.Add(Me.lblCourse1GradeLetter)
        Me.Controls.Add(Me.lblSemester)
        Me.Controls.Add(Me.lblCourse6)
        Me.Controls.Add(Me.lblCourse5)
        Me.Controls.Add(Me.lblCourse2)
        Me.Controls.Add(Me.lblCourse3)
        Me.Controls.Add(Me.lblCourse4)
        Me.Controls.Add(Me.lblCourse1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalculate)
        Me.MaximumSize = New System.Drawing.Size(301, 439)
        Me.MinimumSize = New System.Drawing.Size(301, 439)
        Me.Name = "frmSemesterGrades"
        Me.Text = "Semester Grades"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblCourse1 As Label
    Friend WithEvents lblCourse4 As Label
    Friend WithEvents lblCourse3 As Label
    Friend WithEvents lblCourse2 As Label
    Friend WithEvents lblCourse5 As Label
    Friend WithEvents lblCourse6 As Label
    Friend WithEvents lblSemester As Label
    Friend WithEvents lblCourse1GradeLetter As Label
    Friend WithEvents lblCourse2GradeLetter As Label
    Friend WithEvents lblCourse3GradeLetter As Label
    Friend WithEvents lblCourse4GradeLetter As Label
    Friend WithEvents lblCourse5GradeLetter As Label
    Friend WithEvents lblCourse6GradeLetter As Label
    Friend WithEvents lblAverageGradeLetter As Label
    Friend WithEvents txtCourse1Grade As TextBox
    Friend WithEvents txtCourse4Grade As TextBox
    Friend WithEvents txtCourse3Grade As TextBox
    Friend WithEvents txtCourse2Grade As TextBox
    Friend WithEvents txtCourse5Grade As TextBox
    Friend WithEvents txtCourse6Grade As TextBox
    Friend WithEvents lblOutputErrors As Label
    Friend WithEvents lblSemesterAverageGrade As Label
End Class
