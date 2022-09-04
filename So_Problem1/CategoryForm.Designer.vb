<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CategoryForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dbCategory = New System.Windows.Forms.DataGridView()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.bttnClose = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        CType(Me.dbCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dbCategory
        '
        Me.dbCategory.AllowUserToAddRows = False
        Me.dbCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dbCategory.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dbCategory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dbCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dbCategory.Location = New System.Drawing.Point(26, 184)
        Me.dbCategory.Margin = New System.Windows.Forms.Padding(2)
        Me.dbCategory.Name = "dbCategory"
        Me.dbCategory.RowHeadersWidth = 51
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.dbCategory.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dbCategory.RowTemplate.Height = 24
        Me.dbCategory.Size = New System.Drawing.Size(309, 177)
        Me.dbCategory.TabIndex = 0
        '
        'txtSearch
        '
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSearch.Font = New System.Drawing.Font("MV Boli", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(100, 154)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSearch.Multiline = True
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(235, 25)
        Me.txtSearch.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(21, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(213, 25)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Point of Sale System"
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
        Me.bttnClose.Location = New System.Drawing.Point(323, 6)
        Me.bttnClose.Margin = New System.Windows.Forms.Padding(2)
        Me.bttnClose.Name = "bttnClose"
        Me.bttnClose.Size = New System.Drawing.Size(28, 32)
        Me.bttnClose.TabIndex = 25
        Me.bttnClose.Text = "x"
        Me.bttnClose.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Tomato
        Me.Button2.Enabled = False
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.Location = New System.Drawing.Point(26, 154)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(74, 25)
        Me.Button2.TabIndex = 27
        Me.Button2.Text = "Search"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnHome
        '
        Me.btnHome.BackColor = System.Drawing.Color.Gray
        Me.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed
        Me.btnHome.FlatAppearance.BorderSize = 0
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnHome.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnHome.Location = New System.Drawing.Point(85, 0)
        Me.btnHome.Margin = New System.Windows.Forms.Padding(2)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(81, 35)
        Me.btnHome.TabIndex = 29
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = False
        '
        'btnMenu
        '
        Me.btnMenu.BackColor = System.Drawing.Color.Salmon
        Me.btnMenu.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed
        Me.btnMenu.FlatAppearance.BorderSize = 0
        Me.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnMenu.Location = New System.Drawing.Point(166, 0)
        Me.btnMenu.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(138, 35)
        Me.btnMenu.TabIndex = 28
        Me.btnMenu.Text = "Go to Menu"
        Me.btnMenu.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(21, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 25)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Category"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Tomato
        Me.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAdd.Location = New System.Drawing.Point(250, 108)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(85, 32)
        Me.btnAdd.TabIndex = 31
        Me.btnAdd.Text = "Add New"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'CategoryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Firebrick
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(360, 419)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.bttnClose)
        Me.Controls.Add(Me.dbCategory)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtSearch)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "CategoryForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Category"
        CType(Me.dbCategory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dbCategory As DataGridView
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents bttnClose As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents btnMenu As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents btnAdd As Button
End Class
