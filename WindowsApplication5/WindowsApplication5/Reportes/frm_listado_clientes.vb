Public Class frm_listado_clientes

    Private Sub lis_clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'dbventasDataSet.mostrar_cliente' Puede moverla o quitarla según sea necesario.
        Me.mostrar_clienteTableAdapter.Fill(Me.dbventasDataSet.mostrar_cliente)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class