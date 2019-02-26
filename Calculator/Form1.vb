''' <summary>
''' Author @ Mohit Nainwal
''' </summary>

Public Class Calculator

    Dim value1, value2, result As Double
    Dim str, opr As String
    Dim op = False, clr = False

    ''' Buttons 0 - 9 respectively'''

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Btn0.Click
        If clr Then
            clear()
        End If
        str = TextBox1.Text
        str += Btn0.Text
        TextBox1.Text = str
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        If clr Then
            clear()
        End If
        str = TextBox1.Text
        str += Btn1.Text
        TextBox1.Text = str
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        If clr Then
            clear()
        End If
        str = TextBox1.Text
        str += Btn2.Text
        TextBox1.Text = str
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Btn3.Click
        If clr Then
            clear()
        End If
        str = TextBox1.Text
        str += Btn3.Text
        TextBox1.Text = str
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Btn4.Click
        If clr Then
            clear()
        End If
        str = TextBox1.Text
        str += Btn4.Text
        TextBox1.Text = str
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Btn5.Click
        If clr Then
            clear()
        End If
        str = TextBox1.Text
        str += Btn5.Text
        TextBox1.Text = str
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Btn6.Click
        If clr Then
            clear()
        End If
        str = TextBox1.Text
        str += Btn6.Text
        TextBox1.Text = str
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Btn7.Click
        If clr Then
            clear()
        End If
        str = TextBox1.Text
        str += Btn7.Text
        TextBox1.Text = str
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Btn8.Click
        If clr Then
            clear()
        End If
        str = TextBox1.Text
        str += Btn8.Text
        TextBox1.Text = str
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Btn9.Click
        If clr Then
            clear()
        End If
        str = TextBox1.Text
        str += Btn9.Text
        TextBox1.Text = str
    End Sub

    ''' Cancel button '''

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles opr6.Click
        clear()
    End Sub

    ''' Equals button '''
    ''' Computes the result of the desired operation'''

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles opr5.Click
        If (op) Then
            If (opr.Equals("+")) Then
                value2 = Double.Parse(TextBox1.Text)
                result = value1 + value2
            ElseIf (opr.Equals("-")) Then
                value2 = Double.Parse(TextBox1.Text)
                result = value1 - value2
            ElseIf (opr.Equals("*")) Then
                value2 = Double.Parse(TextBox1.Text)
                result = value1 * value2
            ElseIf (opr.Equals("/")) Then
                value2 = Double.Parse(TextBox1.Text)
                result = value1 / value2
            End If
            op = False
            clr = True
            TextBox1.Text = value1.ToString + " " + opr + " " + value2.ToString + " = " + result.ToString
        End If
    End Sub

    ''' Arithmetic operation buttons  +,-,*,/'''

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles opr1.Click
        If (Not op) Then
            value1 = Double.Parse(str)
            op = True
            opr = opr1.Text
            str += opr
            TextBox1.Text = ""
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles opr2.Click
        If (Not op) Then
            value1 = Double.Parse(str)
            op = True
            opr = opr2.Text
            str += opr
            TextBox1.Text = ""
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles opr3.Click
        If (Not op) Then
            value1 = Double.Parse(str)
            op = True
            opr = opr3.Text
            str += opr
            TextBox1.Text = ""
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles opr4.Click
        If (Not op) Then
            value1 = Double.Parse(str)
            op = True
            opr = opr4.Text
            str += opr
            TextBox1.Text = ""
        End If
    End Sub

    Function clear()
        str = ""
        TextBox1.Text = str
        clr = False
    End Function

End Class
