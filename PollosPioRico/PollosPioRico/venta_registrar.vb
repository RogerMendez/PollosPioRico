Public Class venta_registrar
    Dim cod_cli, cod_depo As Integer
    Dim peso As Double
    Dim precio_venta As Double

    Private Sub venta_registrar_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PollosDataSet.almacen' Puede moverla o quitarla según sea necesario.
        Me.AlmacenTableAdapter.Fill(Me.PollosDataSet.almacen)
        cod_cli = Nothing
        peso = Nothing
        precio_venta = Nothing
        cod_depo = Nothing
    End Sub

    Private Sub ButtonX3_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX3.Click
        cliente_seleccionar.ShowDialog()
        TextBoxX1.Text = cliente_seleccionar.nombre
        cod_cli = cliente_seleccionar.cod
    End Sub

    Private Sub DoubleInput1_ValueChanged(sender As System.Object, e As System.EventArgs) Handles DoubleInput1.ValueChanged
        Dim precio_uni As Double
        Dim saldo As Double
        saldo = Me.PollosDataSet.almacen(Me.AlmacenBindingSource.Position).cantidad_saldo
        precio_uni = Nothing
        If (DoubleInput1.Text.Length > 0) Then
            If (DoubleInput1.Text <= saldo) Then
                ErrorProvider1.SetError(DoubleInput1, Nothing)
                precio_uni = Me.PollosDataSet.almacen(Me.AlmacenBindingSource.Position).precio_unidad
                DoubleInput2.Text = precio_uni * DoubleInput1.Text
                peso = DoubleInput1.Text
                cod_depo = Me.PollosDataSet.almacen(Me.AlmacenBindingSource.Position).cod_depo
            Else
                ErrorProvider1.SetError(DoubleInput1, "NO TIENE SUFICIENTE STOCK")
                peso = Nothing
                cod_depo = Nothing
            End If
        Else
            ErrorProvider1.SetError(DoubleInput1, "DEBE REGISTRAR EL PESO DE VENTA")
            peso = Nothing
            cod_depo = Nothing
        End If
    End Sub

    Private Sub DoubleInput2_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles DoubleInput2.Validating
        'validar el precio de la venta
        If (DoubleInput2.Text > 0) Then
            precio_venta = DoubleInput2.Text
            ErrorProvider1.SetError(DoubleInput2, Nothing)
        Else
            precio_venta = Nothing
            ErrorProvider1.SetError(DoubleInput2, "Debe Registrar Un PRECIO DE VENTA")
        End If
    End Sub

    Private Sub ButtonX1_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX1.Click
        'guardar
        Dim filas As Integer
        filas = Nothing
        If (cod_cli = Nothing Or peso = Nothing Or precio_venta = Nothing Or cod_depo = Nothing) Then
            MessageBox.Show("DEBE SOLUCIONAR TODOS LOS ERRORES")
        Else
            'MessageBox.Show(cod_cli.ToString + vbCrLf + peso.ToString + vbCrLf + precio_venta.ToString + vbCrLf + cod_depo.ToString)
            filas = Me.QueriesTableAdapter1.venta_registro(cod_cli, cod_depo, peso, precio_venta)
            If (filas = 2) Then
                MessageBox.Show("DATOS GUARDADOS CORRECTAMENTE")
                Close()
            Else
                MessageBox.Show("OCURRIO UN ERROR AL GUARDAR LOS DATOS")
            End If
        End If
    End Sub

    Private Sub ButtonX2_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX2.Click
        'cancelar
        Close()
    End Sub
End Class