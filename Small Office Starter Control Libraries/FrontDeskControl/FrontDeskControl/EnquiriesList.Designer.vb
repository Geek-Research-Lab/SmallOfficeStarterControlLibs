<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EnquiriesList
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
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.EnquiriesList_Label = New System.Windows.Forms.Label()
        Me.EnquiriesList_Close = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(24, 56)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(616, 289)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'EnquiriesList_Label
        '
        Me.EnquiriesList_Label.AutoSize = True
        Me.EnquiriesList_Label.Location = New System.Drawing.Point(21, 18)
        Me.EnquiriesList_Label.Name = "EnquiriesList_Label"
        Me.EnquiriesList_Label.Size = New System.Drawing.Size(93, 17)
        Me.EnquiriesList_Label.TabIndex = 1
        Me.EnquiriesList_Label.Text = "Enquiries List"
        '
        'EnquiriesList_Close
        '
        Me.EnquiriesList_Close.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.EnquiriesList_Close.Location = New System.Drawing.Point(269, 351)
        Me.EnquiriesList_Close.Name = "EnquiriesList_Close"
        Me.EnquiriesList_Close.Size = New System.Drawing.Size(111, 36)
        Me.EnquiriesList_Close.TabIndex = 2
        Me.EnquiriesList_Close.Text = "Close"
        Me.EnquiriesList_Close.UseVisualStyleBackColor = False
        '
        'EnquiriesList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(664, 399)
        Me.Controls.Add(Me.EnquiriesList_Close)
        Me.Controls.Add(Me.EnquiriesList_Label)
        Me.Controls.Add(Me.RichTextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "EnquiriesList"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents EnquiriesList_Label As Label
    Friend WithEvents EnquiriesList_Close As Button
End Class
