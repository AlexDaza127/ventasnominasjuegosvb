<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ventaProductos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ventaProductos))
        Me.picProd1 = New System.Windows.Forms.PictureBox()
        Me.picProd3 = New System.Windows.Forms.PictureBox()
        Me.picProd2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.lblPagar = New System.Windows.Forms.Label()
        Me.lblDescuento = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSub = New System.Windows.Forms.TextBox()
        Me.txtCant = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radProd3 = New System.Windows.Forms.RadioButton()
        Me.radProd2 = New System.Windows.Forms.RadioButton()
        Me.radProd1 = New System.Windows.Forms.RadioButton()
        Me.btnCarrito = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Reloj = New System.Windows.Forms.Timer(Me.components)
        Me.btnLimpiar = New System.Windows.Forms.Button()
        CType(Me.picProd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picProd3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picProd2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'picProd1
        '
        Me.picProd1.Image = CType(resources.GetObject("picProd1.Image"), System.Drawing.Image)
        Me.picProd1.Location = New System.Drawing.Point(204, 65)
        Me.picProd1.Name = "picProd1"
        Me.picProd1.Size = New System.Drawing.Size(100, 86)
        Me.picProd1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picProd1.TabIndex = 35
        Me.picProd1.TabStop = False
        '
        'picProd3
        '
        Me.picProd3.Image = CType(resources.GetObject("picProd3.Image"), System.Drawing.Image)
        Me.picProd3.Location = New System.Drawing.Point(204, 65)
        Me.picProd3.Name = "picProd3"
        Me.picProd3.Size = New System.Drawing.Size(100, 86)
        Me.picProd3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picProd3.TabIndex = 33
        Me.picProd3.TabStop = False
        '
        'picProd2
        '
        Me.picProd2.Image = CType(resources.GetObject("picProd2.Image"), System.Drawing.Image)
        Me.picProd2.Location = New System.Drawing.Point(204, 65)
        Me.picProd2.Name = "picProd2"
        Me.picProd2.Size = New System.Drawing.Size(100, 86)
        Me.picProd2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picProd2.TabIndex = 34
        Me.picProd2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(377, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(190, 190)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(444, 280)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 28
        '
        'txtDesc
        '
        Me.txtDesc.Location = New System.Drawing.Point(444, 255)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(100, 20)
        Me.txtDesc.TabIndex = 27
        '
        'lblPagar
        '
        Me.lblPagar.AutoSize = True
        Me.lblPagar.Location = New System.Drawing.Point(353, 283)
        Me.lblPagar.Name = "lblPagar"
        Me.lblPagar.Size = New System.Drawing.Size(74, 13)
        Me.lblPagar.TabIndex = 26
        Me.lblPagar.Text = "Total a Pagar:"
        '
        'lblDescuento
        '
        Me.lblDescuento.AutoSize = True
        Me.lblDescuento.Location = New System.Drawing.Point(365, 261)
        Me.lblDescuento.Name = "lblDescuento"
        Me.lblDescuento.Size = New System.Drawing.Size(62, 13)
        Me.lblDescuento.TabIndex = 25
        Me.lblDescuento.Text = "Descuento:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(374, 236)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "SubTotal:"
        '
        'txtSub
        '
        Me.txtSub.Location = New System.Drawing.Point(444, 229)
        Me.txtSub.Name = "txtSub"
        Me.txtSub.Size = New System.Drawing.Size(100, 20)
        Me.txtSub.TabIndex = 23
        '
        'txtCant
        '
        Me.txtCant.Location = New System.Drawing.Point(266, 217)
        Me.txtCant.Name = "txtCant"
        Me.txtCant.Size = New System.Drawing.Size(38, 20)
        Me.txtCant.TabIndex = 22
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radProd3)
        Me.GroupBox1.Controls.Add(Me.radProd2)
        Me.GroupBox1.Controls.Add(Me.radProd1)
        Me.GroupBox1.Location = New System.Drawing.Point(29, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(133, 245)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Productos"
        '
        'radProd3
        '
        Me.radProd3.AutoSize = True
        Me.radProd3.Location = New System.Drawing.Point(28, 83)
        Me.radProd3.Name = "radProd3"
        Me.radProd3.Size = New System.Drawing.Size(57, 17)
        Me.radProd3.TabIndex = 2
        Me.radProd3.TabStop = True
        Me.radProd3.Text = "Portatil"
        Me.radProd3.UseVisualStyleBackColor = True
        '
        'radProd2
        '
        Me.radProd2.AutoSize = True
        Me.radProd2.Location = New System.Drawing.Point(28, 57)
        Me.radProd2.Name = "radProd2"
        Me.radProd2.Size = New System.Drawing.Size(68, 17)
        Me.radProd2.TabIndex = 1
        Me.radProd2.TabStop = True
        Me.radProd2.Text = "Televisor"
        Me.radProd2.UseVisualStyleBackColor = True
        '
        'radProd1
        '
        Me.radProd1.AutoSize = True
        Me.radProd1.Location = New System.Drawing.Point(28, 31)
        Me.radProd1.Name = "radProd1"
        Me.radProd1.Size = New System.Drawing.Size(83, 17)
        Me.radProd1.TabIndex = 0
        Me.radProd1.TabStop = True
        Me.radProd1.Text = "SmartPhone"
        Me.radProd1.UseVisualStyleBackColor = True
        '
        'btnCarrito
        '
        Me.btnCarrito.Location = New System.Drawing.Point(29, 312)
        Me.btnCarrito.Name = "btnCarrito"
        Me.btnCarrito.Size = New System.Drawing.Size(113, 23)
        Me.btnCarrito.TabIndex = 38
        Me.btnCarrito.Text = "Meter a Carrito"
        Me.btnCarrito.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(259, 13)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Elija su producto y presione el boton ""Meter a Carrito"""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(201, 220)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Cantidad: "
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Location = New System.Drawing.Point(265, 188)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(39, 13)
        Me.lblPrecio.TabIndex = 41
        Me.lblPrecio.Text = "Label6"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(213, 188)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "Precio: "
        '
        'Reloj
        '
        Me.Reloj.Interval = 200
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(229, 312)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 43
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'ventaProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(586, 347)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblPrecio)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnCarrito)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.picProd1)
        Me.Controls.Add(Me.picProd3)
        Me.Controls.Add(Me.picProd2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.lblPagar)
        Me.Controls.Add(Me.lblDescuento)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSub)
        Me.Controls.Add(Me.txtCant)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ventaProductos"
        Me.Text = "Venta de Productos"
        CType(Me.picProd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picProd3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picProd2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picProd1 As PictureBox
    Friend WithEvents picProd3 As PictureBox
    Friend WithEvents picProd2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtDesc As TextBox
    Friend WithEvents lblPagar As Label
    Friend WithEvents lblDescuento As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSub As TextBox
    Friend WithEvents txtCant As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radProd3 As RadioButton
    Friend WithEvents radProd2 As RadioButton
    Friend WithEvents radProd1 As RadioButton
    Friend WithEvents btnCarrito As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblPrecio As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Reloj As Timer
    Friend WithEvents btnLimpiar As Button
End Class
