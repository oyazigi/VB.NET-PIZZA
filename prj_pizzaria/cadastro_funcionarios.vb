Public Class cadastro_funcionarios
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles img_foto.Click
        Try
            With OpenFileDialog1
                .InitialDirectory = Application.StartupPath & "\imagens\"
                .Title = "SELECIONE UMA FOTO"
                .ShowDialog()
                diretorio = .FileName
                img_foto.Load(diretorio)
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub btn_registrar_funcionario_Click(sender As Object, e As EventArgs) Handles btn_registrar_funcionario.Click
        If ComboBox1.Text = "Motoboy" Then
            Try
                sql = "insert into tb_cadastro_motoboy values ('" & txt_cpf_funcionario.Text & "', '" & txt_nome_funcionario.Text & "'," &
                                                      "'" & txt_telefone_funcionario.Text & "' , '" & diretorio & "')"
                rs = db.Execute(sql)
                MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                limpar_cadastro()
            Catch ex As Exception
                MsgBox("Erro ao gravar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            End Try
        End If

        If ComboBox1.Text = "Atendente" Then
            sql = "insert into tb_cadastro_pizzaria values ('" & txt_nome_funcionario.Text & "', 'Funcionario', '" & txt_cpf_funcionario.Text & "' , '" & txt_telefone_funcionario.Text & "' , '" & txt_login.Text & "', '" & txt_senha.Text & "')"
            rs = db.Execute(sql)
            MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            limpar_cadastro()
        End If
    End Sub

    Private Sub btn_fechar_cadastro_funcionario_Click(sender As Object, e As EventArgs) Handles btn_fechar_cadastro_funcionario.Click
        resp = MsgBox("Deseja fechar a aplicação?", vbQuestion + vbYesNo + vbOKOnly, "Atenção")
        If resp = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Atendente" Then
            lbl_login.Visible = True
            lbl_senha.Visible = True
            txt_login.Visible = True
            txt_senha.Visible = True
        End If
        If ComboBox1.Text = "Motoboy" Then
            lbl_login.Visible = False
            lbl_senha.Visible = False
            txt_login.Visible = False
            txt_senha.Visible = False
        End If
    End Sub
End Class