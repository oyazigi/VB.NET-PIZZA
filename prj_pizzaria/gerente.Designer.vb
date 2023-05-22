<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class gerente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(gerente))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_cadastro_funcionario = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Gerência"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(17, 52)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(136, 128)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(159, 52)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(293, 25)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Visualizar estoque"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_cadastro_funcionario
        '
        Me.btn_cadastro_funcionario.Location = New System.Drawing.Point(159, 112)
        Me.btn_cadastro_funcionario.Name = "btn_cadastro_funcionario"
        Me.btn_cadastro_funcionario.Size = New System.Drawing.Size(293, 24)
        Me.btn_cadastro_funcionario.TabIndex = 4
        Me.btn_cadastro_funcionario.Text = "Cadastrar funcionários"
        Me.btn_cadastro_funcionario.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(159, 142)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(293, 27)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Visualizar funcioários"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(159, 83)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(293, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Cadastrar estoque"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'gerente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(495, 235)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btn_cadastro_funcionario)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "gerente"
        Me.Text = "gerente"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btn_cadastro_funcionario As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
End Class
