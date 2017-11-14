Public Class frm_producto

    Enum respuesta_validacion
        _ok
        _error
    End Enum

    Private dt As New DataTable

    Private Sub frm_producto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub

    Public Sub limpiar()
        btnguardar.Visible = True
        btneditar.Visible = False
        txtnombre.Text = ""
        txtidcategoria.Text = ""
        txtnom_categoria.Text = ""
        txtdesccripcion.Text = ""
        txtstock.Text = ""
        txtprecio_compra.Text = ""
        txtprecio_venta.Text = ""
        txtidcproducto.Text = ""
        txtnombre.Focus()

    End Sub

    Private Sub mostrar()
        Try
            Dim func As New FProductos
            dt = func.mostrar



            If dt.Rows.Count <> 0 Then
                dgv_productos.DataSource = dt
                txtbuscar.Enabled = True
                dgv_productos.ColumnHeadersVisible = True
                inexistente.Visible = False
            Else
                dgv_productos.DataSource = Nothing
                txtbuscar.Enabled = False
                dgv_productos.ColumnHeadersVisible = False
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
                dgv_productos.DataSource = dv
                ocultar_columnas()

            Else
                inexistente.Visible = True
                dgv_productos.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub ocultar_columnas()
        dgv_productos.Columns(0).Visible = False
        dgv_productos.Columns(1).Visible = False
    End Sub



    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        limpiar()
        mostrar()
        txtnombre.Focus()
    End Sub


    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Try
            If validar_datos() = respuesta_validacion._ok Then
                Dim dts As New Vproductos
                Dim func As New FProductos

                dts.gnombre = txtnombre.Text
                dts.gidcategoria = txtidcategoria.Text
                dts.gdescripcion = txtdesccripcion.Text
                dts.gstock = txtstock.Text
                dts.gprecio_compra = txtprecio_compra.Text
                dts.gprecio_venta = txtprecio_venta.Text


                Dim ms As New IO.MemoryStream()


                If func.insertar(dts) Then
                    MessageBox.Show("Producto registrado correctamente", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                Else
                    MessageBox.Show("Producto no fue registrado intente de nuevo", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        If Me.txtnom_categoria.Text = "" Then
            MsgBox("El campo Categoria está vacio, por favor ingrese una Categoria", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
            Me.txtnom_categoria.Focus()
            Return respuesta_validacion._error
        End If
        If Me.txtdesccripcion.Text = "" Then
            MsgBox("El campo Descripción está vacio, por favor ingrese una Descripción", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
            Me.txtdesccripcion.Focus()
            Return respuesta_validacion._error
        End If
        If Me.txtstock.Text = "" Then
            MsgBox("El campo Stock está vacio, por favor ingrese el Stock", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
            Me.txtstock.Focus()
            Return respuesta_validacion._error
        End If
        If Me.txtprecio_compra.Text = "" Then
            MsgBox("El campo Precio de Compra está vacio, por favor ingrese el Precio de compra", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
            Me.txtprecio_compra.Focus()
            Return respuesta_validacion._error
        End If
        If Me.txtprecio_venta.Text = "" Then
            MsgBox("El campo Precio de Venta está vacio, por favor ingrese el Precio de venta", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
            Me.txtprecio_venta.Focus()
            Return respuesta_validacion._error
        End If
        Return respuesta_validacion._ok
    End Function


    Private Sub dgv_productos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_productos.CellClick
        txtidcproducto.Text = dgv_productos.SelectedCells.Item(0).Value
        txtidcategoria.Text = dgv_productos.SelectedCells.Item(1).Value
        txtnom_categoria.Text = dgv_productos.SelectedCells.Item(2).Value
        txtnombre.Text = dgv_productos.SelectedCells.Item(3).Value
        txtdesccripcion.Text = dgv_productos.SelectedCells.Item(4).Value
        txtstock.Text = dgv_productos.SelectedCells.Item(5).Value
        txtprecio_compra.Text = dgv_productos.SelectedCells.Item(6).Value
        txtprecio_venta.Text = dgv_productos.SelectedCells.Item(7).Value


        btneditar.Visible = True
        btnguardar.Visible = False
    End Sub

    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click
        Dim result As DialogResult

        result = MessageBox.Show("Realmente desea editar los datos del producto?", "MOdificando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then

            Try
                Dim dts As New Vproductos
                Dim func As New FProductos

                dts.gidproducto = txtidcproducto.Text
                dts.gnombre = txtnombre.Text
                dts.gidcategoria = txtidcategoria.Text
                dts.gdescripcion = txtdesccripcion.Text
                dts.gstock = txtstock.Text
                dts.gprecio_compra = txtprecio_compra.Text
                dts.gprecio_venta = txtprecio_venta.Text


                If func.editar(dts) Then
                    MessageBox.Show("Producto modificado correctamente", "MOdificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                Else
                    MessageBox.Show("Producto no fue modifcado, intente de nuevo", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    mostrar()
                    limpiar()
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub


    Private Sub btnbuscarcategoria_Click(sender As Object, e As EventArgs) Handles btnbuscarcategoria.Click
        frm_categoria.txtflag.Text = "1"
        frm_categoria.ShowDialog()
    End Sub


    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        buscar()
    End Sub

    Private Sub dgv_productos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_productos.CellContentClick
        'MsgBox("Por favor seleccione toda la columna que desea editar/agregar")
    End Sub

    Private Sub dgv_productos_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_productos.CellContentDoubleClick

    End Sub


    Private Sub dgv_productos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_productos.CellDoubleClick
        If txtflag2.Text = "1" Then
            frm_presupuesto.txt_idproducto.Text = dgv_productos.SelectedCells.Item(0).Value
            frm_presupuesto.txt_producto.Text = dgv_productos.SelectedCells.Item(3).Value
            frm_presupuesto.txt_descripcion.Text = dgv_productos.SelectedCells.Item(4).Value
            frm_presupuesto.txt_precioProducto.Text = dgv_productos.SelectedCells.Item(7).Value
            Me.Close()
        End If

        'If txtflag.Text = "1" Then
        '    frmdetalle_venta.txtidproducto.Text = dgv_productos.SelectedCells.Item(1).Value
        '    frmdetalle_venta.txtnombre_producto.Text = dgv_productos.SelectedCells.Item(4).Value
        '    frmdetalle_venta.txtstock.Text = dgv_productos.SelectedCells.Item(6).Value
        '    frmdetalle_venta.txtprecio_unitario.Text = dgv_productos.SelectedCells.Item(8).Value
        '    Me.Close()

        'End If
    End Sub


    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        If Me.txtnombre.Text <> "" Then
            Dim result As DialogResult

            result = MessageBox.Show("Realmente desea eliminar los productos seleccionados?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

            If result = DialogResult.OK Then
                Try
                    Dim func As New FProductos
                    Dim dts As New Vproductos

                    dts.gidproducto = txtidcproducto.Text

                    If func.eliminar(dts) Then
                        MsgBox("Datos eliminados correctamente")
                        mostrar()
                    Else
                        MsgBox("No se eliminaron los registros")
                    End If

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MessageBox.Show("Cancelando eliminación de registros", "Eliminando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call mostrar()
            End If
        Else
            MsgBox("Por favor seleccione una Cliente a Eliminar!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
        End If

        Call limpiar()
    End Sub

    Private Sub txtflag_TextChanged(sender As Object, e As EventArgs) Handles txtflag.TextChanged

    End Sub

    Private Sub btbcancelar_Click(sender As Object, e As EventArgs) Handles btbcancelar.Click
        Me.Close()
        'If MsgBox("Seguro que desea volver a la pantalla de inicio?", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "Aviso") = 1 Then
        '    End
        'Else

        'End If
    End Sub
End Class