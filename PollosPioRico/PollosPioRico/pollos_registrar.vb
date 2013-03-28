Public Class pollos_registrar
    Dim nit As String
    Dim cantidad As Integer
    Dim precio, precio_uni As Double

    Private Sub pollos_registrar_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        nit = String.Empty
        cantidad = Nothing
        precio = Nothing
        precio_uni = Nothing
    End Sub

    Private Sub ButtonX3_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX3.Click
        'seleccionar proveedor
        proveedor_seleccionar.ShowDialog()
        TextBoxX1.Text = proveedor_seleccionar.nit
        If (TextBoxX1.Text.Length > 0) Then
            nit = TextBoxX1.Text
            ErrorProvider1.SetError(ButtonX3, Nothing)
        Else
            ErrorProvider1.SetError(ButtonX3, "Debe Seleccionar Un PROVEEDOR")
            nit = String.Empty
        End If
    End Sub

    Private Sub IntegerInput1_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles IntegerInput1.Validating
        'que la cantidad no este vacia
        If (IntegerInput1.Text.Length > 0) Then
            cantidad = IntegerInput1.Text
            ErrorProvider1.SetError(IntegerInput1, Nothing)
        Else
            cantidad = Nothing
            ErrorProvider1.SetError(IntegerInput1, "Debe Registrar Una Cantidad")
        End If
    End Sub

    Private Sub DoubleInput1_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles DoubleInput1.Validating
        'que el precion no este vacio
        If (DoubleInput1.Text.Length > 0) Then
            ErrorProvider1.SetError(DoubleInput1, Nothing)
            precio = DoubleInput1.Text
        Else
            ErrorProvider1.SetError(DoubleInput1, "Debe Registrar el PRECIO")
            precio = Nothing
        End If
    End Sub

    Private Sub DoubleInput2_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles DoubleInput2.Validating
        'que el precio_uni no este vacio
        If (DoubleInput2.Text.Length > 0) Then
            ErrorProvider1.SetError(DoubleInput2, Nothing)
            precio_uni = DoubleInput2.Text
        Else
            ErrorProvider1.SetError(DoubleInput2, "Debe Registrar el PRECIO POR KILOGRAMO")
            precio_uni = Nothing
        End If
    End Sub

    Private Sub ButtonX2_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX2.Click
        'cancelar 
        Close()
    End Sub

    Private Sub ButtonX1_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX1.Click
        Dim filas As Integer
        filas = 0
        If (nit = Nothing Or cantidad = Nothing Or precio = Nothing Or precio_uni = Nothing) Then
            MessageBox.Show("Debe Registrar Todos Los Campos")
        Else
            filas = Me.QueriesTableAdapter1.pollos_registrar(nit, precio, cantidad, precio_uni)
            If (filas = 2) Then
                MessageBox.Show("DATOS REGISTRADOS CORRECTAMENTE")
                Close()
            Else
                MessageBox.Show("OCURRIO UN ERROR AL GUARDAR LOS DATOS")
            End If
        End If
    End Sub
End Class