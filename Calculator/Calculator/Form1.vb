Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private isAdding As Boolean = False
    Private isSubtracting As Boolean = False
    Private isDividing As Boolean = False
    Private isMultipuling As Boolean = False
    Private isModulus As Boolean = False

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtNum1.Text.Length <> 0 And txtNum2.Text.Length <> 0 And isAdding = False Then
            Dim answer As Double = add(CType(txtNum1.Text, Double), CType(txtNum2.Text, Double))
            txtAnswer.Text = answer.ToString()
            txtNum2.ReadOnly = True

            isAdding = True
        ElseIf isAdding Then
            Dim ans As Double = add(CType(txtNum1.Text, Double), CType(txtNum2.Text, Double))
            txtAnswer.Text = ans.ToString()
        Else
            MsgBox("Error, Please Fill All Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub btnSubtract_Click(sender As Object, e As EventArgs) Handles btnSubtract.Click
        If txtNum1.Text.Length <> 0 And txtNum2.Text.Length <> 0 And issubtracting = False Then
            Dim answer As Double = subtract(CType(txtNum1.Text, Double), CType(txtNum2.Text, Double))
            txtAnswer.Text = answer.ToString()
            txtNum1.ReadOnly = True
            txtNum1 = txtAnswer
            issubtracting = True
        ElseIf isSubtracting Then
            Dim ans As Double = subtract(CType(txtNum1.Text, Double), CType(txtNum2.Text, Double))
            txtAnswer.Text = ans.ToString()
        Else
            MsgBox("Error, Please Fill All Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        If txtNum1.Text.Length <> 0 And txtNum2.Text.Length <> 0 And isDividing = False Then
            Dim answer As Double = divide(CType(txtNum1.Text, Double), CType(txtNum2.Text, Double))
            txtAnswer.Text = answer.ToString()
            txtNum2.ReadOnly = True
            txtNum2 = txtAnswer
            isDividing = True
        ElseIf isDividing Then
            Dim ans As Double = divide(CType(txtNum1.Text, Double), CType(txtNum2.Text, Double))
            txtAnswer.Text = ans.ToString()
        Else
            MsgBox("Error, Please Fill All Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnMultipul_Click(sender As Object, e As EventArgs) Handles btnMultipul.Click
        If txtNum1.Text.Length <> 0 And txtNum2.Text.Length <> 0 And isMultipuling = False Then
            Dim answer As Double = multipul(CType(txtNum1.Text, Double), CType(txtNum2.Text, Double))
            txtAnswer.Text = answer.ToString()
            txtNum2.ReadOnly = True
            txtNum1 = txtAnswer
            isMultipuling = True
        ElseIf isMultipuling Then
            Dim ans As Double = multipul(CType(txtNum1.Text, Double), CType(txtNum2.Text, Double))
            txtAnswer.Text = ans.ToString()
        Else
            MsgBox("Error, Please Fill All Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnModulus_Click(sender As Object, e As EventArgs) Handles btnModulus.Click
        If txtNum1.Text.Length <> 0 And txtNum2.Text.Length <> 0 And isModulus = False Then
            Dim answer As Double = modulus(CType(txtNum1.Text, Double), CType(txtNum2.Text, Double))
            txtAnswer.Text = answer.ToString()
            txtNum2.ReadOnly = True
            txtNum2 = txtAnswer
            isModulus = True
        ElseIf ismodulus Then
            Dim ans As Double = modulus(CType(txtNum1.Text, Double), CType(txtNum2.Text, Double))
            txtAnswer.Text = ans.ToString()
        Else
            MsgBox("Error, Please Fill All Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnPi_Click(sender As Object, e As EventArgs) Handles btnPi.Click
        If txtNum1.Text.Length <> 0 Then
            Dim answer As Double = Pi(CType(txtNum1.Text, Double))
            txtAnswer.Text = String.Format("{0:n3}", answer)
            txtNum2.Text = String.Format("{0:n3}", Math.PI)
            txtNum2.ReadOnly = True
        Else
            MsgBox("Error, Please Fill All Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Dim answer As Double
    Private Function add(ByVal num1 As Double, ByVal num2 As Double) As Double
        Return num1 + num2
    End Function

    Private Function subtract(ByVal num1 As Double, ByVal num2 As Double) As Double
        Return num1 - num2
    End Function

    Private Function divide(ByVal num1 As Double, ByVal num2 As Double) As Double
        Return num1 / num2
    End Function

    Private Function multipul(ByVal num1 As Double, ByVal num2 As Double) As Double
        Return num1 * num2
    End Function

    Private Function modulus(ByVal num1 As Integer, ByVal num2 As Integer) As Integer
        Return num1 Mod num2
    End Function

    Private Function Pi(ByVal num1 As Double) As Double
        Return num1 * Math.PI
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        revertBool()
        txtNum1.Clear()
        txtAnswer.Clear()
        txtNum2.Clear()
        txtNum2.ReadOnly = False
        txtNum1.ReadOnly = False
        txtAnswer.ReadOnly = True
    End Sub

    Private Sub revertBool()
        isAdding = False
        isSubtracting = False
        isDividing = False
        isMultipuling = False
        isModulus = False
    End Sub

    Private Sub btnPi_MouseHover(sender As Object, e As EventArgs) Handles btnPi.MouseHover
        tlTipPi.SetToolTip(btnPi, "Only One Value Is Needed In The First Field")
    End Sub

    Private Sub txtAnswer_TextChanged(sender As Object, e As EventArgs) Handles txtAnswer.TextChanged

    End Sub
End Class
