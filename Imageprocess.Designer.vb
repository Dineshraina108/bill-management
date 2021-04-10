<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Imageprocess
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
        Me.Imagebox = New System.Windows.Forms.PictureBox()
        Me.btnupload = New System.Windows.Forms.Button()
        Me.ODimg = New System.Windows.Forms.OpenFileDialog()
        CType(Me.Imagebox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Imagebox
        '
        Me.Imagebox.Location = New System.Drawing.Point(51, 136)
        Me.Imagebox.Name = "Imagebox"
        Me.Imagebox.Size = New System.Drawing.Size(284, 158)
        Me.Imagebox.TabIndex = 0
        Me.Imagebox.TabStop = False
        '
        'btnupload
        '
        Me.btnupload.Location = New System.Drawing.Point(135, 87)
        Me.btnupload.Name = "btnupload"
        Me.btnupload.Size = New System.Drawing.Size(75, 23)
        Me.btnupload.TabIndex = 1
        Me.btnupload.Text = "UPLOAD"
        Me.btnupload.UseVisualStyleBackColor = True
        '
        'ODimg
        '
        Me.ODimg.FileName = "Select a image "
        '
        'Imageprocess
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(367, 342)
        Me.Controls.Add(Me.btnupload)
        Me.Controls.Add(Me.Imagebox)
        Me.Name = "Imageprocess"
        Me.Text = "Imageprocess"
        CType(Me.Imagebox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Imagebox As PictureBox
    Friend WithEvents btnupload As Button
    Friend WithEvents ODimg As OpenFileDialog
End Class
