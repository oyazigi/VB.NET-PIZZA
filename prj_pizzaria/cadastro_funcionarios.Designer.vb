<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cadastro_funcionarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cadastro_funcionarios))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_nome_funcionario = New System.Windows.Forms.TextBox()
        Me.txt_cpf_funcionario = New System.Windows.Forms.MaskedTextBox()
        Me.txt_telefone_funcionario = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_registrar_funcionario = New System.Windows.Forms.Button()
        Me.btn_fechar_cadastro_funcionario = New System.Windows.Forms.Button()
        Me.img_foto = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.txt_login = New System.Windows.Forms.TextBox()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.lbl_login = New System.Windows.Forms.Label()
        Me.lbl_senha = New System.Windows.Forms.Label()
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nome do funcionário"
        '
        'txt_nome_funcionario
        '
        Me.txt_nome_funcionario.Location = New System.Drawing.Point(15, 41)
        Me.txt_nome_funcionario.Name = "txt_nome_funcionario"
        Me.txt_nome_funcionario.Size = New System.Drawing.Size(159, 20)
        Me.txt_nome_funcionario.TabIndex = 1
        '
        'txt_cpf_funcionario
        '
        Me.txt_cpf_funcionario.Location = New System.Drawing.Point(15, 124)
        Me.txt_cpf_funcionario.Mask = "999,999,999-99"
        Me.txt_cpf_funcionario.Name = "txt_cpf_funcionario"
        Me.txt_cpf_funcionario.Size = New System.Drawing.Size(159, 20)
        Me.txt_cpf_funcionario.TabIndex = 2
        '
        'txt_telefone_funcionario
        '
        Me.txt_telefone_funcionario.Location = New System.Drawing.Point(15, 163)
        Me.txt_telefone_funcionario.Mask = "(99) 99999-9999"
        Me.txt_telefone_funcionario.Name = "txt_telefone_funcionario"
        Me.txt_telefone_funcionario.Size = New System.Drawing.Size(159, 20)
        Me.txt_telefone_funcionario.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "CPF do funcionário"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Telefone do funcionário"
        '
        'btn_registrar_funcionario
        '
        Me.btn_registrar_funcionario.Location = New System.Drawing.Point(12, 189)
        Me.btn_registrar_funcionario.Name = "btn_registrar_funcionario"
        Me.btn_registrar_funcionario.Size = New System.Drawing.Size(75, 23)
        Me.btn_registrar_funcionario.TabIndex = 6
        Me.btn_registrar_funcionario.Text = "Registrar"
        Me.btn_registrar_funcionario.UseVisualStyleBackColor = True
        '
        'btn_fechar_cadastro_funcionario
        '
        Me.btn_fechar_cadastro_funcionario.Location = New System.Drawing.Point(93, 189)
        Me.btn_fechar_cadastro_funcionario.Name = "btn_fechar_cadastro_funcionario"
        Me.btn_fechar_cadastro_funcionario.Size = New System.Drawing.Size(75, 23)
        Me.btn_fechar_cadastro_funcionario.TabIndex = 7
        Me.btn_fechar_cadastro_funcionario.Text = "Fechar"
        Me.btn_fechar_cadastro_funcionario.UseVisualStyleBackColor = True
        '
        'img_foto
        '
        Me.img_foto.Image = CType(resources.GetObject("img_foto.Image"), System.Drawing.Image)
        Me.img_foto.InitialImage = Nothing
        Me.img_foto.Location = New System.Drawing.Point(206, 27)
        Me.img_foto.Name = "img_foto"
        Me.img_foto.Size = New System.Drawing.Size(177, 156)
        Me.img_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_foto.TabIndex = 8
        Me.img_foto.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Função do funcionario"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Atendente", "Motoboy"})
        Me.ComboBox1.Location = New System.Drawing.Point(15, 84)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(156, 21)
        Me.ComboBox1.TabIndex = 10
        '
        'txt_login
        '
        Me.txt_login.Location = New System.Drawing.Point(283, 191)
        Me.txt_login.Name = "txt_login"
        Me.txt_login.Size = New System.Drawing.Size(100, 20)
        Me.txt_login.TabIndex = 11
        Me.txt_login.Visible = False
        '
        'txt_senha
        '
        Me.txt_senha.Location = New System.Drawing.Point(283, 217)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.Size = New System.Drawing.Size(100, 20)
        Me.txt_senha.TabIndex = 12
        Me.txt_senha.Visible = False
        '
        'lbl_login
        '
        Me.lbl_login.AutoSize = True
        Me.lbl_login.Location = New System.Drawing.Point(185, 194)
        Me.lbl_login.Name = "lbl_login"
        Me.lbl_login.Size = New System.Drawing.Size(87, 13)
        Me.lbl_login.TabIndex = 13
        Me.lbl_login.Text = "Login atendente:"
        Me.lbl_login.Visible = False
        '
        'lbl_senha
        '
        Me.lbl_senha.AutoSize = True
        Me.lbl_senha.Location = New System.Drawing.Point(185, 220)
        Me.lbl_senha.Name = "lbl_senha"
        Me.lbl_senha.Size = New System.Drawing.Size(92, 13)
        Me.lbl_senha.TabIndex = 14
        Me.lbl_senha.Text = "Senha atendente:"
        Me.lbl_senha.Visible = False
        '
        'cadastro_funcionarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(450, 261)
        Me.Controls.Add(Me.lbl_senha)
        Me.Controls.Add(Me.lbl_login)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.txt_login)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.img_foto)
        Me.Controls.Add(Me.btn_fechar_cadastro_funcionario)
        Me.Controls.Add(Me.btn_registrar_funcionario)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_telefone_funcionario)
        Me.Controls.Add(Me.txt_cpf_funcionario)
        Me.Controls.Add(Me.txt_nome_funcionario)
        Me.Controls.Add(Me.Label1)
        Me.Name = "cadastro_funcionarios"
        Me.Text = "cadastro_funcionarios"
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_nome_funcionario As TextBox
    Friend WithEvents txt_cpf_funcionario As MaskedTextBox
    Friend WithEvents txt_telefone_funcionario As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_registrar_funcionario As Button
    Friend WithEvents btn_fechar_cadastro_funcionario As Button
    Friend WithEvents img_foto As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents txt_login As TextBox
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents lbl_login As Label
    Friend WithEvents lbl_senha As Label
End Class
