<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.rb_gerente = New System.Windows.Forms.RadioButton()
        Me.rb_funcionario = New System.Windows.Forms.RadioButton()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.txt_login = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(17, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bem vindo!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(19, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(378, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Por favor, digite seu usuário e senha"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(1314, 611)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(200, 100)
        Me.FlowLayoutPanel1.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SeaShell
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Location = New System.Drawing.Point(24, 235)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(269, 34)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "ENTRAR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'rb_gerente
        '
        Me.rb_gerente.AutoSize = True
        Me.rb_gerente.BackColor = System.Drawing.Color.Transparent
        Me.rb_gerente.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rb_gerente.Location = New System.Drawing.Point(21, 115)
        Me.rb_gerente.Name = "rb_gerente"
        Me.rb_gerente.Size = New System.Drawing.Size(77, 17)
        Me.rb_gerente.TabIndex = 3
        Me.rb_gerente.TabStop = True
        Me.rb_gerente.Text = "GERENTE"
        Me.rb_gerente.UseVisualStyleBackColor = False
        '
        'rb_funcionario
        '
        Me.rb_funcionario.AutoSize = True
        Me.rb_funcionario.BackColor = System.Drawing.Color.Transparent
        Me.rb_funcionario.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rb_funcionario.Location = New System.Drawing.Point(104, 115)
        Me.rb_funcionario.Name = "rb_funcionario"
        Me.rb_funcionario.Size = New System.Drawing.Size(99, 17)
        Me.rb_funcionario.TabIndex = 2
        Me.rb_funcionario.TabStop = True
        Me.rb_funcionario.Text = "FUNCIONARIO"
        Me.rb_funcionario.UseVisualStyleBackColor = False
        '
        'txt_senha
        '
        Me.txt_senha.Location = New System.Drawing.Point(24, 189)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.Size = New System.Drawing.Size(269, 20)
        Me.txt_senha.TabIndex = 1
        Me.txt_senha.Text = "Senha"
        '
        'txt_login
        '
        Me.txt_login.Location = New System.Drawing.Point(24, 152)
        Me.txt_login.Name = "txt_login"
        Me.txt_login.Size = New System.Drawing.Size(269, 20)
        Me.txt_login.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(609, 302)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.rb_gerente)
        Me.Controls.Add(Me.rb_funcionario)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_login)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Button1 As Button
    Friend WithEvents rb_gerente As RadioButton
    Friend WithEvents rb_funcionario As RadioButton
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents txt_login As TextBox
End Class
