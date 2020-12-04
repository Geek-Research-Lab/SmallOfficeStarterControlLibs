<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EnquiriesList
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.EnquiriesList_Label = New System.Windows.Forms.Label()
        Me.EnquiriesList_Close = New System.Windows.Forms.Button()
        Me.EnquiriesList_Search_Button = New System.Windows.Forms.Button()
        Me.EnquiriesList_Search = New System.Windows.Forms.TextBox()
        Me.EnquiriesList_Body = New System.Windows.Forms.WebBrowser()
        Me.SuspendLayout()
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
        Me.EnquiriesList_Close.Location = New System.Drawing.Point(269, 394)
        Me.EnquiriesList_Close.Name = "EnquiriesList_Close"
        Me.EnquiriesList_Close.Size = New System.Drawing.Size(111, 36)
        Me.EnquiriesList_Close.TabIndex = 2
        Me.EnquiriesList_Close.Text = "Close"
        Me.EnquiriesList_Close.UseVisualStyleBackColor = False
        '
        'EnquiriesList_Search_Button
        '
        Me.EnquiriesList_Search_Button.Location = New System.Drawing.Point(521, 57)
        Me.EnquiriesList_Search_Button.Name = "EnquiriesList_Search_Button"
        Me.EnquiriesList_Search_Button.Size = New System.Drawing.Size(119, 23)
        Me.EnquiriesList_Search_Button.TabIndex = 9
        Me.EnquiriesList_Search_Button.Text = "Search"
        Me.EnquiriesList_Search_Button.UseVisualStyleBackColor = True
        '
        'EnquiriesList_Search
        '
        Me.EnquiriesList_Search.Location = New System.Drawing.Point(24, 58)
        Me.EnquiriesList_Search.Name = "EnquiriesList_Search"
        Me.EnquiriesList_Search.Size = New System.Drawing.Size(472, 22)
        Me.EnquiriesList_Search.TabIndex = 8
        '
        'EnquiriesList_Body
        '
        Me.EnquiriesList_Body.Location = New System.Drawing.Point(29, 110)
        Me.EnquiriesList_Body.MinimumSize = New System.Drawing.Size(20, 20)
        Me.EnquiriesList_Body.Name = "EnquiriesList_Body"
        Me.EnquiriesList_Body.Size = New System.Drawing.Size(611, 250)
        Me.EnquiriesList_Body.TabIndex = 10
        '
        'EnquiriesList
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(664, 441)
        Me.ControlBox = False
        Me.Controls.Add(Me.EnquiriesList_Body)
        Me.Controls.Add(Me.EnquiriesList_Search_Button)
        Me.Controls.Add(Me.EnquiriesList_Search)
        Me.Controls.Add(Me.EnquiriesList_Close)
        Me.Controls.Add(Me.EnquiriesList_Label)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "EnquiriesList"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EnquiriesList_Label As Label
    Friend WithEvents EnquiriesList_Close As Button
    Friend WithEvents EnquiriesList_Search_Button As Button
    Friend WithEvents EnquiriesList_Search As TextBox
    Friend WithEvents EnquiriesList_Body As WebBrowser
End Class
