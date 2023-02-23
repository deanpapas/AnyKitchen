<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GoodOpen
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
        Me.GoodViewer = New System.Windows.Forms.RichTextBox()
        Me.AddToWishListbtn = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Deletebtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'GoodViewer
        '
        Me.GoodViewer.Location = New System.Drawing.Point(12, 54)
        Me.GoodViewer.Name = "GoodViewer"
        Me.GoodViewer.Size = New System.Drawing.Size(776, 384)
        Me.GoodViewer.TabIndex = 19
        Me.GoodViewer.Text = ""
        '
        'AddToWishListbtn
        '
        Me.AddToWishListbtn.Location = New System.Drawing.Point(108, 12)
        Me.AddToWishListbtn.Name = "AddToWishListbtn"
        Me.AddToWishListbtn.Size = New System.Drawing.Size(75, 23)
        Me.AddToWishListbtn.TabIndex = 17
        Me.AddToWishListbtn.Text = "Add to List"
        Me.AddToWishListbtn.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.Button2.Location = New System.Drawing.Point(715, 6)
        Me.Button2.Margin = New System.Windows.Forms.Padding(0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(40, 45)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "-"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.Button1.Location = New System.Drawing.Point(755, 6)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 45)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "x"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Deletebtn
        '
        Me.Deletebtn.Location = New System.Drawing.Point(12, 12)
        Me.Deletebtn.Name = "Deletebtn"
        Me.Deletebtn.Size = New System.Drawing.Size(90, 23)
        Me.Deletebtn.TabIndex = 20
        Me.Deletebtn.Text = "Delete Product"
        Me.Deletebtn.UseVisualStyleBackColor = True
        '
        'GoodOpen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Deletebtn)
        Me.Controls.Add(Me.GoodViewer)
        Me.Controls.Add(Me.AddToWishListbtn)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "GoodOpen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GoodOpen"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GoodViewer As RichTextBox
    Friend WithEvents AddToWishListbtn As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Deletebtn As Button
End Class
