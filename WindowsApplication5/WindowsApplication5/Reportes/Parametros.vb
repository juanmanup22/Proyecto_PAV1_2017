Public Class Parametros

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fechaini As Date = CDate(DateTimePicker1.Text)
        Dim fechafin As Date = CDate(DateTimePicker2.Text)

        Dim frmreportepresupuesto As New frm_reporte_presupuestos

        frmreportepresupuesto.fecha_inicial = fechaini
        frmreportepresupuesto.fecha_final = fechafin
        frmreportepresupuesto.ShowDialog()
    End Sub
End Class