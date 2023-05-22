Module Module1
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public sql, diretorio, permissao, andamento As String
    Public resp As Integer
    Public banco = Application.StartupPath & "\banco_dados\cadastro.mdb"

    Sub conecta_banco()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=microsoft.JET.OLEDB.4.0;Data Source=" & banco)
            MsgBox("Conexão OK")
        Catch ex As Exception
            MsgBox("Erro ao Conectar")
        End Try
    End Sub
    Sub limpar_cadastro()
        'Try
        With cadastro_funcionarios
            .txt_cpf_funcionario.Clear()
            .txt_nome_funcionario.Clear()
            .txt_telefone_funcionario.Clear()
            .img_foto.Load(Application.StartupPath & "\imagens\luffy.png")
            .txt_cpf_funcionario.Focus()
        End With
        'Catch ex As Exception
        'MsgBox("Erro ao limpar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        'End Try
    End Sub

    Sub limpar_campos()
        With cadastrar_pedido
            .txt_celular_cliente.Text = ""
            .txt_nome_cliente.Text = ""
            .txt_observacao_cliente.Text = ""
            .txt_pedido_cliente.Text = ""
            .cb_forma_pgto.Text = ""
            .cb_entregador.Text = ""
            .cb_pedido_cliente.Text = ""
            .lbl_total.Text = 0
        End With
    End Sub

    Sub carregar_valores()
        With cadastrar_pedido
            If .cb_pedido_cliente.Text = "Pizza de Mussarela" Then
                .lbl_total.Text = CInt(.lbl_total.Text) + 30
            End If
            If .cb_pedido_cliente.Text = "Pizza de Pepperoni" Then
                .lbl_total.Text = CInt(.lbl_total.Text) + 45
            End If
            If .cb_pedido_cliente.Text = "Pizza de Calabresa" Then
                .lbl_total.Text = CInt(.lbl_total.Text) + 30
            End If
            If .cb_pedido_cliente.Text = "Pizza de Chocolate" Then
                .lbl_total.Text = CInt(.lbl_total.Text) + 50
            End If
            If .cb_pedido_cliente.Text = "Pizza de Brocolis" Then
                .lbl_total.Text = CInt(.lbl_total.Text) + 40
            End If
            If .cb_pedido_cliente.Text = "Pizza de Portuguesa" Then
                .lbl_total.Text = CInt(.lbl_total.Text) + 35
            End If
            If .cb_pedido_cliente.Text = "Pizza de Lombo" Then
                .lbl_total.Text = CInt(.lbl_total.Text) + 35
            End If
            If .cb_pedido_cliente.Text = "Pizza de Quatro queijos" Then
                .lbl_total.Text = CInt(.lbl_total.Text) + 50
            End If
        End With
    End Sub

    Sub limpar_campos2()
        With cadastro_estoque
            .cb_produto.Text = ""
            .txt_quantidade.Text = ""
            .txt_unitario.Text = ""
            .cb_tipo.Text = ""
        End With
    End Sub
End Module
