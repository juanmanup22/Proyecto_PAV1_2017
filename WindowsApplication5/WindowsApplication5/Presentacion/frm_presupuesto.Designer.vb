<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_presupuesto
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_presupuesto))
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtFecha = New System.Windows.Forms.MaskedTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.group_detalle_Factura = New System.Windows.Forms.GroupBox()
        Me.msk_cantidad = New System.Windows.Forms.MaskedTextBox()
        Me.txt_descripcion = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_producto = New System.Windows.Forms.TextBox()
        Me.txt_idproducto = New System.Windows.Forms.TextBox()
        Me.btn_buscar_producto = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_precioProducto = New System.Windows.Forms.TextBox()
        Me.grid_productos = New System.Windows.Forms.DataGridView()
        Me.id_Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipoProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btn_agregarProductos = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_nro_presupuesto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnbuscar_cliente = New System.Windows.Forms.Button()
        Me.txt_apellidoCliente = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtnombre_cliente = New System.Windows.Forms.TextBox()
        Me.txtidcliente = New System.Windows.Forms.TextBox()
        Me.txt_Doc_cliente = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmd_grabar = New System.Windows.Forms.Button()
        Me.cmd_nuevo = New System.Windows.Forms.Button()
        Me.group_detalle_Factura.SuspendLayout()
        CType(Me.grid_productos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(428, 58)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 58
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkCyan
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(265, 461)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 39)
        Me.Button1.TabIndex = 57
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtFecha
        '
        Me.txtFecha.Location = New System.Drawing.Point(490, 22)
        Me.txtFecha.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFecha.Mask = "00/00/0000"
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(69, 20)
        Me.txtFecha.TabIndex = 56
        Me.txtFecha.ValidatingType = GetType(Date)
        Me.txtFecha.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label11.Location = New System.Drawing.Point(45, 13)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(160, 29)
        Me.Label11.TabIndex = 55
        Me.Label11.Text = "Presupuesto"
        '
        'txt_total
        '
        Me.txt_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total.Location = New System.Drawing.Point(465, 472)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(100, 21)
        Me.txt_total.TabIndex = 54
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.ForeColor = System.Drawing.Color.SteelBlue
        Me.lbl_total.Location = New System.Drawing.Point(420, 473)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(39, 15)
        Me.lbl_total.TabIndex = 53
        Me.lbl_total.Text = "Total"
        '
        'group_detalle_Factura
        '
        Me.group_detalle_Factura.Controls.Add(Me.msk_cantidad)
        Me.group_detalle_Factura.Controls.Add(Me.txt_descripcion)
        Me.group_detalle_Factura.Controls.Add(Me.Label7)
        Me.group_detalle_Factura.Controls.Add(Me.Label8)
        Me.group_detalle_Factura.Controls.Add(Me.txt_producto)
        Me.group_detalle_Factura.Controls.Add(Me.txt_idproducto)
        Me.group_detalle_Factura.Controls.Add(Me.btn_buscar_producto)
        Me.group_detalle_Factura.Controls.Add(Me.Label14)
        Me.group_detalle_Factura.Controls.Add(Me.Label13)
        Me.group_detalle_Factura.Controls.Add(Me.txt_precioProducto)
        Me.group_detalle_Factura.Controls.Add(Me.grid_productos)
        Me.group_detalle_Factura.Controls.Add(Me.Label12)
        Me.group_detalle_Factura.Controls.Add(Me.btn_agregarProductos)
        Me.group_detalle_Factura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.group_detalle_Factura.ForeColor = System.Drawing.Color.SteelBlue
        Me.group_detalle_Factura.Location = New System.Drawing.Point(43, 205)
        Me.group_detalle_Factura.Name = "group_detalle_Factura"
        Me.group_detalle_Factura.Size = New System.Drawing.Size(585, 250)
        Me.group_detalle_Factura.TabIndex = 50
        Me.group_detalle_Factura.TabStop = False
        Me.group_detalle_Factura.Text = "PRODUCTOS"
        '
        'msk_cantidad
        '
        Me.msk_cantidad.Location = New System.Drawing.Point(507, 69)
        Me.msk_cantidad.Mask = "99999"
        Me.msk_cantidad.Name = "msk_cantidad"
        Me.msk_cantidad.Size = New System.Drawing.Size(62, 20)
        Me.msk_cantidad.TabIndex = 224
        Me.msk_cantidad.ValidatingType = GetType(Integer)
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Enabled = False
        Me.txt_descripcion.Location = New System.Drawing.Point(213, 60)
        Me.txt_descripcion.Multiline = True
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(187, 47)
        Me.txt_descripcion.TabIndex = 33
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(127, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 13)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Descripción"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 31)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(20, 13)
        Me.Label8.TabIndex = 223
        Me.Label8.Text = "ID"
        '
        'txt_producto
        '
        Me.txt_producto.Enabled = False
        Me.txt_producto.Location = New System.Drawing.Point(213, 24)
        Me.txt_producto.Name = "txt_producto"
        Me.txt_producto.Size = New System.Drawing.Size(187, 20)
        Me.txt_producto.TabIndex = 31
        '
        'txt_idproducto
        '
        Me.txt_idproducto.Enabled = False
        Me.txt_idproducto.Location = New System.Drawing.Point(39, 28)
        Me.txt_idproducto.Name = "txt_idproducto"
        Me.txt_idproducto.Size = New System.Drawing.Size(48, 20)
        Me.txt_idproducto.TabIndex = 222
        '
        'btn_buscar_producto
        '
        Me.btn_buscar_producto.BackColor = System.Drawing.Color.DarkCyan
        Me.btn_buscar_producto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_buscar_producto.ForeColor = System.Drawing.Color.White
        Me.btn_buscar_producto.Location = New System.Drawing.Point(468, 113)
        Me.btn_buscar_producto.Name = "btn_buscar_producto"
        Me.btn_buscar_producto.Size = New System.Drawing.Size(101, 38)
        Me.btn_buscar_producto.TabIndex = 30
        Me.btn_buscar_producto.Text = "Buscar"
        Me.btn_buscar_producto.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(444, 72)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(57, 13)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "Cantidad"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(458, 34)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(43, 13)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Precio"
        '
        'txt_precioProducto
        '
        Me.txt_precioProducto.Enabled = False
        Me.txt_precioProducto.Location = New System.Drawing.Point(507, 31)
        Me.txt_precioProducto.Name = "txt_precioProducto"
        Me.txt_precioProducto.Size = New System.Drawing.Size(60, 20)
        Me.txt_precioProducto.TabIndex = 26
        '
        'grid_productos
        '
        Me.grid_productos.AllowUserToAddRows = False
        Me.grid_productos.AllowUserToDeleteRows = False
        Me.grid_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_productos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_Producto, Me.tipoProducto, Me.cantidad, Me.subtotal})
        Me.grid_productos.Location = New System.Drawing.Point(16, 113)
        Me.grid_productos.Name = "grid_productos"
        Me.grid_productos.ReadOnly = True
        Me.grid_productos.Size = New System.Drawing.Size(446, 131)
        Me.grid_productos.TabIndex = 23
        '
        'id_Producto
        '
        Me.id_Producto.HeaderText = "ID Producto"
        Me.id_Producto.Name = "id_Producto"
        Me.id_Producto.ReadOnly = True
        '
        'tipoProducto
        '
        Me.tipoProducto.HeaderText = "Tipo Producto"
        Me.tipoProducto.Name = "tipoProducto"
        Me.tipoProducto.ReadOnly = True
        '
        'cantidad
        '
        Me.cantidad.HeaderText = "Cantidad"
        Me.cantidad.Name = "cantidad"
        Me.cantidad.ReadOnly = True
        '
        'subtotal
        '
        Me.subtotal.HeaderText = "Subtotal"
        Me.subtotal.Name = "subtotal"
        Me.subtotal.ReadOnly = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(149, 28)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 13)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Producto"
        '
        'btn_agregarProductos
        '
        Me.btn_agregarProductos.BackColor = System.Drawing.Color.DarkCyan
        Me.btn_agregarProductos.Enabled = False
        Me.btn_agregarProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agregarProductos.ForeColor = System.Drawing.Color.White
        Me.btn_agregarProductos.Location = New System.Drawing.Point(466, 157)
        Me.btn_agregarProductos.Name = "btn_agregarProductos"
        Me.btn_agregarProductos.Size = New System.Drawing.Size(101, 38)
        Me.btn_agregarProductos.TabIndex = 14
        Me.btn_agregarProductos.Text = "Agregar"
        Me.btn_agregarProductos.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label3.Location = New System.Drawing.Point(376, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 15)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Fecha"
        '
        'txt_nro_presupuesto
        '
        Me.txt_nro_presupuesto.Enabled = False
        Me.txt_nro_presupuesto.Location = New System.Drawing.Point(159, 58)
        Me.txt_nro_presupuesto.Name = "txt_nro_presupuesto"
        Me.txt_nro_presupuesto.Size = New System.Drawing.Size(85, 20)
        Me.txt_nro_presupuesto.TabIndex = 46
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label1.Location = New System.Drawing.Point(39, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 15)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Nro.Presupuesto"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnbuscar_cliente)
        Me.GroupBox1.Controls.Add(Me.txt_apellidoCliente)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtnombre_cliente)
        Me.GroupBox1.Controls.Add(Me.txtidcliente)
        Me.GroupBox1.Controls.Add(Me.txt_Doc_cliente)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.SteelBlue
        Me.GroupBox1.Location = New System.Drawing.Point(43, 92)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(585, 107)
        Me.GroupBox1.TabIndex = 49
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CLIENTE"
        '
        'btnbuscar_cliente
        '
        Me.btnbuscar_cliente.BackColor = System.Drawing.Color.DarkCyan
        Me.btnbuscar_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbuscar_cliente.ForeColor = System.Drawing.Color.White
        Me.btnbuscar_cliente.Location = New System.Drawing.Point(455, 63)
        Me.btnbuscar_cliente.Name = "btnbuscar_cliente"
        Me.btnbuscar_cliente.Size = New System.Drawing.Size(101, 38)
        Me.btnbuscar_cliente.TabIndex = 218
        Me.btnbuscar_cliente.Text = "Buscar"
        Me.btnbuscar_cliente.UseVisualStyleBackColor = False
        '
        'txt_apellidoCliente
        '
        Me.txt_apellidoCliente.Enabled = False
        Me.txt_apellidoCliente.Location = New System.Drawing.Point(213, 65)
        Me.txt_apellidoCliente.Name = "txt_apellidoCliente"
        Me.txt_apellidoCliente.Size = New System.Drawing.Size(138, 20)
        Me.txt_apellidoCliente.TabIndex = 221
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(155, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 220
        Me.Label5.Text = "Apellido"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(157, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 219
        Me.Label4.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 13)
        Me.Label2.TabIndex = 218
        Me.Label2.Text = "ID"
        '
        'txtnombre_cliente
        '
        Me.txtnombre_cliente.Enabled = False
        Me.txtnombre_cliente.Location = New System.Drawing.Point(213, 29)
        Me.txtnombre_cliente.Name = "txtnombre_cliente"
        Me.txtnombre_cliente.Size = New System.Drawing.Size(138, 20)
        Me.txtnombre_cliente.TabIndex = 217
        '
        'txtidcliente
        '
        Me.txtidcliente.Enabled = False
        Me.txtidcliente.Location = New System.Drawing.Point(39, 29)
        Me.txtidcliente.Name = "txtidcliente"
        Me.txtidcliente.Size = New System.Drawing.Size(48, 20)
        Me.txtidcliente.TabIndex = 216
        '
        'txt_Doc_cliente
        '
        Me.txt_Doc_cliente.Enabled = False
        Me.txt_Doc_cliente.Location = New System.Drawing.Point(489, 32)
        Me.txt_Doc_cliente.Name = "txt_Doc_cliente"
        Me.txt_Doc_cliente.Size = New System.Drawing.Size(67, 20)
        Me.txt_Doc_cliente.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(407, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Numero DNI"
        '
        'cmd_grabar
        '
        Me.cmd_grabar.BackColor = System.Drawing.Color.DarkCyan
        Me.cmd_grabar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_grabar.ForeColor = System.Drawing.Color.White
        Me.cmd_grabar.Location = New System.Drawing.Point(154, 461)
        Me.cmd_grabar.Name = "cmd_grabar"
        Me.cmd_grabar.Size = New System.Drawing.Size(105, 39)
        Me.cmd_grabar.TabIndex = 52
        Me.cmd_grabar.Text = "Grabar"
        Me.cmd_grabar.UseVisualStyleBackColor = False
        '
        'cmd_nuevo
        '
        Me.cmd_nuevo.BackColor = System.Drawing.Color.DarkCyan
        Me.cmd_nuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_nuevo.ForeColor = System.Drawing.Color.White
        Me.cmd_nuevo.Location = New System.Drawing.Point(43, 461)
        Me.cmd_nuevo.Name = "cmd_nuevo"
        Me.cmd_nuevo.Size = New System.Drawing.Size(105, 39)
        Me.cmd_nuevo.TabIndex = 51
        Me.cmd_nuevo.Text = "Nuevo"
        Me.cmd_nuevo.UseVisualStyleBackColor = False
        '
        'frm_presupuesto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(667, 513)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.group_detalle_Factura)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_nro_presupuesto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmd_grabar)
        Me.Controls.Add(Me.cmd_nuevo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_presupuesto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Presupuesto"
        Me.group_detalle_Factura.ResumeLayout(False)
        Me.group_detalle_Factura.PerformLayout()
        CType(Me.grid_productos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtFecha As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_total As System.Windows.Forms.TextBox
    Friend WithEvents lbl_total As System.Windows.Forms.Label
    Friend WithEvents group_detalle_Factura As System.Windows.Forms.GroupBox
    Friend WithEvents msk_cantidad As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_producto As System.Windows.Forms.TextBox
    Friend WithEvents txt_idproducto As System.Windows.Forms.TextBox
    Friend WithEvents btn_buscar_producto As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_precioProducto As System.Windows.Forms.TextBox
    Friend WithEvents grid_productos As System.Windows.Forms.DataGridView
    Friend WithEvents id_Producto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipoProducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents subtotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btn_agregarProductos As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_nro_presupuesto As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnbuscar_cliente As System.Windows.Forms.Button
    Friend WithEvents txt_apellidoCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtnombre_cliente As System.Windows.Forms.TextBox
    Friend WithEvents txtidcliente As System.Windows.Forms.TextBox
    Friend WithEvents txt_Doc_cliente As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmd_grabar As System.Windows.Forms.Button
    Friend WithEvents cmd_nuevo As System.Windows.Forms.Button
End Class
