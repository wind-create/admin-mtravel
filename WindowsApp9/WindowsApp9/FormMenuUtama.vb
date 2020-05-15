Imports MySql.Data.MySqlClient


Public Class FormMenuUtama

    Dim Connection As New MySqlConnection("server=localhost; user=root; password=; database=mtravel")
    Dim MySQLCMD As New MySqlCommand
    Dim MySQLDA As New MySqlDataAdapter
    Dim DT As New DataTable

    Dim Table_Name As String = "info_paket" 'your table name
    Dim Data As Integer
    Dim Table_jual As String = "jual" 'your table name
    Dim Table_kendaraan As String = "kendaraan" 'your table name
    Dim Table_hotel As String = "hotel" 'your table name

    Dim LoadImagesStr As Boolean = False
    Dim id_adminRam, nama_adminRam, username_adminRam, password_adminRam As String
    Dim IMG_FileNameInput As String
    Dim StatusInput As String = "Save"
    Dim SqlCmdSearchstr As String
    Dim Col0Ram As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        ShowData()
        Showjual()
        ShowKendaraan()
        ShowHotel()

    End Sub
    Private Sub ShowData()
        Try
            Connection.Open()
        Catch ex As Exception
            MessageBox.Show("Connection failed !!!" & vbCrLf & "Please check that the server is ready !!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

        Try
            If LoadImagesStr = False Then
                MySQLCMD.CommandType = CommandType.Text
                MySQLCMD.CommandText = "SELECT paket,hotel, transportasi, jumlah, harga FROM " & Table_Name & " ORDER BY paket"
                MySQLDA = New MySqlDataAdapter(MySQLCMD.CommandText, Connection)
                DT = New DataTable
                Data = MySQLDA.Fill(DT)
                If Data > 0 Then
                    DataGridView1.DataSource = Nothing
                    DataGridView1.DataSource = DT

                    DataGridView1.ClearSelection()
                Else
                    DataGridView1.DataSource = DT
                End If

            End If
        Catch ex As Exception
            MsgBox("Failed to load Database !!!" & vbCr & ex.Message, MsgBoxStyle.Critical, "Error Message")
            Connection.Close()
            Return
        End Try

        DT = Nothing
        Connection.Close()
    End Sub

    Private Sub ShowHotel()
        Try
            Connection.Open()
        Catch ex As Exception
            MessageBox.Show("Connection failed !!!" & vbCrLf & "Please check that the server is ready !!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

        Try
            If LoadImagesStr = False Then
                MySQLCMD.CommandType = CommandType.Text
                MySQLCMD.CommandText = "SELECT id_hotel, nama_hotel, deskripsi_hotel FROM " & Table_hotel & " ORDER BY nama_hotel"
                MySQLDA = New MySqlDataAdapter(MySQLCMD.CommandText, Connection)
                DT = New DataTable
                Data = MySQLDA.Fill(DT)
                If Data > 0 Then
                    DataGridView4.DataSource = Nothing
                    DataGridView4.DataSource = DT

                    DataGridView4.ClearSelection()
                Else
                    DataGridView4.DataSource = DT
                End If

            End If
        Catch ex As Exception
            MsgBox("Failed to load Database !!!" & vbCr & ex.Message, MsgBoxStyle.Critical, "Error Message")
            Connection.Close()
            Return
        End Try

        DT = Nothing
        Connection.Close()
    End Sub
    Private Sub ShowKendaraan()
        Try
            Connection.Open()
        Catch ex As Exception
            MessageBox.Show("Connection failed !!!" & vbCrLf & "Please check that the server is ready !!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

        Try
            If LoadImagesStr = False Then
                MySQLCMD.CommandType = CommandType.Text
                MySQLCMD.CommandText = "SELECT id_kendaraan, nama_kendaraan, deskripsi_kendaraan FROM " & Table_kendaraan & " ORDER BY Nama_kendaraan"
                MySQLDA = New MySqlDataAdapter(MySQLCMD.CommandText, Connection)
                DT = New DataTable
                Data = MySQLDA.Fill(DT)
                If Data > 0 Then
                    DataGridView3.DataSource = Nothing
                    DataGridView3.DataSource = DT

                    DataGridView3.ClearSelection()
                Else
                    DataGridView3.DataSource = DT
                End If

            End If
        Catch ex As Exception
            MsgBox("Failed to load Database !!!" & vbCr & ex.Message, MsgBoxStyle.Critical, "Error Message")
            Connection.Close()
            Return
        End Try

        DT = Nothing
        Connection.Close()
    End Sub
    Private Sub Showjual()
        Try
            Connection.Open()
        Catch ex As Exception
            MessageBox.Show("Connection failed !!!" & vbCrLf & "Please check that the server is ready !!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

        Try
            If LoadImagesStr = False Then
                MySQLCMD.CommandType = CommandType.Text
                MySQLCMD.CommandText = "SELECT paket,hotel, transportasi, jumlah, harga FROM " & Table_Name & " ORDER BY paket"
                MySQLDA = New MySqlDataAdapter(MySQLCMD.CommandText, Connection)
                DT = New DataTable
                Data = MySQLDA.Fill(DT)
                If Data > 0 Then
                    DataGridView2.DataSource = Nothing
                    DataGridView2.DataSource = DT

                    DataGridView2.ClearSelection()
                Else
                    DataGridView2.DataSource = DT
                End If

            End If
        Catch ex As Exception
            MsgBox("Failed to load Database !!!" & vbCr & ex.Message, MsgBoxStyle.Critical, "Error Message")
            Connection.Close()
            Return
        End Try

        DT = Nothing
        Connection.Close()
    End Sub
    Sub Terkunci()
        LoginToolStripMenuItem.Enabled = True
        LogoutToolStripMenuItem.Enabled = False
        MasterToolStripMenuItem.Enabled = False
        TransaksiToolStripMenuItem.Enabled = False
        LogoutToolStripMenuItem.Enabled = False
        LaporanToolStripMenuItem.Enabled = False
    End Sub
    Sub Pelanggan()
        LoginToolStripMenuItem.Enabled = True
        LogoutToolStripMenuItem.Enabled = True
        MasterToolStripMenuItem.Enabled = False
        TransaksiToolStripMenuItem.Enabled = True


        LogoutToolStripMenuItem.Enabled = True
        LaporanToolStripMenuItem.Enabled = False

    End Sub

    Private Sub FormMenuUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Terkunci()
    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        Login.ShowDialog()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Call Terkunci()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        End
    End Sub

    Private Sub AdminToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdminToolStripMenuItem.Click
        FormMasterAdmin.ShowDialog()
    End Sub

    Private Sub PelangganToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PelangganToolStripMenuItem.Click
        FormMasterPelanggan.ShowDialog()

    End Sub

    Private Sub WisataToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FormWisata.ShowDialog()
    End Sub

    Private Sub RegisterToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FormRegister.ShowDialog()
    End Sub

    Private Sub PembayaranToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PembayaranToolStripMenuItem.Click
        FormPembayaran.ShowDialog()
    End Sub

    Private Sub KendaraanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KendaraanToolStripMenuItem.Click
        FormKendaraan.ShowDialog()
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub


    Private Sub HotelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HotelToolStripMenuItem.Click
        Formhotel.ShowDialog()
    End Sub

    Private Sub TourToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TourToolStripMenuItem.Click
        FormPaket.ShowDialog()
    End Sub

    Private Sub OrderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrderToolStripMenuItem.Click
        FormJual.ShowDialog()
    End Sub
End Class