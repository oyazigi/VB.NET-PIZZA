Public Class cadastro_estoque
    Private Sub btn_adicionar_Click(sender As Object, e As EventArgs) Handles btn_adicionar.Click
        sql = "insert into tb_estoque VALUES ('" & cb_produto.Text & " ','" & cb_tipo.Text & "' , '" & txt_quantidade.Text & "', '" & txt_unitario.Text & "')"
        rs = db.Execute(UCase(sql))
        limpar_campos2()
        MsgBox("Pedido feito com sucesso")
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        resp = MsgBox("Deseja fechar a aplicação?", vbQuestion + vbYesNo + vbOKOnly, "Atenção")
        If resp = vbYes Then
            Me.Close()
        End If
    End Sub
End Class