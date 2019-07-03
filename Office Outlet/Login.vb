Public Class Login
    Private Sub Btn_Login_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Btn_Login_Click_1(sender As Object, e As EventArgs) Handles Btn_Login.Click
        If TxtBx_Staff_Username.Text = "Rihards" And TxtBx_Staff_Password.Text = "Password" Then
            Me.Hide()
            SwitchBoard.Show()
        Else
            MessageBox.Show("The only tip I can give you is to not use tha Caps Lock",
                        "Extremly Important Message")
        End If
    End Sub

    Private Sub TxtBx_Staff_Password_TextChanged(sender As Object, e As EventArgs) Handles TxtBx_Staff_Password.TextChanged

    End Sub
End Class
