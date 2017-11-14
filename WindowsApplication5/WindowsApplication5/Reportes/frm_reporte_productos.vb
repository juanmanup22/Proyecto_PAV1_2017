Public Class frm_reporte_productos

    Private Sub frm_reporte_productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'dbventasDataSet.mostrar_producto' Puede moverla o quitarla según sea necesario.
        Me.mostrar_productoTableAdapter.Fill(Me.dbventasDataSet.mostrar_producto)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class