Public Class Laptop
    Private Sub Btn_Back_Click(sender As Object, e As EventArgs) Handles Btn_Back.Click
        Me.Close()
        Price_Match.Show()
    End Sub

    Private Sub Argos_Click(sender As Object, e As EventArgs) Handles Argos.Click
        sargos.Show()
        Me.Hide()
    End Sub

    Private Sub CarrysPCWorld_Click(sender As Object, e As EventArgs) Handles CarrysPCWorld.Click
        sCarrys.Show()
        Me.Hide()
    End Sub

    Private Sub Dell_Click(sender As Object, e As EventArgs) Handles Dell.Click
        sDell.Show()
        Me.Hide()
    End Sub

    Private Sub HP_Click(sender As Object, e As EventArgs) Handles HP.Click
        sHP.Show()
        Me.Hide()
    End Sub

    Private Sub Lenovo_Click(sender As Object, e As EventArgs) Handles Lenovo.Click
        sLenovo.Show()
        Me.Hide()
    End Sub

    Private Sub ASUS_Click(sender As Object, e As EventArgs) Handles ASUS.Click
        sASUS.Show()
        Me.Hide()
    End Sub
End Class