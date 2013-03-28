Public Class registrarproveedor
    Dim nit As String
    Dim nombre, telefono, direccion As String

    Private Sub registrarproveedor_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        nit = Nothing
        nombre = String.Empty
        telefono = String.Empty
        direccion = String.Empty
    End Sub

    Private Sub TextBoxX3_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxX3.KeyPress
        'validar que el nit solo sean numeros
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBoxX3_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles TextBoxX3.Validating
        'que el nit no este vacio y no exista
        Dim existe As Boolean
        existe = False
        If (TextBoxX3.Text.Length > 0 And TextBoxX3.Text.Length = 14) Then
            Me.ProveedorTableAdapter1.proveedor_existe(TextBoxX3.Text, existe)
            If (existe) Then
                ErrorProvider.SetError(TextBoxX3, "EL NIT YA ESTA REGISTRADO")
                nit = String.Empty
            Else
                ErrorProvider.SetError(TextBoxX3, Nothing)
                nit = TextBoxX3.Text
            End If
        Else
            ErrorProvider.SetError(TextBoxX3, "El NIT No puede estar Vacio Y Debe Tener 14 Digitos")
            nit = Nothing
        End If
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
        If (nit = Nothing Or nombre = Nothing Or telefono = Nothing Or direccion = Nothing) Then
            MessageBox.Show("Debe Llenar Todos Los Campos")
        Else
            filas = ProveedorTableAdapter1.Insert(nit, nombre, telefono, direccion)
            If (filas) Then
                MessageBox.Show("DATOS GUARDADADOS CORRECTAMENTE")
                Close()
            Else
                MessageBox.Show("OCURRIO UN ERROR AL GUARDAR LOS DATOS")
            End If
        End If
    End Sub
End Class