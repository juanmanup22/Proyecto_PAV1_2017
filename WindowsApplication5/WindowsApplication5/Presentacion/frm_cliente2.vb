Public Class frm_cliente2

    Enum respuesta_validacion
        _ok
        _error
    End Enum

    Private dt As New DataTable

    Private Sub frm_cliente2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub

    Public Sub limpiar()
        btnguardar.Visible = True
        btneditar.Visible = False
        txtnombre.Text = ""
        txtapellidos.Text = ""
        txtdireccion.Text = ""
        txt_num_direccion.Text = ""
        txttelefono.Text = ""
        txtdni.Text = ""
        txtidcliente.Text = ""
    End Sub

    Private Sub mostrar()
        Try
            Dim func As New FClientes
            dt = func.mostrar


            If dt.Rows.Count <> 0 Then
                dgv_clientes.DataSource = dt
                txtbuscar.Enabled = True
                dgv_clientes.ColumnHeadersVisible = True
                inexistente.Visible = False
            Else
                dgv_clientes.DataSource = Nothing
                txtbuscar.Enabled = False
                dgv_clientes.ColumnHeadersVisible = False
                inexistente.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        btnnuevo.Visible = True
        btneditar.Visible = False

        buscar()
    End Sub

    Private Sub buscar()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))


            dv.RowFilter = cbocampo.Text & " like '" & txtbuscar.Text & "%'"

            If dv.Count <> 0 Then
                inexistente.Visible = False
                dgv_clientes.DataSource = dv
                ocultar_columnas()

            Else
                inexistente.Visible = True
                dgv_clientes.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub ocultar_columnas()
        dgv_clientes.Columns(0).Visible = False
    End Sub


    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        limpiar()
        mostrar()
        txtnombre.Focus()
    End Sub


    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Try
            If validar_datos() = respuesta_validacion._ok Then
                Dim dts As New Vclientes2
                Dim func As New FClientes

                dts.gnombres = txtnombre.Text
                dts.gapellidos = txtapellidos.Text
                dts.gdireccion = txtdireccion.Text
                dts.gnumdireccion = txt_num_direccion.Text
                dts.gtelefono = txttelefono.Text
                dts.gdni = txtdni.Text


                If func.insertar(dts) Then
                    MessageBox.Show("Cliente registrado correctamente", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                Else
                    MessageBox.Show("Cliente no fue registrado intente de nuevo", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    mostrar()
                    limpiar()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function validar_datos() As respuesta_validacion
        'Valida que los datos requeridos esten ingresados
        If Me.txtnombre.Text = "" Then
            MsgBox("El campo Nombre está vacio, por favor ingrese un Nombre", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
            Me.txtnombre.Focus()
            Return respuesta_validacion._error
        End If
        If Me.txtapellidos.Text = "" Then
            MsgBox("El campo Apellido está vacio, por favor ingrese un Apellido", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
            Me.txtapellidos.Focus()
            Return respuesta_validacion._error
        End If
        If Me.txtdni.Text = "" Then
            MsgBox("El campo DNI está vacio, Por favor ingrese un DNI", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
            Me.txtdni.Focus()
            Return respuesta_validacion._error
        End If
        If Me.txttelefono.Text = "" Then
            MsgBox("El campo Teléfono está vacio, por favor ingrese un Teléfono", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
            Me.txttelefono.Focus()
            Return respuesta_validacion._error
        End If
        If Me.txtdireccion.Text = "" Then
            MsgBox("El campo Dirección está vacio, por favor ingrese una dirección", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
            Me.txtdireccion.Focus()
            Return respuesta_validacion._error
        End If
        If Me.txt_num_direccion.Text = "" Then
            MsgBox("El campo Número de Direccion está vacio, por favor ingrese el Número de dirección", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
            Me.txt_num_direccion.Focus()
            Return respuesta_validacion._error
        End If
        Return respuesta_validacion._ok
    End Function


    Private Sub dgv_clientes_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_clientes.CellClick
        txtidcliente.Text = dgv_clientes.SelectedCells.Item(0).Value
        txtnombre.Text = dgv_clientes.SelectedCells.Item(1).Value
        txtapellidos.Text = dgv_clientes.SelectedCells.Item(2).Value
        txtdireccion.Text = dgv_clientes.SelectedCells.Item(3).Value
        txt_num_direccion.Text = dgv_clientes.SelectedCells.Item(4).Value
        txttelefono.Text = dgv_clientes.SelectedCells.Item(5).Value
        txtdni.Text = dgv_clientes.SelectedCells.Item(6).Value
        btneditar.Visible = True
        btnguardar.Visible = False
    End Sub




    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click
        Dim result As DialogResult

        result = MessageBox.Show("Realmente desea editar los datos del cliente?", "Modificando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            Try
                Dim dts As New Vclientes2
                Dim func As New FClientes

                dts.gidcliente = txtidcliente.Text
                dts.gnombres = txtnombre.Text
                dts.gapellidos = txtapellidos.Text
                dts.gdireccion = txtdireccion.Text
                dts.gnumdireccion = txt_num_direccion.Text
                dts.gtelefono = txttelefono.Text
                dts.gdni = txtdni.Text


                If func.editar(dts) Then
                    MessageBox.Show("Cliente Modificado correctamente", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                Else
                    MessageBox.Show("Cliente no fue modifcado intente de nuevo", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    mostrar()
                    limpiar()
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub


    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        If Me.txtnombre.Text <> "" Then
            Dim result As DialogResult

            result = MessageBox.Show("Realmente desea Eliminar los datos del cliente?", "Modificando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

            If result = DialogResult.OK Then
                Try
                    Dim func As New FClientes
                    Dim dts As New Vclientes2

                    dts.gidcliente = txtidcliente.Text

                    If func.eliminar(dts) Then
                        MsgBox("Datos eliminados correctamente")
                        mostrar()
                    Else
                        MsgBox("No se eliminaron los registros")
                    End If

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                Call limpiar()
            End If
        Else
            MsgBox("Por favor seleccione una Cliente a Eliminar!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
        End If
    End Sub


    Private Sub dgv_clientes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_clientes.CellDoubleClick
        If txtflag.Text = "1" Then
            frm_presupuesto.txtidcliente.Text = dgv_clientes.SelectedCells.Item(0).Value
            frm_presupuesto.txtnombre_cliente.Text = dgv_clientes.SelectedCells.Item(1).Value
            frm_presupuesto.txt_apellidoCliente.Text = dgv_clientes.SelectedCells.Item(2).Value
            frm_presupuesto.txt_Doc_cliente.Text = dgv_clientes.SelectedCells.Item(6).Value
            Me.Close()
        End If
    End Sub

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        buscar()
    End Sub

    Private Sub txtdireccion_TextChanged(sender As Object, e As EventArgs) Handles txtdireccion.TextChanged, txt_num_direccion.TextChanged

    End Sub

    Private Sub btbcancelar_Click(sender As Object, e As EventArgs) Handles btbcancelar.Click
        Me.Close()
        'If MsgBox("Seguro que desea volver a la pantalla de inicio?", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "Aviso") = 1 Then
        '    End
        'Else

        'End If
    End Sub
End Class