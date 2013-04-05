

Public Class reporte_venta
    Public mes As Integer
    Public anho As Integer


    Private Sub reporte_venta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Reporte_ventasTableAdapter1.report_venta(Me.PollosDataSet1.reporte_ventas, mes, anho)

        Me.CrystalReport11.SetDataSource(Me.PollosDataSet1)

        Me.CrystalReportViewer1.ReportSource = Me.CrystalReport11
    End Sub
End Class