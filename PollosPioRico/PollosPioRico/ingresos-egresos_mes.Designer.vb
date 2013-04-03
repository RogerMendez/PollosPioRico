<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ingresos_egresos_mes
    Inherits DevComponents.DotNetBar.Metro.MetroForm

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ingresos_egresos_mes))
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.ComboBoxEx1 = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Enero = New DevComponents.Editors.ComboItem()
        Me.Febrero = New DevComponents.Editors.ComboItem()
        Me.Marzo = New DevComponents.Editors.ComboItem()
        Me.Abril = New DevComponents.Editors.ComboItem()
        Me.Mayo = New DevComponents.Editors.ComboItem()
        Me.Junio = New DevComponents.Editors.ComboItem()
        Me.Julio = New DevComponents.Editors.ComboItem()
        Me.Agosto = New DevComponents.Editors.ComboItem()
        Me.Septiembre = New DevComponents.Editors.ComboItem()
        Me.Octubre = New DevComponents.Editors.ComboItem()
        Me.Noviembre = New DevComponents.Editors.ComboItem()
        Me.Diciembre = New DevComponents.Editors.ComboItem()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.ColumnHeader1 = New DevComponents.AdvTree.ColumnHeader()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.ButtonX3 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.total = New DevComponents.DotNetBar.LabelX()
        Me.pollos = New DevComponents.DotNetBar.LabelX()
        Me.gasto = New DevComponents.DotNetBar.LabelX()
        Me.venta = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.Line1 = New DevComponents.DotNetBar.Controls.Line()
        Me.QueriesTableAdapter1 = New PollosPioRico.pollosDataSetTableAdapters.QueriesTableAdapter()
        Me.GroupPanel1.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupPanel1
        '
        Me.GroupPanel1.BackColor = System.Drawing.Color.White
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.ButtonX1)
        Me.GroupPanel1.Controls.Add(Me.ComboBoxEx1)
        Me.GroupPanel1.Controls.Add(Me.LabelX1)
        Me.GroupPanel1.Location = New System.Drawing.Point(12, 12)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(637, 95)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderBottomWidth = 1
        Me.GroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderLeftWidth = 1
        Me.GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderRightWidth = 1
        Me.GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderTopWidth = 1
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 0
        Me.GroupPanel1.Text = "Seleccionar Mes"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(331, 3)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(75, 29)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 4
        Me.ButtonX1.Text = "Mostrar"
        '
        'ComboBoxEx1
        '
        Me.ComboBoxEx1.DisplayMember = "Text"
        Me.ComboBoxEx1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBoxEx1.FormattingEnabled = True
        Me.ComboBoxEx1.ItemHeight = 23
        Me.ComboBoxEx1.Items.AddRange(New Object() {Me.Enero, Me.Febrero, Me.Marzo, Me.Abril, Me.Mayo, Me.Junio, Me.Julio, Me.Agosto, Me.Septiembre, Me.Octubre, Me.Noviembre, Me.Diciembre})
        Me.ComboBoxEx1.Location = New System.Drawing.Point(84, 3)
        Me.ComboBoxEx1.Name = "ComboBoxEx1"
        Me.ComboBoxEx1.Size = New System.Drawing.Size(229, 29)
        Me.ComboBoxEx1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ComboBoxEx1.TabIndex = 3
        '
        'Enero
        '
        Me.Enero.Text = "Enero"
        Me.Enero.Value = "1"
        '
        'Febrero
        '
        Me.Febrero.Text = "Febrero"
        '
        'Marzo
        '
        Me.Marzo.Text = "Marzo"
        '
        'Abril
        '
        Me.Abril.Text = "Abril"
        '
        'Mayo
        '
        Me.Mayo.Text = "Mayo"
        '
        'Junio
        '
        Me.Junio.Text = "Junio"
        '
        'Julio
        '
        Me.Julio.Text = "Julio"
        '
        'Agosto
        '
        Me.Agosto.Text = "Agosto"
        '
        'Septiembre
        '
        Me.Septiembre.Text = "Septiembre"
        '
        'Octubre
        '
        Me.Octubre.Text = "Octubre"
        '
        'Noviembre
        '
        Me.Noviembre.Text = "Noviembre"
        '
        'Diciembre
        '
        Me.Diciembre.Text = "Diciembre"
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.WhiteSmoke
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(3, 3)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(75, 23)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "Mes:"
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.DisplayIndex = 1
        Me.ColumnHeader1.Name = "ColumnHeader1"
        Me.ColumnHeader1.Text = "Enero"
        Me.ColumnHeader1.Width.Absolute = 150
        '
        'GroupPanel2
        '
        Me.GroupPanel2.BackColor = System.Drawing.Color.White
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.ButtonX3)
        Me.GroupPanel2.Controls.Add(Me.ButtonX2)
        Me.GroupPanel2.Controls.Add(Me.total)
        Me.GroupPanel2.Controls.Add(Me.pollos)
        Me.GroupPanel2.Controls.Add(Me.gasto)
        Me.GroupPanel2.Controls.Add(Me.venta)
        Me.GroupPanel2.Controls.Add(Me.LabelX4)
        Me.GroupPanel2.Controls.Add(Me.LabelX3)
        Me.GroupPanel2.Controls.Add(Me.LabelX2)
        Me.GroupPanel2.Controls.Add(Me.Line1)
        Me.GroupPanel2.Location = New System.Drawing.Point(12, 113)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(637, 280)
        '
        '
        '
        Me.GroupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel2.Style.BackColorGradientAngle = 90
        Me.GroupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderBottomWidth = 1
        Me.GroupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderLeftWidth = 1
        Me.GroupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderRightWidth = 1
        Me.GroupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderTopWidth = 1
        Me.GroupPanel2.Style.CornerDiameter = 4
        Me.GroupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel2.TabIndex = 1
        Me.GroupPanel2.Text = "Ingresos - Egresos"
        '
        'ButtonX3
        '
        Me.ButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX3.Location = New System.Drawing.Point(446, 71)
        Me.ButtonX3.Name = "ButtonX3"
        Me.ButtonX3.Size = New System.Drawing.Size(108, 27)
        Me.ButtonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX3.TabIndex = 9
        Me.ButtonX3.Text = "Detalle Gastos"
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Location = New System.Drawing.Point(446, 34)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(108, 27)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX2.TabIndex = 8
        Me.ButtonX2.Text = "Detalle Ventas"
        '
        'total
        '
        '
        '
        '
        Me.total.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.total.Location = New System.Drawing.Point(310, 162)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(96, 23)
        Me.total.TabIndex = 7
        Me.total.Text = "000000,00"
        Me.total.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'pollos
        '
        '
        '
        '
        Me.pollos.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.pollos.Location = New System.Drawing.Point(310, 114)
        Me.pollos.Name = "pollos"
        Me.pollos.Size = New System.Drawing.Size(96, 23)
        Me.pollos.TabIndex = 6
        Me.pollos.Text = "000000,00"
        Me.pollos.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'gasto
        '
        '
        '
        '
        Me.gasto.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.gasto.Location = New System.Drawing.Point(310, 75)
        Me.gasto.Name = "gasto"
        Me.gasto.Size = New System.Drawing.Size(96, 23)
        Me.gasto.TabIndex = 5
        Me.gasto.Text = "0000"
        Me.gasto.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'venta
        '
        '
        '
        '
        Me.venta.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.venta.Location = New System.Drawing.Point(310, 34)
        Me.venta.Name = "venta"
        Me.venta.Size = New System.Drawing.Size(96, 23)
        Me.venta.TabIndex = 4
        Me.venta.Text = "0000"
        Me.venta.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX4
        '
        Me.LabelX4.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.Location = New System.Drawing.Point(3, 114)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(171, 23)
        Me.LabelX4.TabIndex = 3
        Me.LabelX4.Text = "Total Compra Pollos:"
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.Location = New System.Drawing.Point(3, 75)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(110, 23)
        Me.LabelX3.TabIndex = 2
        Me.LabelX3.Text = "Total Gastos:"
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.Location = New System.Drawing.Point(3, 34)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(110, 23)
        Me.LabelX2.TabIndex = 1
        Me.LabelX2.Text = "Total Ventas:"
        '
        'Line1
        '
        Me.Line1.Location = New System.Drawing.Point(258, 146)
        Me.Line1.Name = "Line1"
        Me.Line1.Size = New System.Drawing.Size(223, 10)
        Me.Line1.TabIndex = 0
        Me.Line1.Text = "Line1"
        '
        'ingresos_egresos_mes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(863, 461)
        Me.Controls.Add(Me.GroupPanel2)
        Me.Controls.Add(Me.GroupPanel1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "ingresos_egresos_mes"
        Me.Text = "Ingresos - Egresos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ColumnHeader1 As DevComponents.AdvTree.ColumnHeader
    Friend WithEvents ComboBoxEx1 As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Enero As DevComponents.Editors.ComboItem
    Friend WithEvents Febrero As DevComponents.Editors.ComboItem
    Friend WithEvents Marzo As DevComponents.Editors.ComboItem
    Friend WithEvents Abril As DevComponents.Editors.ComboItem
    Friend WithEvents Mayo As DevComponents.Editors.ComboItem
    Friend WithEvents Junio As DevComponents.Editors.ComboItem
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Julio As DevComponents.Editors.ComboItem
    Friend WithEvents Agosto As DevComponents.Editors.ComboItem
    Friend WithEvents Septiembre As DevComponents.Editors.ComboItem
    Friend WithEvents Octubre As DevComponents.Editors.ComboItem
    Friend WithEvents Noviembre As DevComponents.Editors.ComboItem
    Friend WithEvents Diciembre As DevComponents.Editors.ComboItem
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents pollos As DevComponents.DotNetBar.LabelX
    Friend WithEvents gasto As DevComponents.DotNetBar.LabelX
    Friend WithEvents venta As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Line1 As DevComponents.DotNetBar.Controls.Line
    Friend WithEvents ButtonX3 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents total As DevComponents.DotNetBar.LabelX
    Friend WithEvents QueriesTableAdapter1 As PollosPioRico.pollosDataSetTableAdapters.QueriesTableAdapter
End Class
