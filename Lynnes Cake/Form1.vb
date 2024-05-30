Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cake As String
        Dim Qcake As Integer
        Dim Pcake As Integer
        Dim Tcake As Integer

        Dim bread As String
        Dim Qbread As Integer
        Dim Pbread As Integer
        Dim Tbread As Integer

        Dim Torders As Integer
        Dim Total As Integer

        cake = txtNcake.Text
        Qcake = txtCamount.Text
        Pcake = txtCprice.Text
        txtCtotal.Text = Qcake * Pcake

        bread = txtBamount.Text
        Qbread = txtBamount.Text
        Pbread = txtBprice.Text
        txtBtotal.Text = Qbread * Pbread

        txtTamount.Text = Qcake + Qbread
        txtTotal.Text = (Qcake * Pcake) + (Qbread * Pbread)

    End Sub
End Class
