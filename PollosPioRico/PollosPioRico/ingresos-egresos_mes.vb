Public Class ingresos_egresos_mes
    Dim totalgasto As Double
    Dim totalventa As Double
    Dim totalpollos As Double

    Private Sub ingresos_egresos_mes_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        totalgasto = Nothing
        totalventa = Nothing
        totalpollos = Nothing
    End Sub

    Private Sub ButtonX1_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX1.Click
        'mostrar
        Me.QueriesTableAdapter1.total_gasto(ComboBoxEx1.SelectedIndex + 1, 2013, totalgasto)
        Me.QueriesTableAdapter1.total_pollos(ComboBoxEx1.SelectedIndex + 1, 2013, totalpollos)
        Me.QueriesTableAdapter1.total_venta(ComboBoxEx1.SelectedIndex + 1, 2013, totalventa)

        gasto.Text = totalgasto.ToString
        venta.Text = totalventa.ToString
        pollos.Text = totalpollos.ToString
        total.Text = totalventa - (totalgasto + totalpollos)
        'MessageBox.Show(ComboBoxEx1.Text + vbCrLf + ComboBoxEx1.SelectedIndex.ToString)
    End Sub
End Class