<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPembayaran
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ButtonClearSelectedandImagePreview = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBoxImagePreview = New System.Windows.Forms.PictureBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ButtonRefresh = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ButtonEdit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBoxTotal = New System.Windows.Forms.TextBox()
        Me.TextBoxHarga = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonClearALL = New System.Windows.Forms.Button()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonIDMaker = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBoxImageInput = New System.Windows.Forms.PictureBox()
        Me.TextBoxAmount = New System.Windows.Forms.TextBox()
        Me.TextBoxPrice = New System.Windows.Forms.TextBox()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.TextBoxID = New System.Windows.Forms.TextBox()
        Me.Amount = New System.Windows.Forms.Label()
        Me.Price = New System.Windows.Forms.Label()
        Me.namaAdmin = New System.Windows.Forms.Label()
        Me.idAdmin = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectALLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBoxImagePreview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBoxImageInput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.ButtonClearSelectedandImagePreview)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.PictureBoxImagePreview)
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Controls.Add(Me.ButtonRefresh)
        Me.GroupBox2.Controls.Add(Me.ButtonDelete)
        Me.GroupBox2.Controls.Add(Me.ButtonEdit)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(5, 374)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(922, 402)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Record Review"
        '
        'ButtonClearSelectedandImagePreview
        '
        Me.ButtonClearSelectedandImagePreview.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonClearSelectedandImagePreview.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClearSelectedandImagePreview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonClearSelectedandImagePreview.Location = New System.Drawing.Point(728, 286)
        Me.ButtonClearSelectedandImagePreview.Name = "ButtonClearSelectedandImagePreview"
        Me.ButtonClearSelectedandImagePreview.Size = New System.Drawing.Size(188, 33)
        Me.ButtonClearSelectedandImagePreview.TabIndex = 25
        Me.ButtonClearSelectedandImagePreview.Text = "Clear Selection"
        Me.ButtonClearSelectedandImagePreview.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonClearSelectedandImagePreview.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(757, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(124, 23)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Image review"
        '
        'PictureBoxImagePreview
        '
        Me.PictureBoxImagePreview.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxImagePreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBoxImagePreview.Location = New System.Drawing.Point(733, 106)
        Me.PictureBoxImagePreview.Name = "PictureBoxImagePreview"
        Me.PictureBoxImagePreview.Size = New System.Drawing.Size(174, 174)
        Me.PictureBoxImagePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxImagePreview.TabIndex = 28
        Me.PictureBoxImagePreview.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(17, 106)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(633, 259)
        Me.DataGridView1.TabIndex = 27
        '
        'ButtonRefresh
        '
        Me.ButtonRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonRefresh.Location = New System.Drawing.Point(248, 29)
        Me.ButtonRefresh.Name = "ButtonRefresh"
        Me.ButtonRefresh.Size = New System.Drawing.Size(122, 29)
        Me.ButtonRefresh.TabIndex = 15
        Me.ButtonRefresh.Text = "Refresh"
        Me.ButtonRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonRefresh.UseVisualStyleBackColor = True
        '
        'ButtonDelete
        '
        Me.ButtonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonDelete.Location = New System.Drawing.Point(132, 29)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(110, 29)
        Me.ButtonDelete.TabIndex = 14
        Me.ButtonDelete.Text = "Delete"
        Me.ButtonDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'ButtonEdit
        '
        Me.ButtonEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonEdit.Location = New System.Drawing.Point(17, 29)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.Size = New System.Drawing.Size(109, 29)
        Me.ButtonEdit.TabIndex = 13
        Me.ButtonEdit.Text = "Edit"
        Me.ButtonEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonEdit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.TextBoxTotal)
        Me.GroupBox1.Controls.Add(Me.TextBoxHarga)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ButtonClearALL)
        Me.GroupBox1.Controls.Add(Me.ButtonSave)
        Me.GroupBox1.Controls.Add(Me.ButtonIDMaker)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.PictureBoxImageInput)
        Me.GroupBox1.Controls.Add(Me.TextBoxAmount)
        Me.GroupBox1.Controls.Add(Me.TextBoxPrice)
        Me.GroupBox1.Controls.Add(Me.TextBoxName)
        Me.GroupBox1.Controls.Add(Me.TextBoxID)
        Me.GroupBox1.Controls.Add(Me.Amount)
        Me.GroupBox1.Controls.Add(Me.Price)
        Me.GroupBox1.Controls.Add(Me.namaAdmin)
        Me.GroupBox1.Controls.Add(Me.idAdmin)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(915, 356)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input dan Update"
        '
        'TextBoxTotal
        '
        Me.TextBoxTotal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxTotal.Location = New System.Drawing.Point(125, 223)
        Me.TextBoxTotal.Name = "TextBoxTotal"
        Me.TextBoxTotal.Size = New System.Drawing.Size(514, 30)
        Me.TextBoxTotal.TabIndex = 16
        '
        'TextBoxHarga
        '
        Me.TextBoxHarga.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxHarga.Location = New System.Drawing.Point(125, 187)
        Me.TextBoxHarga.Name = "TextBoxHarga"
        Me.TextBoxHarga.Size = New System.Drawing.Size(514, 30)
        Me.TextBoxHarga.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 222)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 23)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Total"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 187)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 23)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Harga"
        '
        'ButtonClearALL
        '
        Me.ButtonClearALL.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonClearALL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonClearALL.Location = New System.Drawing.Point(476, 302)
        Me.ButtonClearALL.Name = "ButtonClearALL"
        Me.ButtonClearALL.Size = New System.Drawing.Size(166, 29)
        Me.ButtonClearALL.TabIndex = 12
        Me.ButtonClearALL.Text = "Clear ALL"
        Me.ButtonClearALL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonClearALL.UseVisualStyleBackColor = True
        '
        'ButtonSave
        '
        Me.ButtonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonSave.Location = New System.Drawing.Point(20, 302)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(109, 29)
        Me.ButtonSave.TabIndex = 11
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'ButtonIDMaker
        '
        Me.ButtonIDMaker.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonIDMaker.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonIDMaker.Location = New System.Drawing.Point(476, 39)
        Me.ButtonIDMaker.Name = "ButtonIDMaker"
        Me.ButtonIDMaker.Size = New System.Drawing.Size(166, 29)
        Me.ButtonIDMaker.TabIndex = 10
        Me.ButtonIDMaker.Text = "ID Maker"
        Me.ButtonIDMaker.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonIDMaker.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(652, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 23)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Image:"
        '
        'PictureBoxImageInput
        '
        Me.PictureBoxImageInput.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxImageInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBoxImageInput.Image = Global.WindowsApp9.My.Resources.Resources.rsz_photos2_512
        Me.PictureBoxImageInput.Location = New System.Drawing.Point(726, 39)
        Me.PictureBoxImageInput.Name = "PictureBoxImageInput"
        Me.PictureBoxImageInput.Size = New System.Drawing.Size(174, 174)
        Me.PictureBoxImageInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxImageInput.TabIndex = 8
        Me.PictureBoxImageInput.TabStop = False
        '
        'TextBoxAmount
        '
        Me.TextBoxAmount.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxAmount.Location = New System.Drawing.Point(128, 147)
        Me.TextBoxAmount.Name = "TextBoxAmount"
        Me.TextBoxAmount.Size = New System.Drawing.Size(514, 30)
        Me.TextBoxAmount.TabIndex = 7
        '
        'TextBoxPrice
        '
        Me.TextBoxPrice.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxPrice.Location = New System.Drawing.Point(128, 111)
        Me.TextBoxPrice.Name = "TextBoxPrice"
        Me.TextBoxPrice.Size = New System.Drawing.Size(514, 30)
        Me.TextBoxPrice.TabIndex = 6
        '
        'TextBoxName
        '
        Me.TextBoxName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxName.Location = New System.Drawing.Point(128, 75)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(514, 30)
        Me.TextBoxName.TabIndex = 5
        '
        'TextBoxID
        '
        Me.TextBoxID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxID.Location = New System.Drawing.Point(128, 39)
        Me.TextBoxID.Name = "TextBoxID"
        Me.TextBoxID.Size = New System.Drawing.Size(316, 30)
        Me.TextBoxID.TabIndex = 4
        '
        'Amount
        '
        Me.Amount.AutoSize = True
        Me.Amount.Location = New System.Drawing.Point(16, 146)
        Me.Amount.Name = "Amount"
        Me.Amount.Size = New System.Drawing.Size(70, 23)
        Me.Amount.TabIndex = 3
        Me.Amount.Text = "Jumlah"
        '
        'Price
        '
        Me.Price.AutoSize = True
        Me.Price.Location = New System.Drawing.Point(16, 109)
        Me.Price.Name = "Price"
        Me.Price.Size = New System.Drawing.Size(60, 23)
        Me.Price.TabIndex = 2
        Me.Price.Text = "Paket"
        '
        'namaAdmin
        '
        Me.namaAdmin.AutoSize = True
        Me.namaAdmin.Location = New System.Drawing.Point(16, 73)
        Me.namaAdmin.Name = "namaAdmin"
        Me.namaAdmin.Size = New System.Drawing.Size(97, 23)
        Me.namaAdmin.TabIndex = 1
        Me.namaAdmin.Text = "Pelanggan"
        '
        'idAdmin
        '
        Me.idAdmin.AutoSize = True
        Me.idAdmin.Location = New System.Drawing.Point(16, 39)
        Me.idAdmin.Name = "idAdmin"
        Me.idAdmin.Size = New System.Drawing.Size(31, 23)
        Me.idAdmin.TabIndex = 0
        Me.idAdmin.Text = "ID"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteToolStripMenuItem, Me.EditToolStripMenuItem, Me.SelectALLToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(147, 76)
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(146, 24)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(146, 24)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'SelectALLToolStripMenuItem
        '
        Me.SelectALLToolStripMenuItem.Name = "SelectALLToolStripMenuItem"
        Me.SelectALLToolStripMenuItem.Size = New System.Drawing.Size(146, 24)
        Me.SelectALLToolStripMenuItem.Text = "Select ALL"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'FormPembayaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(939, 788)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormPembayaran"
        Me.Text = "FormPembayaran"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBoxImagePreview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBoxImageInput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ButtonClearSelectedandImagePreview As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBoxImagePreview As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ButtonRefresh As Button
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents ButtonEdit As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBoxTotal As TextBox
    Friend WithEvents TextBoxHarga As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ButtonClearALL As Button
    Friend WithEvents ButtonSave As Button
    Friend WithEvents ButtonIDMaker As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBoxImageInput As PictureBox
    Friend WithEvents TextBoxAmount As TextBox
    Friend WithEvents TextBoxPrice As TextBox
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents TextBoxID As TextBox
    Friend WithEvents Amount As Label
    Friend WithEvents Price As Label
    Friend WithEvents namaAdmin As Label
    Friend WithEvents idAdmin As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectALLToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
