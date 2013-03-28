Public Class modificarproveedor
    Dim nit As String
    Dim nombre, telefono, direccion As String

    Private Sub modificarproveedor_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        nit = Nothing
        nombre = String.Empty
        telefono = String.Empty
        direccion = String.Empty
    End Sub

    Private Sub ButtonX3_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX3.Click
        'buscar
        proveedor_seleccionar.ShowDialog()
        TextBoxX3.Text = proveedor_seleccionar.nit
    End Sub

    Private Sub ButtonX4_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX4.Click
        'mostrar
        Me.ProveedorTableAdapter.proveedor_buscar(Me.PollosDataSet.proveedor, TextBoxX3.Text)
        nit = TextBoxX3.Text
    End Sub

    Private Sub TextBoxX1_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles TextBoxX1.Validating
        'que el nombre no este vacio
        If (TextBoxX1.Text.Length > 0) Then
            ErrorProvider.SetError(TextBoxX1, Nothing)
            nombre = TextBoxX1.Text
        Else
            ErrorProvider.SetError(TextBoxX1, "El NOMBRE No Puede Estar Vacio")
            nombre = String.Empty
        End If
    End Sub

    Private Sub IntegerInput2_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles IntegerInput2.Validating
        'que el telefono no este vacio
        If (IntegerInput2.Text.Length > 0) Then
            ErrorProvider.SetError(IntegerInput2, Nothing)
            telefono = IntegerInput2.Text
        Else
            ErrorProvider.SetError(IntegerInput2, "El TELEFONO No puede estar Vacio")
            telefono = Nothing
        End If
    End Sub

    Private Sub TextBoxX2_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles TextBoxX2.Validating
        'que la direccion no este vacio
        If (TextBoxX2.Text.Length > 0) Then
            ErrorProvider.SetError(TextBoxX2, Nothing)
            direccion = TextBoxX2.Text
        Else
            ErrorProvider.SetError(TextBoxX2, "El NOMBRE No Puede Estar Vacio")
            direccion = String.Empty
        End If
    End Sub

    Private Sub ButtonX2_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX2.Click
        Close()
        nit = Nothing
        nombre = String.Empty
        telefono = String.Empty
        direccion = String.Empty
    End Sub

    Private Sub ButtonX1_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX1.Click
        'guardar
        Dim filas As Integer
        If (nombre = Nothing Or telefono = Nothing Or direccion = Nothing) Then
            MessageBox.Show("Debe Llenar Todos Los Campos")
        Else
            filas = Me.ProveedorTableAdapter.update_proveedor(nombre, telefono, direccion, nit)
            If (filas) Then
                MessageBox.Show("DATOS GUARDADADOS CORRECTAMENTE")
                Close()
            Else
                MessageBox.Show("OCURRIO UN ERROR AL GUARDAR LOS DATOS")
            End If
        End If
    End Sub
End Class