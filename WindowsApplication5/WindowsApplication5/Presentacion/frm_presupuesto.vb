Public Class frm_presupuesto

    Dim cont As Integer = 1

    Enum respuesta_validacion
        _ok
        _error
    End Enum

    Dim acc As New _acceso_datos With {._cadena = "Data Source=SUPERNOVA;Initial Catalog=dbventas;Integrated Security=True"}

    Private Sub cmd_agregarProductos_Click(sender As Object, e As EventArgs) Handles btn_agregarProductos.Click
        If msk_cantidad.Text <> "" Then
            Dim total As Double = 0
            If grid_productos.Rows.Count = 0 Then
                total = Convert.ToDouble(Me.txt_precioProducto.Text) _
                * Convert.ToDouble(Me.msk_cantidad.Text)

                Me.grid_productos.Rows.Add(Me.txt_idproducto.Text, Me.txt_producto.Text, Me.msk_cantidad.Text, total)


                For Each row As DataGridViewRow In grid_productos.Rows
                    txt_total.Text = Convert.ToDouble(row.Cells("Subtotal").Value)
                Next
                'txt_total.Text = total
                'Exit Sub
            Else
                For i = 0 To grid_productos.Rows.Count - 1
                    If txt_idproducto.Text = Me.grid_productos.Rows(i).Cells(0).Value Then
                        MsgBox("No se puede agregar el mismo articulo dos veces")
                        Exit Sub
                    End If
                Next
                total = Convert.ToDouble(Me.txt_precioProducto.Text) * Convert.ToDouble(Me.msk_cantidad.Text)

                Me.grid_productos.Rows.Add(Me.txt_idproducto.Text, Me.txt_producto.Text, Me.msk_cantidad.Text, Convert.ToDouble(total))
                Me.msk_cantidad.Clear()

                txt_total.Text = Convert.ToDouble(txt_total.Text) + total
            End If
        Else
            MsgBox("Por favor, ingrese una cantidad!")
        End If

        txt_idproducto.Text = ""
        txt_producto.Text = ""
        txt_descripcion.Text = ""
        txt_precioProducto.Text = ""
        msk_cantidad.Text = ""




        'Dim total As Double = 0
        'If grid_productos.Rows.Count = 0 Then
        '    total = Convert.ToDouble(Me.txt_precioProducto.Text) _
        '    * Convert.ToDouble(Me.msk_cantidad.Text)

        '    Me.grid_productos.Rows.Add(Me.txt_idproducto.Text, Me.txt_producto.Text, Me.msk_cantidad.Text, total)


        '    For Each row As DataGridViewRow In grid_productos.Rows
        '        txt_total.Text = Convert.ToDouble(row.Cells("Subtotal").Value)
        '    Next
        '    'txt_total.Text = total
        '    'Exit Sub
        'Else
        '    For i = 0 To grid_productos.Rows.Count - 1
        '        If txt_idproducto.Text = Me.grid_productos.Rows(i).Cells(0).Value Then
        '            MsgBox("No se puede agregar el mismo articulo dos veces")
        '            Exit Sub
        '        End If
        '    Next
        '    total = Convert.ToDouble(Me.txt_precioProducto.Text) * Convert.ToDouble(Me.msk_cantidad.Text)

        '    Me.grid_productos.Rows.Add(Me.txt_idproducto.Text, Me.txt_producto.Text, Me.msk_cantidad.Text, Convert.ToDouble(total))
        '    Me.msk_cantidad.Clear()

        '    txt_total.Text = Convert.ToDouble(txt_total.Text) + total
        'End If
    End Sub

    Private Sub CargarCombo(ByRef combo As ComboBox, ByRef datos As Data.DataTable, ByVal pk As String, ByVal descripcion As String)
        'combo.Items.Clear()
        combo.DataSource = datos
        combo.ValueMember = pk
        combo.DisplayMember = descripcion

    End Sub

    Private Sub cargar_combo(ByRef combo As ComboBox, ByRef tabla As DataTable, ByVal pk As String, _
                             ByVal descriptor As String)
        combo.DataSource = tabla
        combo.DisplayMember = descriptor
        combo.ValueMember = pk
    End Sub

    Private Sub frm_presupuesto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'CargarCombo(cmb_productos, Fconexion.GetProductos(), "idproducto", "nombre")
        Label1.Visible = False
        txt_nro_presupuesto.Visible = False
        txtFecha.Text = Date.Today
        'Me.cargar_combo(cmb_productos, acc._ejectuar_sql("SELECT * FROM producto"), "idproducto", "descripcion")
        'Me.btn_agregarProductos.Enabled = True
    End Sub

    Private Sub btnbuscar_cliente_Click(sender As Object, e As EventArgs) Handles btnbuscar_cliente.Click
        frm_cliente2.txtflag.Text = "1"
        frm_cliente2.ShowDialog()
    End Sub

    Private Sub txtidcliente_TextChanged(sender As Object, e As EventArgs) Handles txtidcliente.TextChanged

    End Sub

    Private Sub cmd_grabar_Click(sender As Object, e As EventArgs) Handles cmd_grabar.Click
        If validar_datos() = respuesta_validacion._ok Then
            'Dim insertar_presupuesto As String = ""
            'insertar_presupuesto &= "nro_presupuesto = " & txt_nro_presupuesto.Text & ";" & _
            '                    "id_cliente = " & txtidcliente.Text & ";" & _
            '                    "fecha = " & Convert.ToDateTime(txtFecha.Text) & " ; " & _
            '                    "total =" & txt_total.Text.ToString.Replace(",", ".")
            Dim dts As New Vpresupuesto
            Dim func As New FPresupuesto

            dts.gidcliente = txtidcliente.Text
            dts.gnom_cliente = txtnombre_cliente.Text
            dts.gape_cliente = txt_apellidoCliente.Text
            dts.gfecha = DateTimePicker1.Text
            dts.gtotal = txt_total.Text

            func.insertar(dts)


            Me.acc.iniciar_conexion_con_transaccion()
            'Me.acc._nombre_tabla = "presupuesto"
            'Me.acc._insertar(insertar_presupuesto)


            Dim insertar_detalle As String = ""
            Me.acc._nombre_tabla = "detalle_presupuesto"

            For c = 0 To grid_productos.Rows.Count - 1
                insertar_detalle = ""
                insertar_detalle &= "idproducto =" & grid_productos.Rows(c).Cells(0).Value & " ; " & _
                                    "cantidad = " & grid_productos.Rows(c).Cells(2).Value.ToString.Replace(",", ".") & " ; " & _
                                    "precio_sub = " & grid_productos.Rows(c).Cells(3).Value
                Me.acc._insertar(insertar_detalle)
            Next

            Me.acc.cerrar_conexion_con_transaccion()

            limpiar()
        End If
    End Sub

    Private Function validar_datos() As respuesta_validacion
        'Valida que los datos requeridos esten ingresados
        If Me.txtnombre_cliente.Text = "" Then
            MsgBox("No hay Cliente seleccionado, por favor ingrese un Cliente", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
            Me.btnbuscar_cliente.Focus()
            Return respuesta_validacion._error
        End If
        If Me.txtFecha.Text = "" Then
            MsgBox("No hay fecha ingresada, por favor ingrese una fecha", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
            Me.txtFecha.Focus()
            Return respuesta_validacion._error
        End If
        Return respuesta_validacion._ok
    End Function

    Private Sub cmb_productos_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txt_cantidad_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_buscar_producto_Click(sender As Object, e As EventArgs) Handles btn_buscar_producto.Click
        frm_producto.txtflag2.Text = "1"
        frm_producto.ShowDialog()
        If txt_producto.Text <> "" Then
            btn_agregarProductos.Enabled = True
        End If
    End Sub

    Private Sub grid_productos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid_productos.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MsgBox("Seguro que desea salir del formulario?", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "Aviso") = 1 Then
            End
        Else

        End If
    End Sub

    Private Sub cmd_nuevo_Click(sender As Object, e As EventArgs) Handles cmd_nuevo.Click
        txtidcliente.Text = ""
        txtnombre_cliente.Text = ""
        txt_apellidoCliente.Text = ""
        txt_Doc_cliente.Text = ""

        txt_idproducto.Text = ""
        txt_producto.Text = ""
        txt_descripcion.Text = ""
        txt_precioProducto.Text = ""
        msk_cantidad.Text = ""

        txt_total.Text = ""

        txtFecha.Text = Date.Today

        cont = cont + 1

        txt_nro_presupuesto.Text = cont

        grid_productos.Rows.Clear()
    End Sub

    Public Sub limpiar()
        txtidcliente.Text = ""
        txtnombre_cliente.Text = ""
        txt_apellidoCliente.Text = ""
        txt_Doc_cliente.Text = ""

        txt_idproducto.Text = ""
        txt_producto.Text = ""
        txt_descripcion.Text = ""
        txt_precioProducto.Text = ""
        msk_cantidad.Text = ""

        txt_total.Text = ""

        txtFecha.Text = Date.Today


        grid_productos.Rows.Clear()
    End Sub

    Private Sub txtFecha_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txtFecha.MaskInputRejected

    End Sub
End Class