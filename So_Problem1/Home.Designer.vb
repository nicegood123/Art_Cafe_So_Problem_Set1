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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.btnCategory = New System.Windows.Forms.Button()
        Me.bttnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Colonna MT", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(137, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(373, 43)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Art Cafe Restaurant"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(222, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(193, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Point of Sale System"
        '
        'btnMenu
        '
        Me.btnMenu.BackColor = System.Drawing.Color.Tomato
        Me.btnMenu.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed
        Me.btnMenu.FlatAppearance.BorderSize = 0
        Me.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenu.Font = New System.Drawing.Font("Berlin Sans FB", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnMenu.Location = New System.Drawing.Point(91, 186)
        Me.btnMenu.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(223, 134)
        Me.btnMenu.TabIndex = 17
        Me.btnMenu.Text = "Menu"
        Me.btnMenu.UseVisualStyleBackColor = False
        '
        'btnCategory
        '
        Me.btnCategory.BackColor = System.Drawing.Color.Tomato
        Me.btnCategory.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed
        Me.btnCategory.FlatAppearance.BorderSize = 0
        Me.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCategory.Font = New System.Drawing.Font("Berlin Sans FB", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCategory.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCategory.Location = New System.Drawing.Point(327, 186)
        Me.btnCategory.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCategory.Name = "btnCategory"
        Me.btnCategory.Size = New System.Drawing.Size(223, 134)
        Me.btnCategory.TabIndex = 18
        Me.btnCategory.Text = "Category"
        Me.btnCategory.UseVisualStyleBackColor = False
        '
        'bttnClose
        '
        Me.bttnClose.BackColor = System.Drawing.Color.Transparent
        Me.bttnClose.FlatAppearance.BorderSize = 0
        Me.bttnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.bttnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.bttnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttnClose.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnClose.ForeColor = System.Drawing.Color.White
        Me.bttnClose.Location = New System.Drawing.Point(612, 2)
        Me.bttnClose.Margin = New System.Windows.Forms.Padding(2)
        Me.bttnClose.Name = "bttnClose"
        Me.bttnClose.Size = New System.Drawing.Size(28, 32)
        Me.bttnClose.TabIndex = 19
        Me.bttnClose.Text = "x"
        Me.bttnClose.UseVisualStyleBackColor = False
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Firebrick
        Me.ClientSize = New System.Drawing.Size(647, 378)
        Me.Controls.Add(Me.bttnClose)
        Me.Controls.Add(Me.btnCategory)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnMenu As Button
    Friend WithEvents btnCategory As Button
    Friend WithEvents bttnClose As Button
End Class
