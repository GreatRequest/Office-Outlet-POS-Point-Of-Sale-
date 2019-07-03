Public Class SwitchBoard
    Private Sub Btn_Close_Click(sender As Object, e As EventArgs)
        Login.Close()
    End Sub

    Private Sub BTn_Display_Click(sender As Object, e As EventArgs)
        Slider.Show()
        Me.Hide()
    End Sub

    Private Sub Btn__Click(sender As Object, e As EventArgs)
        Office_Outlet.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_Exit_Click(sender As Object, e As EventArgs) Handles Btn_Exit.Click
        Login.Close()
    End Sub

    Private Sub Btn_My_Info_Click(sender As Object, e As EventArgs) Handles Btn_My_Info.Click
        Process.Start("C:\windows\system32\msinfo32.exe")
    End Sub

    Private Sub Btn_Display_Site_Click(sender As Object, e As EventArgs) Handles Btn_Display_Site.Click
        Office_Outlet.Show()
        Me.Hide()
    End Sub

    Private Sub BTn_Display_SlideShow_Click(sender As Object, e As EventArgs) Handles BTn_Display_SlideShow.Click
        Slider.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_Price_Match_Click(sender As Object, e As EventArgs) Handles Btn_Price_Match.Click
        Price_Match.Show()
        Me.Hide()
    End Sub
End Class