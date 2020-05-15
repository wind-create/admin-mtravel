Imports MySql.Data.MySqlClient


Public Class FormRegister
    'user=your mysql user name; password=your password; database=your database name
    Dim Connection As New MySqlConnection("server='localhost'; user='root'; password=; database='mtravel'")
    Dim MySQLCMD As New MySqlCommand
    Dim MySQLDA As New MySqlDataAdapter
    Dim DT As New DataTable

    Dim Table_Name As String = "pelanggan" 'your table name
    Dim Data As Integer

    Dim LoadImagesStr As Boolean = False
    Dim id_pelangganRam, nama_pelangganRam, alamat_pelangganRam, telp_pelangganRam As String
    Dim IMG_FileNameInput As String
    Dim StatusInput As String = "Save"
    Dim SqlCmdSearchstr As String
    Dim Col0Ram As Integer = 0

   



    Private Sub ClearInputUpdateData()
        TextBoxName.Text = ""
        TextBoxID.Text = ""
        TextBoxPrice.Text = ""
        TextBoxAmount.Text = ""
        PictureBoxImageInput.Image = My.Resources.rsz_photos2_512
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
            MySQLCMD.CommandText = "SELECT id_pelanggan FROM " & Table_Name & " WHERE id_pelanggan LIKE " & TextBoxID.Text
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
        Dim arrImage() As Byte

        If TextBoxName.Text = "" Then
            MessageBox.Show("Name cannot be empty !!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If TextBoxPrice.Text = "" Then
            MessageBox.Show("Price cannot be empty !!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If TextBoxAmount.Text = "" Then
            MessageBox.Show("Amount cannot be empty !!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If


        If StatusInput = "Save" Then
            If IMG_FileNameInput <> "" Then
                PictureBoxImageInput.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                arrImage = mstream.GetBuffer()
            Else
                MessageBox.Show("The image has not been selected !!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Try
                Connection.Open()
            Catch ex As Exception
                MessageBox.Show("Connection failed !!!" & vbCrLf & "Please check that the server is ready !!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End Try

            Try
                MySQLCMD = New MySqlCommand
                With MySQLCMD
                    .CommandText = "INSERT INTO " & Table_Name & " (nama_pelanggan, id_pelanggan, alamat_pelanggan, telp_pelanggan, Images) VALUES (@nama_pelanggan, @id_pelanggan, @alamat_pelanggan, @telp_pelanggan, @images)"
                    .Connection = Connection
                    .Parameters.AddWithValue("@nama_pelanggan", TextBoxName.Text)
                    .Parameters.AddWithValue("@id_pelanggan", TextBoxID.Text)
                    .Parameters.AddWithValue("@alamat_pelanggan", TextBoxPrice.Text)
                    .Parameters.AddWithValue("@telp_pelanggan", TextBoxAmount.Text)
                    .Parameters.AddWithValue("@images", arrImage)
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
                PictureBoxImageInput.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                arrImage = mstream.GetBuffer()

                Try
                    Connection.Open()
                Catch ex As Exception
                    MessageBox.Show("Connection failed !!!" & vbCrLf & "Please check that the server is ready !!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End Try

                Try
                    MySQLCMD = New MySqlCommand
                    With MySQLCMD
                        .CommandText = "UPDATE " & Table_Name & " SET  nama_pelanggan=@nama_pelanggan,alamat_pelanggan=@alamat_pelanggan,telp_pelanggan=@telp_pelanggan,Images=@images WHERE id_pelanggan=@id_pelanggan "
                        .Connection = Connection
                        .Parameters.AddWithValue("@nama_pelanggan", TextBoxName.Text)
                        .Parameters.AddWithValue("@id_pelanggan", TextBoxID.Text)
                        .Parameters.AddWithValue("@alamat_pelanggan", TextBoxPrice.Text)
                        .Parameters.AddWithValue("@telp_pelanggan", TextBoxAmount.Text)
                        .Parameters.AddWithValue("@images", arrImage)
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
                        .CommandText = "UPDATE " & Table_Name & " SET  nama_pelanggan=@nama_pelanggan,alamat_pelanggan=@alamat_pelanggan,telp_pelanggan=@telp_pelanggan WHERE id_pelanggan=@id_pelanggan "
                        .Connection = Connection
                        .Parameters.AddWithValue("@nama_pelanggan", TextBoxName.Text)
                        .Parameters.AddWithValue("@id_pelanggan", TextBoxID.Text)
                        .Parameters.AddWithValue("@alamat_pelanggan", TextBoxPrice.Text)
                        .Parameters.AddWithValue("@telp_pelanggan", TextBoxAmount.Text)
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


    End Sub

    Private Sub ButtonClearAll_Click(sender As Object, e As EventArgs) Handles ButtonClearALL.Click
        ButtonSave.Text = "Save"
        StatusInput = "Save"
        ButtonIDMaker.Enabled = True
        TextBoxID.Enabled = True
        ClearInputUpdateData()
    End Sub

    Private Sub PictureBoxImageInput_Click(sender As Object, e As EventArgs) Handles PictureBoxImageInput.Click
        OpenFileDialog1.FileName = ""
        'OpenFileDialog1.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
        OpenFileDialog1.Filter = "JPEG (*.jpeg;*.jpg)|*.jpeg;*.jpg"

        If (OpenFileDialog1.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            IMG_FileNameInput = OpenFileDialog1.FileName
            PictureBoxImageInput.ImageLocation = IMG_FileNameInput
        End If
    End Sub
    Private Sub TextBoxAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxAmount.KeyPress
        'code to only allow numeric input
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack Or e.KeyChar = "+") Then
            MessageBox.Show("Invalid Input! Numbers Only.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            e.Handled = True
        End If
    End Sub
End Class