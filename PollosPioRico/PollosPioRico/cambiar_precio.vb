Public Class cambiar_precio
    Dim precio As Double
    Dim cod_dep As Integer

    Private Sub cambiar_precio_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PollosDataSet.almacen' Puede moverla o quitarla según sea necesario.
        Me.AlmacenTableAdapter.Fill(Me.PollosDataSet.almacen)
        precio = Nothing
        cod_dep = Nothing
    End Sub

    Private Sub DataGridViewX1_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewX1.CellClick
        DoubleInput1.Text = Me.PollosDataSet.almacen(Me.AlmacenBindingSource.Position).precio_unidad
    End Sub

    Private Sub ButtonX1_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX1.Click
        'cancelar
        Close()
    End Sub

    Private Sub DoubleInput1_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles DoubleInput1.Validating
        'validar que el precio no este vacio
        If (DoubleInput1.Text.Length > 0 And DoubleInput1.Text > 0) Then
            ErrorProvider1.SetError(LabelX2, Nothing)
            precio = DoubleInput1.Text
            cod_dep = Me.PollosDataSet.almacen(AlmacenBindingSource.Position).cod_depo
        Else
            ErrorProvider1.SetError(LabelX2, "Debe Seleccionar Un Producto")
            precio = Nothing
            cod_dep = Nothing
        End If
    End Sub

    Private Sub Cambiar_Click(sender As System.Object, e As System.EventArgs) Handles Cambiar.Click
        'cambiar precio
        Dim filas As Integer
        filas = Nothing
        If (precio = Nothing And cod_dep = Nothing) Then
            MessageBox.Show("DEBE SELECCIONAR UN PRODUCTO")
        Else
            filas = Me.QueriesTableAdapter1.cambiar_precio(cod_dep, precio)
            If (filas) Then
                MessageBox.Show("DATOS GUARDADOS CORRECTAMENTE")
                Close()
            Else
                MessageBox.Show("OCURRIO UN ERROR AL GUARDAR LOS DATOS")
            End If
        End If
    End Sub
End Class