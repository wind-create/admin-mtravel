Public Class Login
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim admin As DataTable
    Sub Terbuka()

        FormMenuUtama.LoginToolStripMenuItem.Enabled = False
        FormMenuUtama.LogoutToolStripMenuItem.Enabled = True
        FormMenuUtama.MasterToolStripMenuItem.Enabled = True
        FormMenuUtama.TransaksiToolStripMenuItem.Enabled = True

        FormMenuUtama.LogoutToolStripMenuItem.Enabled = True
        FormMenuUtama.LaporanToolStripMenuItem.Enabled = True
    End Sub
    Sub KondisiAwal()
        UsernameTextBox.Text = ""
        PasswordTextBox.Text = ""
    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        SQL = "Select * From admin where username_admin='" & UsernameTextBox.Text & "' and password_admin= '" & PasswordTextBox.Text & "'"
        admin = Proses.ExecuteQuery(SQL)
        If admin.Rows.Count <> 0 Then
            Call Terbuka()
            Me.Hide()
        Else
            MsgBox("username dan password anda salah")
            UsernameTextBox.Clear()
            PasswordTextBox.Clear()
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()
    End Sub
End Class
