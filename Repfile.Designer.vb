<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Repfile
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
        Me.txtfile = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtfile
        '
        Me.txtfile.Location = New System.Drawing.Point(15, 13)
        Me.txtfile.Multiline = True
        Me.txtfile.Name = "txtfile"
        Me.txtfile.Size = New System.Drawing.Size(657, 414)
        Me.txtfile.TabIndex = 0
        '
        'Repfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 444)
        Me.Controls.Add(Me.txtfile)
        Me.Name = "Repfile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Repfile"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtfile As TextBox
End Class
