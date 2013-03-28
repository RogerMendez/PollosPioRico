Public Class proveedor_seleccionar
    Public nit As String

    Private Sub proveedor_seleccionar_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PollosDataSet.proveedor' Puede moverla o quitarla según sea necesario.
        Me.ProveedorTableAdapter.Fill(Me.PollosDataSet.proveedor)
        nit = String.Empty
    End Sub

    Private Sub TextBoxX1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBoxX1.TextChanged
        If (TextBoxX1.Text.Length <= 0) Then
            Me.ProveedorTableAdapter.Fill(Me.PollosDataSet.proveedor)
        Else
            Me.ProveedorTableAdapter.proveedor_buscar(Me.PollosDataSet.proveedor, TextBoxX1.Text)
        End If
    End Sub

    Private Sub DataGridViewX1_DoubleClick(sender As System.Object, e As System.EventArgs) Handles DataGridViewX1.DoubleClick
        nit = PollosDataSet.proveedor(Me.ProveedorBindingSource.Position).NITpro
        Close()
    End Sub

    Private Sub ButtonX1_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX1.Click
        nit = PollosDataSet.proveedor(Me.ProveedorBindingSource.Position).NITpro
        Close()
    End Sub

    Private Sub ButtonX2_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX2.Click
        'cancelar
        Close()
    End Sub
End Class