Public Class Inicioform

    Private Sub RegistrarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RegistrarToolStripMenuItem.Click
        My.Forms.registrarproveedor.MdiParent = Me
        registrarproveedor.Show()
    End Sub

    Private Sub ModificarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ModificarToolStripMenuItem.Click
        My.Forms.modificarproveedor.MdiParent = Me
        modificarproveedor.Show()
    End Sub

    Private Sub RegistrarToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles RegistrarToolStripMenuItem1.Click
        'registrar pollos
        My.Forms.pollos_registrar.MdiParent = Me
        pollos_registrar.Show()
    End Sub

    Private Sub CambiarPrecioKgToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CambiarPrecioKgToolStripMenuItem.Click
        'cambiar precio KG pollos
        My.Forms.cambiar_precio.MdiParent = Me
        cambiar_precio.Show()
    End Sub

    Private Sub RegistrarToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles RegistrarToolStripMenuItem2.Click
        'Registrar Cliente
        My.Forms.cliente_registrar.MdiParent = Me
        cliente_registrar.Show()
    End Sub

    Private Sub VentaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles VentaToolStripMenuItem.Click
        'registro venta
        My.Forms.venta_registrar.MdiParent = Me
        venta_registrar.Show()
    End Sub

    Private Sub RegstrarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RegstrarToolStripMenuItem.Click
        'registro gasto
        My.Forms.gasto_registrar.MdiParent = Me
        gasto_registrar.Show()
    End Sub

    Private Sub IngresosEgresosPorMesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles IngresosEgresosPorMesToolStripMenuItem.Click
        'ingresos egresos por mes
        My.Forms.ingresos_egresos_mes.MdiParent = Me
        ingresos_egresos_mes.Show()
    End Sub
End Class