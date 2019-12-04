<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Presentacion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Presentacion))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.opcMDI = New System.Windows.Forms.ToolStripMenuItem()
        Me.opcNomina = New System.Windows.Forms.ToolStripMenuItem()
        Me.opcVentasProduc = New System.Windows.Forms.ToolStripMenuItem()
        Me.opcTicTacToe = New System.Windows.Forms.ToolStripMenuItem()
        Me.opcConcentrese = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.opcCreditos = New System.Windows.Forms.ToolStripMenuItem()
        Me.opcSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.opcMDI})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(934, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'opcMDI
        '
        Me.opcMDI.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.opcNomina, Me.opcVentasProduc, Me.opcTicTacToe, Me.opcConcentrese, Me.ToolStripSeparator5, Me.opcCreditos, Me.opcSalir})
        Me.opcMDI.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.opcMDI.Name = "opcMDI"
        Me.opcMDI.Size = New System.Drawing.Size(86, 20)
        Me.opcMDI.Text = "Aplicaciones"
        '
        'opcNomina
        '
        Me.opcNomina.Image = CType(resources.GetObject("opcNomina.Image"), System.Drawing.Image)
        Me.opcNomina.ImageTransparentColor = System.Drawing.Color.Black
        Me.opcNomina.Name = "opcNomina"
        Me.opcNomina.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.opcNomina.Size = New System.Drawing.Size(260, 22)
        Me.opcNomina.Text = "&Nomina Trabajador Fabrica"
        '
        'opcVentasProduc
        '
        Me.opcVentasProduc.Image = CType(resources.GetObject("opcVentasProduc.Image"), System.Drawing.Image)
        Me.opcVentasProduc.ImageTransparentColor = System.Drawing.Color.Black
        Me.opcVentasProduc.Name = "opcVentasProduc"
        Me.opcVentasProduc.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.opcVentasProduc.Size = New System.Drawing.Size(260, 22)
        Me.opcVentasProduc.Text = "&Venta de Productos"
        '
        'opcTicTacToe
        '
        Me.opcTicTacToe.Image = CType(resources.GetObject("opcTicTacToe.Image"), System.Drawing.Image)
        Me.opcTicTacToe.ImageTransparentColor = System.Drawing.Color.Black
        Me.opcTicTacToe.Name = "opcTicTacToe"
        Me.opcTicTacToe.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.opcTicTacToe.Size = New System.Drawing.Size(260, 22)
        Me.opcTicTacToe.Text = "&Tic Tac Toe"
        '
        'opcConcentrese
        '
        Me.opcConcentrese.Image = CType(resources.GetObject("opcConcentrese.Image"), System.Drawing.Image)
        Me.opcConcentrese.Name = "opcConcentrese"
        Me.opcConcentrese.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.opcConcentrese.Size = New System.Drawing.Size(260, 22)
        Me.opcConcentrese.Text = "&Concentrese"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(214, 6)
        '
        'opcCreditos
        '
        Me.opcCreditos.Image = CType(resources.GetObject("opcCreditos.Image"), System.Drawing.Image)
        Me.opcCreditos.Name = "opcCreditos"
        Me.opcCreditos.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.opcCreditos.Size = New System.Drawing.Size(260, 22)
        Me.opcCreditos.Text = "C&reditos"
        '
        'opcSalir
        '
        Me.opcSalir.Image = CType(resources.GetObject("opcSalir.Image"), System.Drawing.Image)
        Me.opcSalir.Name = "opcSalir"
        Me.opcSalir.Size = New System.Drawing.Size(260, 22)
        Me.opcSalir.Text = "&Salir"
        '
        'Presentacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(934, 511)
        Me.Controls.Add(Me.MenuStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Presentacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Presentacion"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents opcSalir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents opcConcentrese As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents opcNomina As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents opcMDI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents opcVentasProduc As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents opcTicTacToe As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents opcCreditos As ToolStripMenuItem
End Class
