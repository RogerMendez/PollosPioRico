Public Class gasto_registrar
    Dim descripcion As String
    Dim precio As Double

    Private Sub gasto_registrar_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        descripcion = String.Empty
        precio = Nothing
    End Sub

    Private Sub TextBoxX1_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles TextBoxX1.Validating
        'validar que las descripcion no este vacia
        If (TextBoxX1.Text.Length > 0) Then
            descripcion = TextBoxX1.Text
            ErrorProvider1.SetError(TextBoxX1, Nothing)
        Else
            descripcion = String.Empty
            ErrorProvider1.SetError(TextBoxX1, "Debe Registrar una DESCRIPCIÓN")
        End If
    End Sub

    Private Sub DoubleInput1_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles DoubleInput1.Validating
        'validar que el precio no este vacio
        If (DoubleInput1.Text.Length > 0 And DoubleInput1.Text > 0) Then
            precio = DoubleInput1.Text
            ErrorProvider1.SetError(DoubleInput1, Nothing)
        Else
            precio = Nothing
            ErrorProvider1.SetError(DoubleInput1, "Debe Registrar El Precio del GASTO")
        End If
    End Sub

    Private Sub ButtonX1_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX1.Click
        'cancelar
        Close()
    End Sub

    Private Sub ButtonX2_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX2.Click
        'guardar gasto
        Dim filas As Integer
        filas = Nothing
        If (descripcion = Nothing And precio = Nothing) Then
            MessageBox.Show("DEBE REGISTRAR TODOS LOS CAMPOS")
        Else
            filas = Me.GastosTableAdapter.Insert(descripcion, precio, Date.Now, 1)
            If (filas) Then
                MessageBox.Show("GASTO REGISTRADO CORRETAMENTE")
                Close()
            Else
                MessageBox.Show("OCURRIO UN ERROR AL GUARDAR LOS DATOS")
            End If
        End If
    End Sub
End Class