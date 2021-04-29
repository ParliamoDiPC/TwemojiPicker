<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.PreviewImage = New System.Windows.Forms.PictureBox()
        Me.UnicodeInput = New System.Windows.Forms.TextBox()
        Me.PreviewButton = New System.Windows.Forms.Button()
        Me.DownloadButton = New System.Windows.Forms.Button()
        Me.UnicodeError = New System.Windows.Forms.Label()
        Me.FormatList = New System.Windows.Forms.ComboBox()
        Me.DownloadFolder = New System.Windows.Forms.FolderBrowserDialog()
        Me.BlobPicker = New System.Windows.Forms.LinkLabel()
        Me.GitHub = New System.Windows.Forms.LinkLabel()
        CType(Me.PreviewImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PreviewImage
        '
        Me.PreviewImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PreviewImage.Location = New System.Drawing.Point(22, 19)
        Me.PreviewImage.Name = "PreviewImage"
        Me.PreviewImage.Size = New System.Drawing.Size(72, 72)
        Me.PreviewImage.TabIndex = 0
        Me.PreviewImage.TabStop = False
        '
        'UnicodeInput
        '
        Me.UnicodeInput.Location = New System.Drawing.Point(121, 25)
        Me.UnicodeInput.Name = "UnicodeInput"
        Me.UnicodeInput.Size = New System.Drawing.Size(336, 23)
        Me.UnicodeInput.TabIndex = 3
        '
        'PreviewButton
        '
        Me.PreviewButton.Location = New System.Drawing.Point(121, 63)
        Me.PreviewButton.Name = "PreviewButton"
        Me.PreviewButton.Size = New System.Drawing.Size(75, 23)
        Me.PreviewButton.TabIndex = 2
        Me.PreviewButton.Text = "Preview"
        Me.PreviewButton.UseVisualStyleBackColor = True
        '
        'DownloadButton
        '
        Me.DownloadButton.Location = New System.Drawing.Point(212, 63)
        Me.DownloadButton.Name = "DownloadButton"
        Me.DownloadButton.Size = New System.Drawing.Size(75, 23)
        Me.DownloadButton.TabIndex = 1
        Me.DownloadButton.Text = "Download"
        Me.DownloadButton.UseVisualStyleBackColor = True
        '
        'UnicodeError
        '
        Me.UnicodeError.AutoSize = True
        Me.UnicodeError.ForeColor = System.Drawing.Color.Red
        Me.UnicodeError.Location = New System.Drawing.Point(387, 92)
        Me.UnicodeError.Name = "UnicodeError"
        Me.UnicodeError.Size = New System.Drawing.Size(89, 15)
        Me.UnicodeError.TabIndex = 4
        Me.UnicodeError.Text = "Invalid Unicode"
        Me.UnicodeError.Visible = False
        '
        'FormatList
        '
        Me.FormatList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FormatList.FormattingEnabled = True
        Me.FormatList.Items.AddRange(New Object() {"SVG", "PNG (72 pixels)"})
        Me.FormatList.Location = New System.Drawing.Point(336, 63)
        Me.FormatList.Name = "FormatList"
        Me.FormatList.Size = New System.Drawing.Size(121, 23)
        Me.FormatList.TabIndex = 5
        '
        'DownloadFolder
        '
        Me.DownloadFolder.Description = "Where do you want to save this emoji?"
        '
        'BlobPicker
        '
        Me.BlobPicker.AutoSize = True
        Me.BlobPicker.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.BlobPicker.Location = New System.Drawing.Point(2, 96)
        Me.BlobPicker.Name = "BlobPicker"
        Me.BlobPicker.Size = New System.Drawing.Size(144, 15)
        Me.BlobPicker.TabIndex = 6
        Me.BlobPicker.TabStop = True
        Me.BlobPicker.Text = "Check out BlobPicker too!"
        '
        'GitHub
        '
        Me.GitHub.AutoSize = True
        Me.GitHub.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GitHub.Location = New System.Drawing.Point(145, 96)
        Me.GitHub.Name = "GitHub"
        Me.GitHub.Size = New System.Drawing.Size(120, 15)
        Me.GitHub.TabIndex = 7
        Me.GitHub.TabStop = True
        Me.GitHub.Text = "GitHub and legal info"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(484, 114)
        Me.Controls.Add(Me.GitHub)
        Me.Controls.Add(Me.BlobPicker)
        Me.Controls.Add(Me.FormatList)
        Me.Controls.Add(Me.UnicodeError)
        Me.Controls.Add(Me.DownloadButton)
        Me.Controls.Add(Me.PreviewButton)
        Me.Controls.Add(Me.UnicodeInput)
        Me.Controls.Add(Me.PreviewImage)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.ShowIcon = False
        Me.Text = "Twemoji Picker"
        CType(Me.PreviewImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PreviewImage As PictureBox
    Friend WithEvents UnicodeInput As TextBox
    Friend WithEvents PreviewButton As Button
    Friend WithEvents DownloadButton As Button
    Friend WithEvents UnicodeError As Label
    Friend WithEvents FormatList As ComboBox
    Friend WithEvents DownloadFolder As FolderBrowserDialog
    Friend WithEvents BlobPicker As LinkLabel
    Friend WithEvents GitHub As LinkLabel
End Class
