Public Class Form1
    Public hrgmakanan, hrgminuman As Integer

    Private Sub Cbkmakanan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbkmakanan.SelectedIndexChanged
        Select Case Cbkmakanan.Text
            Case "Nasi Uduk"
                Label3.Text = "Rp. 3500"
                hrgmakanan = 3500
            Case "Bakso"
                Label3.Text = "Rp. 6000"
                hrgmakanan = 6000
            Case "Mie Ayam"
                Label3.Text = "Rp. 7000"
                hrgmakanan = 7000
        End Select
    End Sub


    Private Sub Cbkminuman_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbkminuman.SelectedIndexChanged
        Select Case Cbkminuman.Text
            Case "Es Jeruk"
                Label4.Text = "Rp. 3000"
                hrgminuman = 3000
            Case "Es Kelapa Muda"
                Label4.Text = "Rp. 5000"
                hrgminuman = 5000
            Case "Teh Manis"
                Label4.Text = "Rp. 6000"
                hrgminuman = 6000
        End Select
    End Sub

    Public Sub New()

        ' This call is required by the designer.

        InitializeComponent()
        Cbkminuman.Visible = False
        Label4.Visible = False
        txtminum.Visible = False

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = False Then
            Cbkminuman.Visible = False
            Label4.Visible = False
            txtminum.Visible = False
        End If

        If CheckBox1.Checked = True Then
            Cbkminuman.Visible = True
            Label4.Visible = True
            txtminum.Visible = True
        End If
    End Sub

    Private Sub Btnhitung_Click(sender As Object, e As EventArgs) Handles btnhitung.Click
        Dim porsimakanan, porsiminuman, jumlah As Integer

        If txtmakan.Text = "" Then
            porsimakanan = 0
        Else
            porsimakanan = txtmakan.Text
            jumlah = (hrgmakanan * porsimakanan)
            Label7.Text = "Rp. " & jumlah.ToString
        End If

        If txtminum.Text = "" Then
            porsiminuman = 0
        Else
            porsimakanan = txtmakan.Text
            porsiminuman = txtminum.Text

            jumlah = (hrgmakanan * porsimakanan) + (hrgminuman * porsiminuman)
            Label7.Text = "Rp. " & jumlah.ToString
        End If
    End Sub

    Private Sub Btnulang_Click(sender As Object, e As EventArgs) Handles btnulang.Click
        Cbkmakanan.Text = ""
        Cbkminuman.Text = ""
        txtmakan.Text = ""
        txtminum.Text = ""
        Label3.Text = ""
        Label4.Text = ""
        Label7.Text = ""
        Cbkmakanan.Focus()
    End Sub


    Private Sub Btnkeluar_Click(sender As Object, e As EventArgs) Handles btnkeluar.Click
        End
    End Sub

End Class




