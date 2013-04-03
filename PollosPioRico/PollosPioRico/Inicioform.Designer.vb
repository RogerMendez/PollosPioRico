<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicioform
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inicioform))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PollosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CambiarPrecioKgToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GastoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegstrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresosEgresosPorMesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuStrip1.Font = New System.Drawing.Font("News701 BT", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProveedoresToolStripMenuItem, Me.PollosToolStripMenuItem, Me.ClienteToolStripMenuItem, Me.GastoToolStripMenuItem, Me.VentaToolStripMenuItem, Me.ReportesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(170, 562)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrarToolStripMenuItem, Me.ModificarToolStripMenuItem})
        Me.ProveedoresToolStripMenuItem.Image = Global.PollosPioRico.My.Resources.Resources.Dapino_Cute_Chicken_Chicken_egg_shell1
        Me.ProveedoresToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(157, 44)
        Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
        '
        'RegistrarToolStripMenuItem
        '
        Me.RegistrarToolStripMenuItem.Name = "RegistrarToolStripMenuItem"
        Me.RegistrarToolStripMenuItem.Size = New System.Drawing.Size(160, 24)
        Me.RegistrarToolStripMenuItem.Text = "Registrar"
        '
        'ModificarToolStripMenuItem
        '
        Me.ModificarToolStripMenuItem.Name = "ModificarToolStripMenuItem"
        Me.ModificarToolStripMenuItem.Size = New System.Drawing.Size(160, 24)
        Me.ModificarToolStripMenuItem.Text = "Modificar"
        '
        'PollosToolStripMenuItem
        '
        Me.PollosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrarToolStripMenuItem1, Me.CambiarPrecioKgToolStripMenuItem})
        Me.PollosToolStripMenuItem.Image = Global.PollosPioRico.My.Resources.Resources.Dapino_Cute_Chicken_New_born_chicken
        Me.PollosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PollosToolStripMenuItem.Name = "PollosToolStripMenuItem"
        Me.PollosToolStripMenuItem.Size = New System.Drawing.Size(157, 44)
        Me.PollosToolStripMenuItem.Text = "Pollos"
        '
        'RegistrarToolStripMenuItem1
        '
        Me.RegistrarToolStripMenuItem1.Name = "RegistrarToolStripMenuItem1"
        Me.RegistrarToolStripMenuItem1.Size = New System.Drawing.Size(235, 24)
        Me.RegistrarToolStripMenuItem1.Text = "Registrar"
        '
        'CambiarPrecioKgToolStripMenuItem
        '
        Me.CambiarPrecioKgToolStripMenuItem.Name = "CambiarPrecioKgToolStripMenuItem"
        Me.CambiarPrecioKgToolStripMenuItem.Size = New System.Drawing.Size(235, 24)
        Me.CambiarPrecioKgToolStripMenuItem.Text = "Cambiar Precio kg."
        '
        'ClienteToolStripMenuItem
        '
        Me.ClienteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrarToolStripMenuItem2})
        Me.ClienteToolStripMenuItem.Image = Global.PollosPioRico.My.Resources.Resources.Dapino_Cute_Chicken_Waving_chicken
        Me.ClienteToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ClienteToolStripMenuItem.Name = "ClienteToolStripMenuItem"
        Me.ClienteToolStripMenuItem.Size = New System.Drawing.Size(157, 44)
        Me.ClienteToolStripMenuItem.Text = "Cliente"
        '
        'RegistrarToolStripMenuItem2
        '
        Me.RegistrarToolStripMenuItem2.Name = "RegistrarToolStripMenuItem2"
        Me.RegistrarToolStripMenuItem2.Size = New System.Drawing.Size(155, 24)
        Me.RegistrarToolStripMenuItem2.Text = "Registrar"
        '
        'GastoToolStripMenuItem
        '
        Me.GastoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegstrarToolStripMenuItem})
        Me.GastoToolStripMenuItem.Image = Global.PollosPioRico.My.Resources.Resources.Dapino_Cute_Chicken_Chicken_egg_shell_top
        Me.GastoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.GastoToolStripMenuItem.Name = "GastoToolStripMenuItem"
        Me.GastoToolStripMenuItem.Size = New System.Drawing.Size(157, 44)
        Me.GastoToolStripMenuItem.Text = "Gasto"
        '
        'RegstrarToolStripMenuItem
        '
        Me.RegstrarToolStripMenuItem.Name = "RegstrarToolStripMenuItem"
        Me.RegstrarToolStripMenuItem.Size = New System.Drawing.Size(155, 24)
        Me.RegstrarToolStripMenuItem.Text = "Registrar"
        '
        'VentaToolStripMenuItem
        '
        Me.VentaToolStripMenuItem.Image = Global.PollosPioRico.My.Resources.Resources.Dapino_Cute_Chicken_Party_chicken
        Me.VentaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.VentaToolStripMenuItem.Name = "VentaToolStripMenuItem"
        Me.VentaToolStripMenuItem.Size = New System.Drawing.Size(157, 44)
        Me.VentaToolStripMenuItem.Text = "Venta"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IngresosEgresosPorMesToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Image = Global.PollosPioRico.My.Resources.Resources.Dapino_Cute_Chicken_Singing_chicken
        Me.ReportesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(157, 44)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'IngresosEgresosPorMesToolStripMenuItem
        '
        Me.IngresosEgresosPorMesToolStripMenuItem.Name = "IngresosEgresosPorMesToolStripMenuItem"
        Me.IngresosEgresosPorMesToolStripMenuItem.Size = New System.Drawing.Size(308, 24)
        Me.IngresosEgresosPorMesToolStripMenuItem.Text = "Ingresos - Egresos (Por Mes)"
        '
        'Inicioform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Inicioform"
        Me.Text = "Inicio"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ProveedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistrarToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VentaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PollosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistrarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CambiarPrecioKgToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GastoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegstrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IngresosEgresosPorMesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
