Public Class Login
    Private Sub log()
        If TextBox1.Text IsNot "Usuario" Then

            If TextBox2.Text IsNot "Contraseña" Then
                Dim login As String = DataAccess.login(TextBox1.Text, TextBox2.Text)

                If login Is "OK" Then
                    DialogResult = DialogResult.OK
                    MessageBox.Show("OK")
                ElseIf login Is "Disabled" Then
                    MessageBox.Show("User disabled")
                Else
                    MessageBox.Show("Usuario y/o contraseña invalidos")
                End If
            Else
                errorProvider1.SetError(TextBox2, "Ingrese su contraseña")
            End If
        Else

            If TextBox1.Text Is "Usuario" Then
                errorProvider1.SetError(TextBox1, "Ingrese su usuario")
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        log()
    End Sub

#Region "Buttons"
    Private Sub TextBox1_Enter(sender As Object, e As EventArgs) Handles TextBox1.Enter
        If TextBox1.Text = "Usuario" Then
            TextBox1.Text = ""
            TextBox1.ForeColor = Color.White
        End If
    End Sub

    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles TextBox1.Leave
        If TextBox1.Text = "" Then
            TextBox1.Text = "Usuario"
            TextBox1.ForeColor = Color.LightGray
        End If
    End Sub

    Private Sub TextBox2_Enter(sender As Object, e As EventArgs) Handles TextBox2.Enter
        If TextBox2.Text = "Contraseña" Then
            TextBox2.Text = ""
            TextBox2.ForeColor = Color.White
        End If
    End Sub

    Private Sub TextBox2_Leave(sender As Object, e As EventArgs) Handles TextBox2.Leave
        If TextBox2.Text = "" Then
            TextBox2.Text = "Contraseña"
            TextBox2.ForeColor = Color.LightGray
        End If
    End Sub
#End Region
End Class
