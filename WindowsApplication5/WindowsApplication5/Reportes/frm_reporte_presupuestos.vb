Public Class frm_reporte_presupuestos
    Public fecha_inicial As Date
    Public fecha_final As Date
    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load
        'Dim objreporte As New rpt_presupuestos
        'objreporte.SetParameterValue("@fecha", fecha_inicial)
        'objreporte.SetParameterValue("@fecha2", fecha_final)

        'CrystalReportViewer1.ReportSource = objreporte
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim objreporte As New rpt_presupuestos
        objreporte.SetParameterValue("@fecha", CDate(DateTimePicker1.Text))
        objreporte.SetParameterValue("@fecha2", CDate(DateTimePicker2.Text))

        CrystalReportViewer1.ReportSource = objreporte

        'Dim fechaini As Date = CDate(DateTimePicker1.Text)
        'Dim fechafin As Date = CDate(DateTimePicker2.Text)

        'Dim frmreportepresupuesto As New frm_reporte_presupuestos

        'frmreportepresupuesto.fecha_inicial = fechaini
        'frmreportepresupuesto.fecha_final = fechafin
        'frmreportepresupuesto.ShowDialog()
    End Sub

    Private Sub frm_reporte_presupuestos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class