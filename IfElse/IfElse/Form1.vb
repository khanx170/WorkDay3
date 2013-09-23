Option Strict On

Public Class Form1

    Private Sub btnFindLarger_Click(sender As System.Object, e As System.EventArgs) Handles btnFindLarger.Click
        Dim num1, num2 As Double



        'the only way to crash is put hello in first or second box and some numeric value to crash it because it will make one box true and second false
        'if only he splits the above line before "handles"

        'if the user did the right thing 
        'if the user did the wrong thing, then msgbox and eliminate them
        'If (IsNumeric(txtFirstNum.Text) And IsNumeric(txtSecondNum.Text)) Then
        If Not (IsNumeric(txtFirstNum.Text) And IsNumeric(txtSecondNum.Text)) Then
            MessageBox.Show("Error: please type a number!", "Error")
            Return
        End If

        num1 = CDbl(txtFirstNum.Text)
        num2 = CDbl(txtSecondNum.Text)

        'if the user did the worng thing, then msg box and eliminate them 
        If (num1 < 0 Or num2 < 0) Then
            MessageBox.Show("Error: please type a number!", "Error")
            Return
        End If


        'then do the computation
        'num1 = CDbl(txtFirstNum.Text)
        'num2 = CDbl(txtSecondNum.Text)


        'sterile area 
        If (num1 > num2) Then
            'largernum = num1
            txtResult.Text = "larger number is " & num1

        ElseIf (num2 > num1) Then
            txtResult.Text = "large number is " & num2
        Else
            txtResult.Text = "the two are equal. "
            'largernum = num2
            'End If

            'else
            'MessageBox.Show("Error: please type a number!", "Error")
        End If

        'txtResult.Text = "the larger number is " & largernum


    End Sub

    Private Sub txtFirstNum_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFirstNum.TextChanged

    End Sub
End Class
