Public Class frm_categoria

    Enum respuesta_validacion
        _ok
        _error
    End Enum

    Private dt As New DataTable

    Private Sub frm_categoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub

    Public Sub limpiar()
        btnguardar.Visible = True
        btneditar.Visible = False
        txtnombre.Text = ""
        txtidcategoría.Text = ""
    End Sub

    Private Sub mostrar()
        Try
            Dim func As New FCategoria
            dt = func.mostrar


            If dt.Rows.Count <> 0 Then
                dgv_categorias.DataSource = dt
                txtbuscar.Enabled = True
                dgv_categorias.ColumnHeadersVisible = True
                inexistente.Visible = False
            Else
                dgv_categorias.DataSource = Nothing
                dgv_categorias.ColumnHeadersVisible = False
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
                dgv_categorias.DataSource = dv
                ocultar_columnas()

            Else
                inexistente.Visible = True
                dgv_categorias.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub ocultar_columnas()
        dgv_categorias.Columns(0).Visible = False
    End Sub


    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        limpiar()
        mostrar()
        txtnombre.Focus()
    End Sub


    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Try
            If validar_datos() = respuesta_validacion._ok Then
                Dim dts As New Vcategoria
                Dim func As New FCategoria

                dts.gnombre_categoria = txtnombre.Text

                If func.insertar(dts) Then
                    MessageBox.Show("Categoría registrada correctamente", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                Else
                    MessageBox.Show("Categoría no fue registrada intente de nuevo", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
            MsgBox("El campo Nombre Categoria está vacio, por favor ingrese un Nombre", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
            Me.txtnombre.Focus()
            Return respuesta_validacion._error
        End If
        Return respuesta_validacion._ok
    End Function

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        If Me.txtnombre.Text <> "" Then
            Dim result As DialogResult

            result = MessageBox.Show("Realmente desea eliinar los datos de la categoria?", "Modificando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

            If result = DialogResult.OK Then
                Try
                    Dim func As New FCategoria
                    Dim dts As New Vcategoria

                    dts.gidcategoria = txtidcategoría.Text

                    If func.eliminar(dts) Then
                        MsgBox("Datos eliminados correctamente")
                        limpiar()
                        mostrar()
                        txtnombre.Focus()
                    Else
                        MsgBox("No se eliminaron los registros")
                    End If

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        Else
            MsgBox("Por favor seleccione una categoria a Eliminar!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
        End If
    End Sub

    Private Sub dgv_categorias_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_categorias.CellClick
        txtidcategoría.Text = dgv_categorias.SelectedCells.Item(0).Value
        txtnombre.Text = dgv_categorias.SelectedCells.Item(1).Value
        btneditar.Visible = True
        btnguardar.Visible = False
    End Sub

    Private Sub dgv_categorias_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_categorias.CellDoubleClick
        If txtflag.Text = "1" Then
            frm_producto.txtidcategoria.Text = dgv_categorias.SelectedCells.Item(0).Value
            frm_producto.txtnom_categoria.Text = dgv_categorias.SelectedCells.Item(1).Value
            Me.Close()
        End If
    End Sub

    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click
        Dim result As DialogResult

        result = MessageBox.Show("Realmente desea editar los datos de la categoría?", "MOdificando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then

            Try
                Dim dts As New Vcategoria
                Dim func As New FCategoria

                dts.gidcategoria = txtidcategoría.Text
                dts.gnombre_categoria = txtnombre.Text


                If func.editar(dts) Then
                    MessageBox.Show("Categoría Modificada correctamente", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                Else
                    MessageBox.Show("Categoría no fue modifcada intente de nuevo", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    mostrar()
                    limpiar()
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        buscar()
    End Sub

    Private Sub btbcancelar_Click(sender As Object, e As EventArgs) Handles btbcancelar.Click
        Me.Close()
    End Sub
End Class
