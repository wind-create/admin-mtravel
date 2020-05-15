<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormWisata
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
        Me.ButtonClearALL = New System.Windows.Forms.Button()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonIDMaker = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBoxImageInput = New System.Windows.Forms.PictureBox()
        Me.TextBoxPrice = New System.Windows.Forms.TextBox()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.TextBoxID = New System.Windows.Forms.TextBox()
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
        Me.GroupBox2.Location = New System.Drawing.Point(36, 541)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1021, 361)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Record Review"
        '
        'ButtonClearSelectedandImagePreview
        '
        Me.ButtonClearSelectedandImagePreview.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonClearSelectedandImagePreview.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClearSelectedandImagePreview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonClearSelectedandImagePreview.Location = New System.Drawing.Point(827, 286)
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
        Me.Label8.Location = New System.Drawing.Point(856, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(124, 23)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Image review"
        '
        'PictureBoxImagePreview
        '
        Me.PictureBoxImagePreview.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxImagePreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBoxImagePreview.Location = New System.Drawing.Point(832, 106)
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
        Me.DataGridView1.Size = New System.Drawing.Size(732, 218)
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
        Me.GroupBox1.Controls.Add(Me.ButtonClearALL)
        Me.GroupBox1.Controls.Add(Me.ButtonSave)
        Me.GroupBox1.Controls.Add(Me.ButtonIDMaker)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.PictureBoxImageInput)
        Me.GroupBox1.Controls.Add(Me.TextBoxPrice)
        Me.GroupBox1.Controls.Add(Me.TextBoxName)
        Me.GroupBox1.Controls.Add(Me.TextBoxID)
        Me.GroupBox1.Controls.Add(Me.Price)
        Me.GroupBox1.Controls.Add(Me.namaAdmin)
        Me.GroupBox1.Controls.Add(Me.idAdmin)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(33, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1039, 485)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input dan Update"
        '
        'ButtonClearALL
        '
        Me.ButtonClearALL.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonClearALL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonClearALL.Location = New System.Drawing.Point(586, 418)
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
        Me.ButtonSave.Location = New System.Drawing.Point(20, 418)
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
        Me.ButtonIDMaker.Location = New System.Drawing.Point(600, 39)
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
        Me.Label1.Location = New System.Drawing.Point(776, 39)
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
        Me.PictureBoxImageInput.Location = New System.Drawing.Point(850, 39)
        Me.PictureBoxImageInput.Name = "PictureBoxImageInput"
        Me.PictureBoxImageInput.Size = New System.Drawing.Size(174, 174)
        Me.PictureBoxImageInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxImageInput.TabIndex = 8
        Me.PictureBoxImageInput.TabStop = False
        '
        'TextBoxPrice
        '
        Me.TextBoxPrice.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxPrice.Location = New System.Drawing.Point(128, 111)
        Me.TextBoxPrice.Multiline = True
        Me.TextBoxPrice.Name = "TextBoxPrice"
        Me.TextBoxPrice.Size = New System.Drawing.Size(638, 301)
        Me.TextBoxPrice.TabIndex = 6
        '
        'TextBoxName
        '
        Me.TextBoxName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxName.Location = New System.Drawing.Point(128, 75)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(638, 30)
        Me.TextBoxName.TabIndex = 5
        '
        'TextBoxID
        '
        Me.TextBoxID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxID.Location = New System.Drawing.Point(128, 39)
        Me.TextBoxID.Name = "TextBoxID"
        Me.TextBoxID.Size = New System.Drawing.Size(440, 30)
        Me.TextBoxID.TabIndex = 4
        '
        'Price
        '
        Me.Price.AutoSize = True
        Me.Price.Location = New System.Drawing.Point(16, 109)
        Me.Price.Name = "Price"
        Me.Price.Size = New System.Drawing.Size(89, 23)
        Me.Price.TabIndex = 2
        Me.Price.Text = "Deskripsi"
        '
        'namaAdmin
        '
        Me.namaAdmin.AutoSize = True
        Me.namaAdmin.Location = New System.Drawing.Point(16, 73)
        Me.namaAdmin.Name = "namaAdmin"
        Me.namaAdmin.Size = New System.Drawing.Size(59, 23)
        Me.namaAdmin.TabIndex = 1
        Me.namaAdmin.Text = "Nama"
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
        'FormWisata
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1107, 914)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormWisata"
        Me.Text = "FormWisata"
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
    Friend WithEvents ButtonClearALL As Button
    Friend WithEvents ButtonSave As Button
    Friend WithEvents ButtonIDMaker As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBoxImageInput As PictureBox
    Friend WithEvents TextBoxPrice As TextBox
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents TextBoxID As TextBox
    Friend WithEvents Price As Label
    Friend WithEvents namaAdmin As Label
    Friend WithEvents idAdmin As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectALLToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
