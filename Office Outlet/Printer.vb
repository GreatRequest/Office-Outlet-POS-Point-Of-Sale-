Public Class Printer
    Private Sub Btn_Back_Click(sender As Object, e As EventArgs) Handles Btn_Back.Click
        Me.Close()
        Price_Match.Show()
    End Sub

    Private Sub Brother_Click(sender As Object, e As EventArgs) Handles Brother.Click
        SBrother.Show()
        Me.Hide()
    End Sub

    Private Sub CANON_Click(sender As Object, e As EventArgs) Handles CANON.Click
        SCANON.Show()
        Me.Hide()
    End Sub

    Private Sub EPSON_Click(sender As Object, e As EventArgs) Handles EPSON.Click
        SEPSON.Show()
        Me.Hide()
    End Sub

    Private Sub HP_Click(sender As Object, e As EventArgs) Handles HP.Click
        shp.Show()
        Me.Hide()
    End Sub

    Private Sub Argos_Click(sender As Object, e As EventArgs) Handles Argos.Click
        sargos.Show()
        Me.Hide()
    End Sub

    Private Sub Carrys_Click(sender As Object, e As EventArgs) Handles Carrys.Click
        scarrys.Show()
        Me.Hide()
    End Sub
End Class