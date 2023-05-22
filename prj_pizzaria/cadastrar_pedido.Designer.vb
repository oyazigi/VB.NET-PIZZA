<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cadastrar_pedido
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cadastrar_pedido))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_celular_cliente = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_nome_cliente = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cb_pedido_cliente = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_observacao_cliente = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cb_entregador = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cb_forma_pgto = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_pedido_cliente = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(297, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Digite os dados do pedido"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(270, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Celular do cliente"
        '
        'txt_celular_cliente
        '
        Me.txt_celular_cliente.Location = New System.Drawing.Point(270, 96)
        Me.txt_celular_cliente.Mask = "(99) 00000-0000"
        Me.txt_celular_cliente.Name = "txt_celular_cliente"
        Me.txt_celular_cliente.Size = New System.Drawing.Size(238, 20)
        Me.txt_celular_cliente.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(270, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nome do cliente"
        '
        'txt_nome_cliente
        '
        Me.txt_nome_cliente.Location = New System.Drawing.Point(270, 57)
        Me.txt_nome_cliente.Name = "txt_nome_cliente"
        Me.txt_nome_cliente.Size = New System.Drawing.Size(238, 20)
        Me.txt_nome_cliente.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(270, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Pedido"
        '
        'cb_pedido_cliente
        '
        Me.cb_pedido_cliente.FormattingEnabled = True
        Me.cb_pedido_cliente.Items.AddRange(New Object() {"Mussarela", "Calabresa", "Pepperoni", "Chocolate", "Brocolis", "Portuguesa", "Lombo", "Quatro queijos"})
        Me.cb_pedido_cliente.Location = New System.Drawing.Point(270, 135)
        Me.cb_pedido_cliente.Name = "cb_pedido_cliente"
        Me.cb_pedido_cliente.Size = New System.Drawing.Size(238, 21)
        Me.cb_pedido_cliente.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(267, 198)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Observaçao"
        '
        'txt_observacao_cliente
        '
        Me.txt_observacao_cliente.Location = New System.Drawing.Point(268, 214)
        Me.txt_observacao_cliente.Name = "txt_observacao_cliente"
        Me.txt_observacao_cliente.Size = New System.Drawing.Size(238, 20)
        Me.txt_observacao_cliente.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(267, 237)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Entregador"
        '
        'cb_entregador
        '
        Me.cb_entregador.AutoCompleteCustomSource.AddRange(New String() {"Victor", "Sabrina", "Janaina"})
        Me.cb_entregador.FormattingEnabled = True
        Me.cb_entregador.Items.AddRange(New Object() {"Entregador1", "Entregador2"})
        Me.cb_entregador.Location = New System.Drawing.Point(268, 253)
        Me.cb_entregador.Name = "cb_entregador"
        Me.cb_entregador.Size = New System.Drawing.Size(235, 21)
        Me.cb_entregador.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(268, 277)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Forma de pagamento"
        '
        'cb_forma_pgto
        '
        Me.cb_forma_pgto.AutoCompleteCustomSource.AddRange(New String() {"Credito", "Debito", "Pix", "Dinheiro"})
        Me.cb_forma_pgto.FormattingEnabled = True
        Me.cb_forma_pgto.Items.AddRange(New Object() {"Credito", "Debito", "Pix", "Dinheiro"})
        Me.cb_forma_pgto.Location = New System.Drawing.Point(268, 293)
        Me.cb_forma_pgto.Name = "cb_forma_pgto"
        Me.cb_forma_pgto.Size = New System.Drawing.Size(235, 21)
        Me.cb_forma_pgto.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(270, 317)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Total:"
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Location = New System.Drawing.Point(310, 317)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(13, 13)
        Me.lbl_total.TabIndex = 14
        Me.lbl_total.Text = "0"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(12, 41)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(250, 289)
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(514, 135)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 37)
        Me.Button1.TabIndex = 16
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txt_pedido_cliente
        '
        Me.txt_pedido_cliente.Location = New System.Drawing.Point(268, 175)
        Me.txt_pedido_cliente.Name = "txt_pedido_cliente"
        Me.txt_pedido_cliente.ReadOnly = True
        Me.txt_pedido_cliente.Size = New System.Drawing.Size(235, 20)
        Me.txt_pedido_cliente.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(267, 159)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Pedido final"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(268, 333)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(83, 23)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "Completar pedido"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(357, 333)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(69, 23)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "Limpar pedido"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(432, 333)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(71, 23)
        Me.Button4.TabIndex = 21
        Me.Button4.Text = "Cancelar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'cadastrar_pedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(653, 375)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_pedido_cliente)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cb_forma_pgto)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cb_entregador)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_observacao_cliente)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cb_pedido_cliente)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_nome_cliente)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_celular_cliente)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "cadastrar_pedido"
        Me.Text = "cadastrar_pedido"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_celular_cliente As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_nome_cliente As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cb_pedido_cliente As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_observacao_cliente As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cb_entregador As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cb_forma_pgto As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents lbl_total As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txt_pedido_cliente As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
