<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRegister
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
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
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBoxImageInput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.GroupBox1.Controls.Add(Me.TextBoxAmount)
        Me.GroupBox1.Controls.Add(Me.TextBoxPrice)
        Me.GroupBox1.Controls.Add(Me.TextBoxName)
        Me.GroupBox1.Controls.Add(Me.TextBoxID)
        Me.GroupBox1.Controls.Add(Me.Amount)
        Me.GroupBox1.Controls.Add(Me.Price)
        Me.GroupBox1.Controls.Add(Me.namaAdmin)
        Me.GroupBox1.Controls.Add(Me.idAdmin)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(55, 130)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(762, 265)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input dan Update"
        '
        'ButtonClearALL
        '
        Me.ButtonClearALL.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonClearALL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonClearALL.Location = New System.Drawing.Point(323, 211)
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
        Me.ButtonSave.Location = New System.Drawing.Point(20, 211)
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
        Me.ButtonIDMaker.Location = New System.Drawing.Point(323, 39)
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
        Me.Label1.Location = New System.Drawing.Point(499, 39)
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
        Me.PictureBoxImageInput.Location = New System.Drawing.Point(573, 39)
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
        Me.TextBoxAmount.Size = New System.Drawing.Size(361, 30)
        Me.TextBoxAmount.TabIndex = 7
        '
        'TextBoxPrice
        '
        Me.TextBoxPrice.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxPrice.Location = New System.Drawing.Point(128, 111)
        Me.TextBoxPrice.Name = "TextBoxPrice"
        Me.TextBoxPrice.Size = New System.Drawing.Size(361, 30)
        Me.TextBoxPrice.TabIndex = 6
        '
        'TextBoxName
        '
        Me.TextBoxName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxName.Location = New System.Drawing.Point(128, 75)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(361, 30)
        Me.TextBoxName.TabIndex = 5
        '
        'TextBoxID
        '
        Me.TextBoxID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxID.Location = New System.Drawing.Point(128, 39)
        Me.TextBoxID.Name = "TextBoxID"
        Me.TextBoxID.Size = New System.Drawing.Size(163, 30)
        Me.TextBoxID.TabIndex = 4
        '
        'Amount
        '
        Me.Amount.AutoSize = True
        Me.Amount.Location = New System.Drawing.Point(16, 146)
        Me.Amount.Name = "Amount"
        Me.Amount.Size = New System.Drawing.Size(76, 23)
        Me.Amount.TabIndex = 3
        Me.Amount.Text = "Telepon"
        '
        'Price
        '
        Me.Price.AutoSize = True
        Me.Price.Location = New System.Drawing.Point(16, 109)
        Me.Price.Name = "Price"
        Me.Price.Size = New System.Drawing.Size(71, 23)
        Me.Price.TabIndex = 2
        Me.Price.Text = "Alamat"
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
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'FormRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(872, 525)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormRegister"
        Me.Text = "FormRegister"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBoxImageInput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
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
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
