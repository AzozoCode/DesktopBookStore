<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBookID = New System.Windows.Forms.TextBox()
        Me.txtBookName = New System.Windows.Forms.TextBox()
        Me.txtCategory = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.RichTextBox()
        Me.btnADD = New System.Windows.Forms.Button()
        Me.btnUPDATE = New System.Windows.Forms.Button()
        Me.btnDELETE = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.dataGrid = New System.Windows.Forms.DataGridView()
        CType(Me.dataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(53, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Book ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(53, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Book Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(53, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Category"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(53, 193)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Price"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(53, 234)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 25)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Description"
        '
        'txtBookID
        '
        Me.txtBookID.Location = New System.Drawing.Point(195, 69)
        Me.txtBookID.Name = "txtBookID"
        Me.txtBookID.Size = New System.Drawing.Size(184, 23)
        Me.txtBookID.TabIndex = 5
        '
        'txtBookName
        '
        Me.txtBookName.Location = New System.Drawing.Point(195, 115)
        Me.txtBookName.Name = "txtBookName"
        Me.txtBookName.Size = New System.Drawing.Size(184, 23)
        Me.txtBookName.TabIndex = 6
        '
        'txtCategory
        '
        Me.txtCategory.Location = New System.Drawing.Point(195, 159)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Size = New System.Drawing.Size(184, 23)
        Me.txtCategory.TabIndex = 7
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(195, 198)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(184, 23)
        Me.txtPrice.TabIndex = 8
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(195, 239)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(184, 41)
        Me.txtDescription.TabIndex = 9
        Me.txtDescription.Text = ""
        '
        'btnADD
        '
        Me.btnADD.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnADD.Location = New System.Drawing.Point(534, 69)
        Me.btnADD.Name = "btnADD"
        Me.btnADD.Size = New System.Drawing.Size(98, 35)
        Me.btnADD.TabIndex = 10
        Me.btnADD.Text = "ADD"
        Me.btnADD.UseVisualStyleBackColor = True
        '
        'btnUPDATE
        '
        Me.btnUPDATE.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnUPDATE.Location = New System.Drawing.Point(534, 110)
        Me.btnUPDATE.Name = "btnUPDATE"
        Me.btnUPDATE.Size = New System.Drawing.Size(98, 32)
        Me.btnUPDATE.TabIndex = 11
        Me.btnUPDATE.Text = "UPDATE"
        Me.btnUPDATE.UseVisualStyleBackColor = True
        '
        'btnDELETE
        '
        Me.btnDELETE.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnDELETE.Location = New System.Drawing.Point(534, 152)
        Me.btnDELETE.Name = "btnDELETE"
        Me.btnDELETE.Size = New System.Drawing.Size(98, 34)
        Me.btnDELETE.TabIndex = 12
        Me.btnDELETE.Text = "DELETE"
        Me.btnDELETE.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnSearch.Location = New System.Drawing.Point(534, 193)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(98, 36)
        Me.btnSearch.TabIndex = 13
        Me.btnSearch.Text = "SEARCH"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'dataGrid
        '
        Me.dataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGrid.Location = New System.Drawing.Point(53, 286)
        Me.dataGrid.Name = "dataGrid"
        Me.dataGrid.RowTemplate.Height = 25
        Me.dataGrid.Size = New System.Drawing.Size(634, 142)
        Me.dataGrid.TabIndex = 14
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.ClientSize = New System.Drawing.Size(699, 749)
        Me.Controls.Add(Me.dataGrid)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnDELETE)
        Me.Controls.Add(Me.btnUPDATE)
        Me.Controls.Add(Me.btnADD)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtCategory)
        Me.Controls.Add(Me.txtBookName)
        Me.Controls.Add(Me.txtBookID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Dashboard"
        Me.Text = "Dashboard"
        CType(Me.dataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtBookID As TextBox
    Friend WithEvents txtBookName As TextBox
    Friend WithEvents txtCategory As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtDescription As RichTextBox
    Friend WithEvents btnADD As Button
    Friend WithEvents btnUPDATE As Button
    Friend WithEvents btnDELETE As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents dataGrid As DataGridView
End Class
