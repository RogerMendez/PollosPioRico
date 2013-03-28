Public Class cliente_seleccionar
    Public cod As Integer
    Public nombre As String

    Private Sub cliente_seleccionar_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PollosDataSet.cliente' Puede moverla o quitarla según sea necesario.
        Me.ClienteTableAdapter.Fill(Me.PollosDataSet.cliente)
        cod = Nothing
        nombre = String.Empty
    End Sub

    Private Sub DataGridViewX1_DoubleClick(sender As System.Object, e As System.EventArgs) Handles DataGridViewX1.DoubleClick
        cod = Me.PollosDataSet.cliente(Me.ClienteBindingSource.Position).cod_cli
        nombre = Me.PollosDataSet.cliente(Me.ClienteBindingSource.Position).nombre
        Close()
    End Sub

    Private Sub ButtonX1_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX1.Click
        cod = Me.PollosDataSet.cliente(Me.ClienteBindingSource.Position).cod_cli
        nombre = Me.PollosDataSet.cliente(Me.ClienteBindingSource.Position).nombre
        Close()
    End Sub

    Private Sub ButtonX2_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX2.Click
        Close()
    End Sub

    Private Sub TextBoxX1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBoxX1.TextChanged
        If (TextBoxX1.Text.Length > 0) Then
            Me.ClienteTableAdapter.cliente_buscar(Me.PollosDataSet.cliente, TextBoxX1.Text)
        Else
            Me.ClienteTableAdapter.Fill(Me.PollosDataSet.cliente)
        End If
    End Sub
End Class