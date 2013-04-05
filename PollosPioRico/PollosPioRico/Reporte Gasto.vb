Public Class Reporte_Gasto
    Public mes As Integer
    Public anho As Integer
    Private Sub Reporte_Gasto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.GastosTableAdapter1.report_gasto(Me.PollosDataSet1.gastos, mes, anho)

        Me.reporte_gast1.SetDataSource(Me.PollosDataSet1)
        Me.CrystalReportViewer1.ReportSource = Me.reporte_gast1
    End Sub
End Class