

''' <summary>
''' Author: Nicholas Lindsay
''' Project Name: Lab 2 - SemesterAverage
''' Date: 21 Feb 2018
''' Description: Application that calculates the average mark of six courses in a single semester.
''' </summary>



Public Class frmSemesterGrades

    'Variables

    Const minimumGradeValue As Integer = 0       'Constant validates so that the input grade is not below 0
    Const maximumGradeValue As Integer = 100     'Constant validates so that the input grade is not above 100
    Dim maxGrades As Integer = 6                 'This variable is the max amount of grades enter for courses in a single semester
    Dim inputGrade1 As Double = 0.0              'Double for Course1 grade
    Dim inputGrade2 As Double = 0.0              'Double for Course2 grade
    Dim inputGrade3 As Double = 0.0              'Double for Course3 grade
    Dim inputGrade4 As Double = 0.0              'Double for Course4 grade
    Dim inputGrade5 As Double = 0.0              'Double for Course5 grade
    Dim inputGrade6 As Double = 0.0              'Double for Course6 grade
    Dim gradeAverage As Double = 0.0             'Variable that holds grade average as Double

    Private Function inputNumbers(inputGrade1 As Double, inputGrade2 As Double, inputGrade3 As Double, inputGrade4 As Double, inputGrade5 As Double, inputGrade6 As Double) As Double
        'Modifier/ Function/ Function name/(Parameters)/The Return Data Type
    End Function

    ''' <summary>
    ''' If the course grade falls in between the ranges, it will display a letter value
    ''' </summary>
    ''' <param name="inputNumbers"></param>
    ''' <returns></returns>
    Private Function Criteria(inputNumbers As String) As String
        'Modifier/Function/Function name(Parameters)/Data Type


        Dim letterGrade As String

        If inputNumbers >= 90 And inputNumbers <= 100 Then       'If input number falls in between 90 to 100. Display letter "A+"
            letterGrade = "A+"
        ElseIf inputNumbers >= 85 And inputNumbers <= 89 Then    'If input number falls in between 85 to 89. Display letter "A"
            letterGrade = "A"
        ElseIf inputNumbers >= 80 And inputNumbers <= 84 Then    'If input number falls in between 80 to 84. Display letter "A-"
            letterGrade = "A-"
        ElseIf inputNumbers >= 77 And inputNumbers <= 79 Then    'If input number falls in between 77 to 79. Display letter "B+"
            letterGrade = "B+"
        ElseIf inputNumbers >= 73 And inputNumbers <= 76 Then    'If input number falls in between 73 to 76. Display letter "B"
            letterGrade = "B"
        ElseIf inputNumbers >= 70 And inputNumbers <= 72 Then    'If input number falls in between 70 to 72. Display letter "B-"
            letterGrade = "B-"
        ElseIf inputNumbers >= 67 And inputNumbers <= 69 Then    'If input number falls in between 67 to 69. Display letter "C+"
            letterGrade = "C+"
        ElseIf inputNumbers >= 63 And inputNumbers <= 66 Then    'If input number falls in between 63 to 66. Display letter "C"
            letterGrade = "C"
        ElseIf inputNumbers >= 60 And inputNumbers <= 62 Then    'If input number falls in between 60 to 62. Display letter "C-"
            letterGrade = "C-"
        ElseIf inputNumbers >= 57 And inputNumbers <= 59 Then    'If input number falls in between 57 to 59. Display letter "D+"
            letterGrade = "D+"
        ElseIf inputNumbers >= 53 And inputNumbers <= 56 Then    'If input number falls in between 53 to 56. Display letter "D"
            letterGrade = "D"
        ElseIf inputNumbers >= 50 And inputNumbers <= 52 Then    'If input number falls in between 50 to 52. Display letter "D-"
            letterGrade = "D-"
        ElseIf inputNumbers >= 0 And inputNumbers <= 49 Then     'If input number falls in between 0 to 49. Display letter "F"
            letterGrade = "F"
        End If

        Return letterGrade

    End Function
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
    Private Sub btnCalculate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCalculate.Click

        Dim maxGrades As Integer = 6             'The max grades that can be inputed
        Dim inputGrade1 As Double = 0.0          'Double variable for inputGrade 1
        Dim inputGrade2 As Double = 0.0          'Double variable for inputGrade 2
        Dim inputGrade3 As Double = 0.0          'Double variable for inputGrade 3
        Dim inputGrade4 As Double = 0.0          'Double varaible for inputGrade 4
        Dim inputGrade5 As Double = 0.0          'Double variable for inputGrade 5
        Dim inputGrade6 As Double = 0.0          'Double varaible for inputGrade 6
        Dim gradeAverage As Double = 0.0         'Double for gradeAverage

        'Get the values inputed by the user
        inputGrade1 = Val(txtCourse1Grade.Text)
        inputGrade2 = Val(txtCourse2Grade.Text)
        inputGrade3 = Val(txtCourse3Grade.Text)
        inputGrade4 = Val(txtCourse4Grade.Text)
        inputGrade5 = Val(txtCourse5Grade.Text)
        inputGrade6 = Val(txtCourse6Grade.Text)

        gradeAverage = (inputGrade1 + inputGrade2 + inputGrade3 + inputGrade4 + inputGrade5 + inputGrade6) / maxGrades

        lblSemesterAverageGrade.Text = gradeAverage
    End Sub
    Private Sub txtCourse1Grade_LostFocus(ByVal sender As Object, e As EventArgs) Handles txtCourse1Grade.LostFocus

        Dim inputGrade1 As Double = 0.0

        inputGrade1 = Val(txtCourse1Grade.Text)

        lblCourse1GradeLetter.Text = Criteria(inputGrade1)
    End Sub

    Private Sub txtCourse2Grade_LostFocus(ByVal sender As Object, e As EventArgs) Handles txtCourse2Grade.LostFocus

        Dim inputGrade2 As Double = 0.0

        inputGrade2 = Val(txtCourse2Grade.Text)

        lblCourse2GradeLetter.Text = Criteria(inputGrade2)
    End Sub

    Private Sub txtCourse3Grade_LostFocus(ByVal sender As Object, e As EventArgs) Handles txtCourse3Grade.LostFocus

        Dim inputGrade3 As Double = 0.0

        inputGrade3 = Val(txtCourse3Grade.Text)

        lblCourse3GradeLetter.Text = Criteria(inputGrade3)
    End Sub

    Private Sub txtCourse4Grade_LostFocus(ByVal sender As Object, e As EventArgs) Handles txtCourse4Grade.LostFocus

        Dim inputGrade4 As Double = 0.0

        inputGrade4 = Val(txtCourse4Grade.Text)

        lblCourse4GradeLetter.Text = Criteria(inputGrade4)
    End Sub

    Private Sub txtCourse5Grade_LostFocus(ByVal sender As Object, e As EventArgs) Handles txtCourse5Grade.LostFocus

        Dim inputGrade5 As Double = 0.0

        inputGrade5 = Val(txtCourse5Grade.Text)

        lblCourse5GradeLetter.Text = Criteria(inputGrade5)
    End Sub

    Private Sub txtCourse6Grade_LostFocus(ByVal sender As Object, e As EventArgs) Handles txtCourse6Grade.LostFocus

        Dim inputGrade5 As Double = 0.0

        inputGrade5 = Val(txtCourse5Grade.Text)

        lblCourse5GradeLetter.Text = Criteria(inputGrade6)
    End Sub

    Private Sub btnReset_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnReset.Click

        txtCourse1Grade.Text = String.Empty   'Empty's text box
        txtCourse2Grade.Text = String.Empty   'Empty's text box
        txtCourse3Grade.Text = String.Empty   'Empty's text box
        txtCourse4Grade.Text = String.Empty   'Empty's text box
        txtCourse5Grade.Text = String.Empty   'Empty's text box
        txtCourse6Grade.Text = String.Empty   'Empty's text box


        lblCourse1GradeLetter.Text = String.Empty  'Empty's grade letter box
        lblCourse2GradeLetter.Text = String.Empty  'Empty's grade letter box
        lblCourse3GradeLetter.Text = String.Empty  'Empty's grade letter box
        lblCourse4GradeLetter.Text = String.Empty  'Empty's grade letter box
        lblCourse5GradeLetter.Text = String.Empty  'Empty;s grade letter box
        lblCourse6GradeLetter.Text = String.Empty  'Empty's grade letter box

        lblSemesterAverageGrade.Text = String.Empty ' Empty's Average
        gradeAverage = 0


    End Sub
End Class
