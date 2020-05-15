Imports MySql.Data.MySqlClient

Public Class FormPaket

    'user=your mysql user name; password=your password; database=your database name
    Dim Connection As New MySqlConnection("server='localhost'; user='root'; password=; database='mtravel'")
    Dim MySQLCMD As New MySqlCommand
    Dim MySQLDA As New MySqlDataAdapter
    Dim DT As New DataTable

    Dim Table_Name As String = "paket" 'your table name
    Dim Data As Integer

    Dim LoadImagesStr As Boolean = False
    Dim id_paketRam, nama_paketRam, hargaRam, paxRam, id_kendaraanRam, id_hotelRam As String
    Dim IMG_FileNameInput As String
    Dim StatusInput As String = "Save"
    Dim SqlCmdSearchstr As String
    Dim Col0Ram As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        ShowData()
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
                MySQLCMD.CommandText = "SELECT id_paket, nama_paket, harga, pax, id_kendaraan, id_hotel FROM " & Table_Name & " ORDER BY nama_paket"
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

    Private Sub ClearInputUpdateData()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBoxID.Text = ""



    End Sub

    Private Sub ButtonIDMaker_Click(sender As Object, e As EventArgs) Handles ButtonIDMaker.Click
        Try
            Connection.Open()
        Catch ex As Exception
            MessageBox.Show("Connection failed !!!" & vbCrLf & "Please check that the server is ready !!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

        Try
            Dim r As Random = New Random
            Dim num As Integer
            num = (r.Next(1, 9999))
            Dim IDMaker As String = Strings.Right("0000" & num.ToString(), 4)
            TextBoxID.Text = "1" & IDMaker

            MySQLCMD.CommandType = CommandType.Text
            MySQLCMD.CommandText = "SELECT id_paket FROM " & Table_Name & " WHERE id_paket LIKE " & TextBoxID.Text
            MySQLDA = New MySqlDataAdapter(MySQLCMD.CommandText, Connection)
            DT = New DataTable
            Data = MySQLDA.Fill(DT)
            If Data > 0 Then
                ButtonIDMaker_Click(sender, e)
            End If
        Catch ex As Exception
            TextBoxID.Text = ""
            MsgBox("Failed to make ID !!!" & vbCr & ex.Message, MsgBoxStyle.Critical, "Error Message")
            DT = Nothing
            Connection.Close()
            Return
        End Try

        DT = Nothing
        Connection.Close()
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        Dim mstream As New System.IO.MemoryStream()



        If StatusInput = "Save" Then


            Try
                Connection.Open()
            Catch ex As Exception
                MessageBox.Show("Connection failed !!!" & vbCrLf & "Please check that the server is ready !!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End Try

            Try
                MySQLCMD = New MySqlCommand
                With MySQLCMD
                    .CommandText = "INSERT INTO " & Table_Name & " (id_paket, nama_paket, harga, pax, id_kendaraan, id_hotel) VALUES (@id_paket, @nama_paket, @harga, @pax, @id_kendaraan, @id_hotel)"
                    .Connection = Connection
                    .Parameters.AddWithValue("@id_paket", TextBoxID.Text)
                    .Parameters.AddWithValue("@nama_paket", TextBox1.Text)
                    .Parameters.AddWithValue("@harga", TextBox2.Text)
                    .Parameters.AddWithValue("@pax", TextBox3.Text)
                    .Parameters.AddWithValue("@id_kendaraan", TextBox4.Text)
                    .Parameters.AddWithValue("@id_hotel", TextBox5.Text)
                    .ExecuteNonQuery()
                End With
                MsgBox("Data saved successfully", MsgBoxStyle.Information, "Information")
                IMG_FileNameInput = ""
                ClearInputUpdateData()
            Catch ex As Exception
                MsgBox("Data failed to save !!!" & vbCr & ex.Message, MsgBoxStyle.Critical, "Error Message")
                Connection.Close()
                Return
            End Try
            Connection.Close()

        Else

            If IMG_FileNameInput <> "" Then


                Try
                    Connection.Open()
                Catch ex As Exception
                    MessageBox.Show("Connection failed !!!" & vbCrLf & "Please check that the server is ready !!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End Try

                Try
                    MySQLCMD = New MySqlCommand
                    With MySQLCMD
                        .CommandText = "UPDATE " & Table_Name & " SET id_paket=@id_paket, nama_paket=@nama_paket, harga=@harga, pax=@pax, id_kendaraan=@id_kendaraan, id_hotel=@id_hotel WHERE id_paket=@id_paket "
                        .Connection = Connection
                        .Parameters.AddWithValue("@id_paket", TextBoxID.Text)
                        .Parameters.AddWithValue("@nama_paket", TextBox1.Text)
                        .Parameters.AddWithValue("@harga", TextBox2.Text)
                        .Parameters.AddWithValue("@pax", TextBox3.Text)
                        .Parameters.AddWithValue("@id_kendaraan", TextBox4.Text)
                        .Parameters.AddWithValue("@id_hotel", TextBox5.Text)
                        .ExecuteNonQuery()
                    End With
                    MsgBox("Data updated successfully", MsgBoxStyle.Information, "Information")
                    IMG_FileNameInput = ""
                    ButtonSave.Text = "Save"
                    ButtonIDMaker.Enabled = True
                    TextBoxID.Enabled = True
                    ClearInputUpdateData()
                Catch ex As Exception
                    MsgBox("Data failed to Update !!!" & vbCr & ex.Message, MsgBoxStyle.Critical, "Error Message")
                    Connection.Close()
                    Return
                End Try
                Connection.Close()

            Else

                Try
                    Connection.Open()
                Catch ex As Exception
                    MessageBox.Show("Connection failed !!!" & vbCrLf & "Please check that the server is ready !!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End Try

                Try
                    MySQLCMD = New MySqlCommand
                    With MySQLCMD
                        .CommandText = "UPDATE " & Table_Name & " SET  id_paket=@id_paket, nama_paket=@nama_paket, harga=@harga, pax=@pax, id_kendaraan=@id_kendaraan, id_hotel=@id_hotel WHERE id_paket=@id_paket "
                        .Connection = Connection
                        .Parameters.AddWithValue("@id_paket", TextBoxID.Text)
                        .Parameters.AddWithValue("@nama_paket", TextBox1.Text)
                        .Parameters.AddWithValue("@harga", TextBox2.Text)
                        .Parameters.AddWithValue("@pax", TextBox3.Text)
                        .Parameters.AddWithValue("@id_kendaraan", TextBox4.Text)
                        .Parameters.AddWithValue("@id_hotel", TextBox5.Text)
                        .ExecuteNonQuery()
                    End With
                    MsgBox("Data updated successfully", MsgBoxStyle.Information, "Information")
                    ButtonSave.Text = "Save"
                    ButtonIDMaker.Enabled = True
                    TextBoxID.Enabled = True
                    ClearInputUpdateData()
                Catch ex As Exception
                    MsgBox("Data failed to Update !!!" & vbCr & ex.Message, MsgBoxStyle.Critical, "Error Message")
                    Connection.Close()
                    Return
                End Try
                Connection.Close()
            End If
            StatusInput = "Save"
        End If

        ShowData()
    End Sub

    Private Sub ButtonClearAll_Click(sender As Object, e As EventArgs) Handles ButtonClearALL.Click
        ButtonSave.Text = "Save"
        StatusInput = "Save"
        ButtonIDMaker.Enabled = True
        TextBoxID.Enabled = True
        ClearInputUpdateData()
    End Sub



    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click
        If DataGridView1.RowCount = 1 Then
            TextBoxID.Text = id_paketRam
            TextBox1.Text = nama_paketRam
            TextBox2.Text = hargaRam
            TextBox3.Text = paxRam
            TextBox4.Text = id_kendaraanRam
            TextBox5.Text = id_hotelRam
            ButtonIDMaker.Enabled = False
            TextBoxID.Enabled = False
            ButtonSave.Text = "Update"
            StatusInput = "Update"
            Return
        End If

        If AllCellsSelected(DataGridView1) = False Then
            TextBoxID.Text = id_paketRam
            TextBox1.Text = nama_paketRam
            TextBox2.Text = hargaRam
            TextBox3.Text = paxRam
            TextBox4.Text = id_kendaraanRam
            TextBox5.Text = id_hotelRam
            ButtonIDMaker.Enabled = False
            TextBoxID.Enabled = False
            ButtonSave.Text = "Update"
            StatusInput = "Update"
        Else
            MsgBox("Cannot edit !!! " & vbCr & "Please choose one to edit.", MsgBoxStyle.Critical, "Error Message")
        End If
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        If DataGridView1.RowCount = 0 Then
            MsgBox("Cannot delete, table data is empty", MsgBoxStyle.Critical, "Error Message")
            Return
        End If

        If DataGridView1.SelectedRows.Count = 0 Then
            MsgBox("Cannot delete, select the table data to be deleted", MsgBoxStyle.Critical, "Error Message")
            Return
        End If

        If MsgBox("Delete record?", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Cancel Then Return

        Try
            Connection.Open()
        Catch ex As Exception
            MessageBox.Show("Connection failed !!!" & vbCrLf & "Please check that the server is ready !!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

        Try
            If AllCellsSelected(DataGridView1) = True Then
                MySQLCMD.CommandType = CommandType.Text
                MySQLCMD.CommandText = "DELETE FROM " & Table_Name
                MySQLCMD.Connection = Connection
                MySQLCMD.ExecuteNonQuery()
            End If

            For Each row As DataGridViewRow In DataGridView1.SelectedRows
                If row.Selected = True Then
                    MySQLCMD.CommandType = CommandType.Text
                    MySQLCMD.CommandText = "DELETE FROM " & Table_Name & " WHERE id_paket='" & row.DataBoundItem(1).ToString & "'"
                    MySQLCMD.Connection = Connection
                    MySQLCMD.ExecuteNonQuery()
                End If
            Next
        Catch ex As Exception
            MsgBox("Failed to delete" & vbCr & ex.Message, MsgBoxStyle.Critical, "Error Message")
            Connection.Close()
        End Try

        Connection.Close()
        ShowData()
    End Sub

    Private Sub ButtonRefresh_Click(sender As Object, e As EventArgs) Handles ButtonRefresh.Click
        ShowData()
    End Sub

    Private Sub DataGridView1_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDown
        Try
            If AllCellsSelected(DataGridView1) = False Then
                If e.Button = MouseButtons.Left Then
                    DataGridView1.CurrentCell = DataGridView1(e.ColumnIndex, e.RowIndex)
                    Dim i As Integer
                    With DataGridView1
                        If e.RowIndex >= 0 Then
                            i = .CurrentRow.Index
                            LoadImagesStr = True
                            id_hotelRam = .Rows(i).Cells("id_hotel").Value.ToString
                            nama_paketRam = .Rows(i).Cells("nama_paket").Value.ToString
                            hargaRam = .Rows(i).Cells("harga").Value.ToString
                            paxRam = .Rows(i).Cells("pax").Value.ToString
                            id_paketRam = .Rows(i).Cells("id_paket").Value.ToString
                            id_kendaraanRam = .Rows(i).Cells("id_kendaraan").Value.ToString
                            ShowData()
                        End If
                    End With
                End If
            End If
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Function AllCellsSelected(dgv As DataGridView) As Boolean
        AllCellsSelected = (DataGridView1.SelectedCells.Count = (DataGridView1.RowCount * DataGridView1.Columns.GetColumnCount(DataGridViewElementStates.Visible)))
    End Function

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        ButtonDelete_Click(sender, e)
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        ButtonEdit_Click(sender, e)
    End Sub


    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectALLToolStripMenuItem.Click
        DataGridView1.SelectAll()
    End Sub






End Class