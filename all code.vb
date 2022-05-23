Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ValidateInput(TextBox1.Text, "String") Then
            '...
        End If
    End Sub
    Public Function ValidateInput(input, type) 'type can either be string or integer 
        Dim check = 1, check2 = 1
        If input = "" Then
            MessageBox.Show("Empty input")
            check = 0 'check variable = false if the input is null
        End If
        If type = "String" Then
            If IsNumeric(input) Then
                MessageBox.Show("Incorrect input type")
                check = 0 'check2 variable = false if the input is a string 
            End If
        ElseIf type = "Integer" Then
            If Not IsNumeric(input) Then
                MessageBox.Show("Incorrect input type")
                check = 0 'check2 variable = false if the input is an integer 
            End If
        End If
        If check And check2 Then 'returns true if both check variables are true, otherwise false
            Return True
        Else
            Return False
        End If
    End Function
End Class


Public Class Form1
	Private Sub btncalculate_Click(sender As Object, e As EventArgs) Handles btncalculate.Click
		Dim h As Integer = Val(txtheightinput.Text), w As Integer = Val(txtweightinput.Text), bmi
		bmi = Math.Round((w / (h ^ 2)) * 10000, 2) 'calculate bmi
		lbloutput.Text = bmi
		Bmiclass(bmi, lblresult) 'inputing bmi to find weightclass
	End Sub
	Private Function Bmiclass(bmi, textbox) As Integer
		Select Case bmi
			Case 0.0 To 18.5
				textbox.Text = "Underweight"
			Case 18.6 To 24.9
				textbox.Text = "Normal Weight"
			Case 25.0 To 29.9
				textbox.Text = "Overweight"
			Case 30 To 34.9
				textbox.Text = "Obese class I"
			Case 35.0 To 39.9
				textbox.Text = "Obese class II"
			Case Is >= 40
				textbox.Text = "Fatass"
			Case Else
				textbox.Text = "Unable to Determin BMI"
		End Select
	End Function
End Class


Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLargest.Click
        Dim arr = {txtInput1.Text, txtInput2.Text, txtInput3.Text} 'transfer raw textbox inputs into array 
        For Each item In arr 'loop array 
            If Not IsNumeric(item) Then
                MessageBox.Show("incorrect input type - ensure that all textboxes are filled with nummbers")
                'check if each array element is numeric; if not asks for correct input type 
                Return
            End If
        Next
        Array.Sort(arr) 'sort array 
        MessageBox.Show("largest value is " & arr(arr.Length - 1)) 'print the largest array element 
    End Sub
End Class


Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim testString As String = "apple    pear banana  "
        Dim testArray() As String = Split(testString)
        ' testArray holds {"apple", "", "", "", "pear", "banana", "", ""}
        Dim lastNonEmpty As Integer = -1
        For i As Integer = 0 To testArray.Length - 1
            If testArray(i) <> "" Then
                lastNonEmpty += 1
                testArray(lastNonEmpty) = testArray(i)
            End If
        Next
        ReDim Preserve testArray(lastNonEmpty)
        ' testArray now holds {"apple", "pear", "banana"}
        Dim a As String = ""
        For Each i In testArray
            a += i
        Next
        MessageBox.Show(a)
    End Sub
End Class


Public Class Form1
    Dim count As Integer = 0, limit As Integer = 20
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 100
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        count += 1
        Label1.Text = count
        If count = limit Then Timer1.Stop()
    End Sub
End Class


Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim testString As String = "apple    pear banana  "
        Dim testArray() As String = Split(testString)
        ' testArray holds {"apple", "", "", "", "pear", "banana", "", ""}
        Dim lastNonEmpty As Integer = -1
        For i As Integer = 0 To testArray.Length - 1
            If testArray(i) <> "" Then
                lastNonEmpty += 1
                testArray(lastNonEmpty) = testArray(i)
            End If
        Next
        ReDim Preserve testArray(lastNonEmpty)
        ' testArray now holds {"apple", "pear", "banana"}
        Dim a As String = ""
        'For i = 0 To testArray.Length
        '    a += testArray(i)
        '    i += 1
        'Next
        For Each i In testArray
            a += i

        Next
        MessageBox.Show(a)

    End Sub
End Class


Public Class Form1
    Dim number As Integer
    Dim number2 As Integer
    Dim total As Integer
    ReadOnly operators = {"Plus", "Minus", "Times", "Divide"}
    Dim lastOp = ""
    Dim init = False
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnOne.Click
        txtNum.Text &= btnOne.Text
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnTwo.Click
        txtNum.Text &= btnTwo.Text
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnThree.Click
        txtNum.Text &= btnThree.Text
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnFour.Click
        txtNum.Text &= btnFour.Text
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnFive.Click
        txtNum.Text &= btnFive.Text
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnSix.Click
        txtNum.Text &= btnSix.Text
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btnSeven.Click
        txtNum.Text &= btnSeven.Text
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles btnEight.Click
        txtNum.Text &= btnEight.Text
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles btnNine.Click
        txtNum.Text &= btnNine.Text
    End Sub
    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        number2 += Val(txtNum.Text)
        txtNum.Text = ""
        lastOp = "Plus"
    End Sub
    Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click
        number2 += Val(txtNum.Text)
        txtNum.Text = ""
        lastOp = "Minus"
    End Sub
    Private Sub btnTimes_Click(sender As Object, e As EventArgs) Handles btnTimes.Click
        number2 += Val(txtNum.Text)
        txtNum.Text = ""
        lastOp = "Times"
    End Sub
    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        number2 += Val(txtNum.Text)
        txtNum.Text = ""
        lastOp = "Divide"
    End Sub
    Private Sub btnEqual_Click(sender As Object, e As EventArgs) Handles btnEqual.Click
        Select Case lastOp
            Case "Plus"
                txtNum.Text = number2 + Val(txtNum.Text)
            Case "Minus"
                txtNum.Text = number2 - Val(txtNum.Text)
            Case "Times"
                txtNum.Text = number2 * Val(txtNum.Text)
            Case "Divide"
                txtNum.Text = number2 / Val(txtNum.Text)
        End Select
        init = True
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        number2 = 0
        txtNum.Clear()
    End Sub
End Class


Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call B()
    End Sub
    Private Sub B()
        Dim a As String = TextBox1.Text.Trim()
        If a = "" Then MessageBox.Show("input name")
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call AddNumbers(txtFirstNumber.Text, txtSecondNumber.Text)
    End Sub
    Private Sub AddNumbers(first, second)
        Dim answer As Integer = Val(first) + Val(second)
        MessageBox.Show("The total is " & answer)
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim isError As Boolean = check()
        If isError Then Exit Sub Else MessageBox.Show("iserror = false")
    End Sub
    Private Function Check() As Boolean
        Dim data As String = TextBox2.Text.Trim()
        If data = "" Then
            MessageBox.Show("blank")
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim result As Integer = Total(Val(TextBox3.Text), Val(TextBox4.Text))
        If result Then
            MessageBox.Show(result)
        Else
            MessageBox.Show("no")
        End If
    End Sub
    Private Function Total(first, second) As Integer
        Dim answer As Integer = first + second
        Return answer
    End Function
End Class

