Public Class frmDateTime
    Dim datTodayDate As Date
    Dim datCurrentTime As Date
    Dim datFullDateTime As Date

    Private Sub btnShortDate_Click(sender As Object, e As EventArgs) Handles btnShortDate.Click
        datTodayDate = Today
        lblShortDate.Text = datTodayDate.ToString("d")
    End Sub

    Private Sub btnLongDate_Click(sender As Object, e As EventArgs) Handles btnLongDate.Click
        datTodayDate = Today
        lblLongDate.Text = datTodayDate.ToString("D")
    End Sub

    Private Sub btnShortTime_Click(sender As Object, e As EventArgs) Handles btnShortTime.Click
        datCurrentTime = TimeOfDay
        lblShortTime.Text = datCurrentTime.ToString("t")
    End Sub

    Private Sub btnLongTime_Click(sender As Object, e As EventArgs) Handles btnLongTime.Click
        datCurrentTime = TimeOfDay
        lblLongTime.Text = datCurrentTime.ToString("T")
    End Sub

    Private Sub btnFullDateTime_Click(sender As Object, e As EventArgs) Handles btnFullDateTime.Click
        datFullDateTime = Now
        lblFullDateTime.Text = datFullDateTime.ToString("F")
    End Sub
End Class
