Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco()
        rb_gerente.Focus()
    End Sub

    Private Sub txt_login_TextChanged(sender As Object, e As EventArgs) Handles txt_login.TextChanged

    End Sub

    Private Sub txt_login_GotFocus(sender As Object, e As EventArgs) Handles txt_login.GotFocus
        If txt_login.Text = "Login" Then
            txt_login.Text = ""
        End If
    End Sub

    Private Sub txt_senha_TextChanged(sender As Object, e As EventArgs) Handles txt_senha.TextChanged

    End Sub

    Private Sub txt_senha_GotFocus(sender As Object, e As EventArgs) Handles txt_senha.GotFocus
        If txt_senha.Text = "Senha" Then
            txt_senha.Text = ""
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If rb_funcionario.Checked Then
            permissao = "Funcionario"
        ElseIf rb_gerente.Checked Then
            permissao = "Gerente"
        End If
        sql = "select * from tb_cadastro_pizzaria where (Login = '" & txt_login.Text & "' AND Senha = '" & txt_senha.Text & "' AND Permissao = '" & permissao & "')"
        rs = db.Execute(sql)
        If rs.EOF = False Then
            If rb_gerente.Checked Then
                gerente.ShowDialog()
            ElseIf rb_funcionario.Checked Then
                funcionario.ShowDialog()
            End If
        Else
            MsgBox("Usuario ou senha inválidos")
        End If

    End Sub

    Private Sub rb_gerente_CheckedChanged(sender As Object, e As EventArgs) Handles rb_gerente.CheckedChanged


    End Sub

    Private Sub rb_funcionario_CheckedChanged(sender As Object, e As EventArgs) Handles rb_funcionario.CheckedChanged


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub rb_gerente_Click(sender As Object, e As EventArgs) Handles rb_gerente.Click
        rb_funcionario.Checked = False
    End Sub

    Private Sub rb_funcionario_Click(sender As Object, e As EventArgs) Handles rb_funcionario.Click
        rb_gerente.Checked = False
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
