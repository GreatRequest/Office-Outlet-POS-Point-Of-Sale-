Public Class Price_Match
    Private Sub Btn_Close_Click(sender As Object, e As EventArgs) Handles Btn_Back.Click
        Me.Close()
        SwitchBoard.Show()
    End Sub

    Private Sub Btn_Laptop_Click(sender As Object, e As EventArgs) Handles Btn_Laptop.Click
        Laptop.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_Printer_Click(sender As Object, e As EventArgs) Handles Btn_Printer.Click
        Printer.Show()
        Me.Hide()
    End Sub
End Class