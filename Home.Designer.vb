<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.lbldescription = New System.Windows.Forms.Label()
        Me.btnstart = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitle.ForeColor = System.Drawing.Color.ForestGreen
        Me.lbltitle.Location = New System.Drawing.Point(100, 29)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(497, 37)
        Me.lbltitle.TabIndex = 0
        Me.lbltitle.Text = "E-BILL MANAGEMENT SYSTEM"
        '
        'lbldescription
        '
        Me.lbldescription.AutoSize = True
        Me.lbldescription.Font = New System.Drawing.Font("Harlow Solid Italic", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldescription.Location = New System.Drawing.Point(244, 122)
        Me.lbldescription.Name = "lbldescription"
        Me.lbldescription.Size = New System.Drawing.Size(180, 34)
        Me.lbldescription.TabIndex = 1
        Me.lbldescription.Text = "Easy to Access"
        '
        'btnstart
        '
        Me.btnstart.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btnstart.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnstart.Location = New System.Drawing.Point(272, 230)
        Me.btnstart.Name = "btnstart"
        Me.btnstart.Size = New System.Drawing.Size(106, 40)
        Me.btnstart.TabIndex = 2
        Me.btnstart.Text = "Ready to Start"
        Me.btnstart.UseVisualStyleBackColor = False
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(691, 341)
        Me.Controls.Add(Me.btnstart)
        Me.Controls.Add(Me.lbldescription)
        Me.Controls.Add(Me.lbltitle)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbltitle As Label
    Friend WithEvents lbldescription As Label
    Friend WithEvents btnstart As Button
End Class
