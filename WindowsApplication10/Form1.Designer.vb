<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.OpenImageForm = New System.Windows.Forms.OpenFileDialog()
        Me.openButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'OpenImageForm
        '
        Me.OpenImageForm.FileName = "OpenFileDialog1"
        '
        'openButton
        '
        Me.openButton.Location = New System.Drawing.Point(12, 12)
        Me.openButton.Name = "openButton"
        Me.openButton.Size = New System.Drawing.Size(134, 43)
        Me.openButton.TabIndex = 0
        Me.openButton.Text = "open image ico"
        Me.openButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 139)
        Me.Controls.Add(Me.openButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OpenImageForm As System.Windows.Forms.OpenFileDialog
    Friend WithEvents openButton As System.Windows.Forms.Button

End Class
