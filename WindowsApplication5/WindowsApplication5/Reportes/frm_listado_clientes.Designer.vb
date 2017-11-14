<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_listado_clientes
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_listado_clientes))
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.dbventasDataSet = New WindowsApplication5.dbventasDataSet()
        Me.mostrar_clienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.mostrar_clienteTableAdapter = New WindowsApplication5.dbventasDataSetTableAdapters.mostrar_clienteTableAdapter()
        CType(Me.dbventasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mostrar_clienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.mostrar_clienteBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication5.lis_clientes.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(911, 537)
        Me.ReportViewer1.TabIndex = 0
        '
        'dbventasDataSet
        '
        Me.dbventasDataSet.DataSetName = "dbventasDataSet"
        Me.dbventasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'mostrar_clienteBindingSource
        '
        Me.mostrar_clienteBindingSource.DataMember = "mostrar_cliente"
        Me.mostrar_clienteBindingSource.DataSource = Me.dbventasDataSet
        '
        'mostrar_clienteTableAdapter
        '
        Me.mostrar_clienteTableAdapter.ClearBeforeFill = True
        '
        'lis_clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(911, 537)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "lis_clientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listad de Clientes"
        CType(Me.dbventasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mostrar_clienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents mostrar_clienteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dbventasDataSet As WindowsApplication5.dbventasDataSet
    Friend WithEvents mostrar_clienteTableAdapter As WindowsApplication5.dbventasDataSetTableAdapters.mostrar_clienteTableAdapter
End Class
