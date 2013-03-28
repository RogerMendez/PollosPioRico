Public Class cliente_registrar
    Dim ci As Integer
    Dim nombre As String

    Private Sub cliente_registrar_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ci = Nothing
        nombre = String.Empty
    End Sub

    Private Sub IntegerInput1_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles IntegerInput1.Validating
        'validar que el ci no este vacio o que no exista
        Dim existe As Boolean
        existe = False
        If (IntegerInput1.Text.Length > 0 And IntegerInput1.Text.Length <= 7) Then
            Me.ClienteTableAdapter1.cliente_existe(IntegerInput1.Text, existe)
            If (existe) Then
                ErrorProvider1.SetError(IntegerInput1, "Este Cliente Ya Esta Registrado")
                ci = Nothing
            Else
                ErrorProvider1.SetError(IntegerInput1, Nothing)
                ci = IntegerInput1.Text
            End If
        Else
            ErrorProvider1.SetError(IntegerInput1, "La CEDULA DE INDENTIDAD No Puede Estar Vacio y Debe Contener 8 numeros")
            ci = Nothing
        End If
    End Sub

    Private Sub TextBoxX1_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles TextBoxX1.Validating
        'que el nombre no este vacio
        If (TextBoxX1.Text.Length > 0) Then
            ErrorProvider1.SetError(TextBoxX1, Nothing)
            nombre = TextBoxX1.Text
        Else
            ErrorProvider1.SetError(TextBoxX1, "Debe Registrar El NOMBRE")
            nombre = String.Empty
        End If
    End Sub

    Private Sub ButtonX2_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX2.Click
        'cancelar
        Close()
    End Sub

    Private Sub ButtonX1_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX1.Click
        'guardar
        Dim filas As Integer
        If (nombre = Nothing Or ci = Nothing) Then
            MessageBox.Show("Debe Registrar Los Campos Obligatorios")
        Else
            filas = Me.ClienteTableAdapter1.Insert(ci, nombre, TextBoxX3.Text, TextBoxX2.Text)
            If (filas) Then
                MessageBox.Show("DATOS GUARDADOS CORRECTAMENTE")
                Close()
            Else
                MessageBox.Show("OCURRIO UN ERROR AL GUARDAR LOS DATOS")
            End If
        End If
    End Sub
End Class