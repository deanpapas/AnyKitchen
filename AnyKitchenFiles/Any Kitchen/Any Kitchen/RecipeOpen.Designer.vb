<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RecipeOpen
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SaveEditRecipebtn = New System.Windows.Forms.Button()
        Me.EditRecipebtn = New System.Windows.Forms.Button()
        Me.AddToListbtn = New System.Windows.Forms.Button()
        Me.Deletebtn = New System.Windows.Forms.Button()
        Me.RecipeViewer = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.Button2.Location = New System.Drawing.Point(721, -1)
        Me.Button2.Margin = New System.Windows.Forms.Padding(0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(40, 45)
        Me.Button2.TabIndex = 4
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
        Me.Button1.Location = New System.Drawing.Point(761, -1)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 45)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "x"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SaveEditRecipebtn
        '
        Me.SaveEditRecipebtn.Location = New System.Drawing.Point(713, 415)
        Me.SaveEditRecipebtn.Name = "SaveEditRecipebtn"
        Me.SaveEditRecipebtn.Size = New System.Drawing.Size(75, 23)
        Me.SaveEditRecipebtn.TabIndex = 6
        Me.SaveEditRecipebtn.Text = "Save Edit"
        Me.SaveEditRecipebtn.UseVisualStyleBackColor = True
        '
        'EditRecipebtn
        '
        Me.EditRecipebtn.Location = New System.Drawing.Point(632, 415)
        Me.EditRecipebtn.Name = "EditRecipebtn"
        Me.EditRecipebtn.Size = New System.Drawing.Size(75, 23)
        Me.EditRecipebtn.TabIndex = 7
        Me.EditRecipebtn.Text = "Toggle Edit"
        Me.EditRecipebtn.UseVisualStyleBackColor = True
        '
        'AddToListbtn
        '
        Me.AddToListbtn.Location = New System.Drawing.Point(12, 415)
        Me.AddToListbtn.Name = "AddToListbtn"
        Me.AddToListbtn.Size = New System.Drawing.Size(75, 23)
        Me.AddToListbtn.TabIndex = 8
        Me.AddToListbtn.Text = "Add to List"
        Me.AddToListbtn.UseVisualStyleBackColor = True
        '
        'Deletebtn
        '
        Me.Deletebtn.Location = New System.Drawing.Point(12, 12)
        Me.Deletebtn.Name = "Deletebtn"
        Me.Deletebtn.Size = New System.Drawing.Size(85, 23)
        Me.Deletebtn.TabIndex = 9
        Me.Deletebtn.Text = "Delete Recipe"
        Me.Deletebtn.UseVisualStyleBackColor = True
        '
        'RecipeViewer
        '
        Me.RecipeViewer.Location = New System.Drawing.Point(12, 47)
        Me.RecipeViewer.Name = "RecipeViewer"
        Me.RecipeViewer.Size = New System.Drawing.Size(776, 362)
        Me.RecipeViewer.TabIndex = 12
        Me.RecipeViewer.Text = ""
        '
        'RecipeOpen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.RecipeViewer)
        Me.Controls.Add(Me.Deletebtn)
        Me.Controls.Add(Me.AddToListbtn)
        Me.Controls.Add(Me.EditRecipebtn)
        Me.Controls.Add(Me.SaveEditRecipebtn)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RecipeOpen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RecipeOpen"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents SaveEditRecipebtn As Button
    Friend WithEvents EditRecipebtn As Button
    Friend WithEvents AddToListbtn As Button
    Friend WithEvents Deletebtn As Button
    Friend WithEvents RecipeViewer As RichTextBox
End Class
