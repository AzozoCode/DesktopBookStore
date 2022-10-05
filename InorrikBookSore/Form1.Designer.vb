<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbUserType = New System.Windows.Forms.ComboBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Historic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Aqua
        Me.Label1.Location = New System.Drawing.Point(165, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(501, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "WELCOME TO INNORIK BOOK STORE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Aqua
        Me.Label2.Location = New System.Drawing.Point(255, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(313, 30)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "LOGIN TO ACCESS BOOK STORE"
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(314, 183)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(200, 23)
        Me.txtUserName.TabIndex = 2
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(314, 241)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(200, 23)
        Me.txtPassword.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(180, 181)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 21)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Enter User Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(180, 241)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 21)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Enter Password:"
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.Indigo
        Me.btnSubmit.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSubmit.ForeColor = System.Drawing.Color.White
        Me.btnSubmit.Location = New System.Drawing.Point(314, 331)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 30)
        Me.btnSubmit.TabIndex = 6
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(158, 280)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 21)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Select User Type"
        '
        'cmbUserType
        '
        Me.cmbUserType.FormattingEnabled = True
        Me.cmbUserType.Items.AddRange(New Object() {"Admin", "User"})
        Me.cmbUserType.Location = New System.Drawing.Point(314, 285)
        Me.cmbUserType.Name = "cmbUserType"
        Me.cmbUserType.Size = New System.Drawing.Size(200, 23)
        Me.cmbUserType.TabIndex = 8
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Indigo
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(439, 331)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 30)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Close"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tomato
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.cmbUserType)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbUserType As ComboBox
    Friend WithEvents btnExit As Button
End Class
