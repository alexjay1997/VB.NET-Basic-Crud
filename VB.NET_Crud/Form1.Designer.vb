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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox_username = New System.Windows.Forms.TextBox()
        Me.TextBox_password = New System.Windows.Forms.TextBox()
        Me.TextBox_email = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button_Add_emp = New System.Windows.Forms.Button()
        Me.Button_Edit_Emp = New System.Windows.Forms.Button()
        Me.Button_Update_Emp = New System.Windows.Forms.Button()
        Me.Button_Delete_Emp = New System.Windows.Forms.Button()
        Me.Button_Clear = New System.Windows.Forms.Button()
        Me.label_emp_id = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(18, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(19, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(19, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Label3"
        '
        'TextBox_username
        '
        Me.TextBox_username.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_username.Location = New System.Drawing.Point(116, 64)
        Me.TextBox_username.Name = "TextBox_username"
        Me.TextBox_username.Size = New System.Drawing.Size(176, 26)
        Me.TextBox_username.TabIndex = 3
        '
        'TextBox_password
        '
        Me.TextBox_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_password.Location = New System.Drawing.Point(117, 96)
        Me.TextBox_password.Name = "TextBox_password"
        Me.TextBox_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox_password.Size = New System.Drawing.Size(175, 26)
        Me.TextBox_password.TabIndex = 4
        '
        'TextBox_email
        '
        Me.TextBox_email.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_email.Location = New System.Drawing.Point(117, 128)
        Me.TextBox_email.Name = "TextBox_email"
        Me.TextBox_email.Size = New System.Drawing.Size(175, 26)
        Me.TextBox_email.TabIndex = 5
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.Color.White
        Me.DataGridView1.Location = New System.Drawing.Point(362, 78)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(399, 247)
        Me.DataGridView1.TabIndex = 6
        '
        'Button_Add_emp
        '
        Me.Button_Add_emp.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Button_Add_emp.FlatAppearance.BorderSize = 0
        Me.Button_Add_emp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Add_emp.ForeColor = System.Drawing.Color.White
        Me.Button_Add_emp.Location = New System.Drawing.Point(52, 161)
        Me.Button_Add_emp.Name = "Button_Add_emp"
        Me.Button_Add_emp.Size = New System.Drawing.Size(78, 34)
        Me.Button_Add_emp.TabIndex = 7
        Me.Button_Add_emp.Text = "ADD"
        Me.Button_Add_emp.UseVisualStyleBackColor = False
        '
        'Button_Edit_Emp
        '
        Me.Button_Edit_Emp.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Button_Edit_Emp.FlatAppearance.BorderSize = 0
        Me.Button_Edit_Emp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Edit_Emp.ForeColor = System.Drawing.Color.White
        Me.Button_Edit_Emp.Location = New System.Drawing.Point(135, 161)
        Me.Button_Edit_Emp.Name = "Button_Edit_Emp"
        Me.Button_Edit_Emp.Size = New System.Drawing.Size(77, 34)
        Me.Button_Edit_Emp.TabIndex = 8
        Me.Button_Edit_Emp.Text = "EDIT"
        Me.Button_Edit_Emp.UseVisualStyleBackColor = False
        '
        'Button_Update_Emp
        '
        Me.Button_Update_Emp.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Button_Update_Emp.FlatAppearance.BorderSize = 0
        Me.Button_Update_Emp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Update_Emp.ForeColor = System.Drawing.Color.White
        Me.Button_Update_Emp.Location = New System.Drawing.Point(217, 161)
        Me.Button_Update_Emp.Name = "Button_Update_Emp"
        Me.Button_Update_Emp.Size = New System.Drawing.Size(75, 34)
        Me.Button_Update_Emp.TabIndex = 9
        Me.Button_Update_Emp.Text = "UPDATE"
        Me.Button_Update_Emp.UseVisualStyleBackColor = False
        '
        'Button_Delete_Emp
        '
        Me.Button_Delete_Emp.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button_Delete_Emp.FlatAppearance.BorderSize = 0
        Me.Button_Delete_Emp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Delete_Emp.ForeColor = System.Drawing.Color.White
        Me.Button_Delete_Emp.Location = New System.Drawing.Point(52, 201)
        Me.Button_Delete_Emp.Name = "Button_Delete_Emp"
        Me.Button_Delete_Emp.Size = New System.Drawing.Size(78, 35)
        Me.Button_Delete_Emp.TabIndex = 10
        Me.Button_Delete_Emp.Text = "DELETE"
        Me.Button_Delete_Emp.UseVisualStyleBackColor = False
        '
        'Button_Clear
        '
        Me.Button_Clear.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Button_Clear.FlatAppearance.BorderSize = 0
        Me.Button_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Clear.ForeColor = System.Drawing.Color.White
        Me.Button_Clear.Location = New System.Drawing.Point(135, 201)
        Me.Button_Clear.Name = "Button_Clear"
        Me.Button_Clear.Size = New System.Drawing.Size(157, 36)
        Me.Button_Clear.TabIndex = 11
        Me.Button_Clear.Text = "CLEAR"
        Me.Button_Clear.UseVisualStyleBackColor = False
        '
        'label_emp_id
        '
        Me.label_emp_id.AutoSize = True
        Me.label_emp_id.BackColor = System.Drawing.Color.Transparent
        Me.label_emp_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_emp_id.ForeColor = System.Drawing.Color.White
        Me.label_emp_id.Location = New System.Drawing.Point(138, 32)
        Me.label_emp_id.Name = "label_emp_id"
        Me.label_emp_id.Size = New System.Drawing.Size(83, 20)
        Me.label_emp_id.TabIndex = 12
        Me.label_emp_id.Text = "Employee "
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TextBox_username)
        Me.GroupBox1.Controls.Add(Me.label_emp_id)
        Me.GroupBox1.Controls.Add(Me.TextBox_password)
        Me.GroupBox1.Controls.Add(Me.Button_Clear)
        Me.GroupBox1.Controls.Add(Me.TextBox_email)
        Me.GroupBox1.Controls.Add(Me.Button_Delete_Emp)
        Me.GroupBox1.Controls.Add(Me.Button_Update_Emp)
        Me.GroupBox1.Controls.Add(Me.Button_Add_emp)
        Me.GroupBox1.Controls.Add(Me.Button_Edit_Emp)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(16, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(334, 260)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add Employee"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Cambria", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(304, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(225, 32)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Basic Registration"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox_username As TextBox
    Friend WithEvents TextBox_password As TextBox
    Friend WithEvents TextBox_email As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button_Add_emp As Button
    Friend WithEvents Button_Edit_Emp As Button
    Friend WithEvents Button_Update_Emp As Button
    Friend WithEvents Button_Delete_Emp As Button
    Friend WithEvents Button_Clear As Button
    Friend WithEvents label_emp_id As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
End Class
