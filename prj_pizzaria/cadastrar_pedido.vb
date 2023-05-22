
Public Class cadastrar_pedido
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txt_pedido_cliente.Text = txt_pedido_cliente.Text + cb_pedido_cliente.Text + " "
        carregar_valores()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        limpar_campos()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        andamento = "Não"
        txt_pedido_cliente.Text = txt_pedido_cliente.Text.Remove(txt_pedido_cliente.Text.Length - 1)
        sql = "insert into tb_pedidos VALUES ('" & txt_nome_cliente.Text & " ', '" & txt_celular_cliente.Text & "', '" & txt_pedido_cliente.Text & "','" & txt_observacao_cliente.Text & "','" & cb_entregador.Text & "','" & cb_forma_pgto.Text & "','" & lbl_total.Text & "','" & DateAndTime.Today & "' ,'" & CStr(TimeOfDay.Hour) + ":" + CStr(TimeOfDay.Minute) & "','" & andamento & "')"
        rs = db.Execute(UCase(sql))
        limpar_campos()
        MsgBox("Pedido feito com sucesso")

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        resp = MsgBox("Deseja fechar a aplicação?", vbQuestion + vbYesNo + vbOKOnly, "Atenção")
        If resp = vbYes Then
            Me.Close()
        End If
    End Sub
End Class