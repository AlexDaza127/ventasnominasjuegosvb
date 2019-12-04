<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Nomina
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Nomina))
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.lblSueldoNeto = New System.Windows.Forms.Label()
        Me.lblTurno = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lblTotalE = New System.Windows.Forms.Label()
        Me.lblPRestamos = New System.Windows.Forms.Label()
        Me.lblFondo = New System.Windows.Forms.Label()
        Me.lblPrencion = New System.Windows.Forms.Label()
        Me.lblERP = New System.Windows.Forms.Label()
        Me.lblEPS = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cbPrestamos = New System.Windows.Forms.CheckBox()
        Me.cbFondo = New System.Windows.Forms.CheckBox()
        Me.cbPension = New System.Windows.Forms.CheckBox()
        Me.cbERP = New System.Windows.Forms.CheckBox()
        Me.cbEPS = New System.Windows.Forms.CheckBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblTotalI = New System.Windows.Forms.Label()
        Me.lblAT = New System.Windows.Forms.Label()
        Me.lblPHE = New System.Windows.Forms.Label()
        Me.lblSalario = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbNocturno = New System.Windows.Forms.RadioButton()
        Me.rbdiurno = New System.Windows.Forms.RadioButton()
        Me.txtHE = New System.Windows.Forms.TextBox()
        Me.txtsalario = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtapellido = New System.Windows.Forms.TextBox()
        Me.txtnom = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Erroricono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ttmensaje = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Erroricono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(741, 375)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "Salir"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(365, 375)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(102, 23)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Borrar Registros"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(580, 229)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = " Calcular"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.lblSueldoNeto)
        Me.GroupBox5.Controls.Add(Me.lblTurno)
        Me.GroupBox5.Controls.Add(Me.lblNombre)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Location = New System.Drawing.Point(425, 256)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(391, 113)
        Me.GroupBox5.TabIndex = 14
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Resultados"
        '
        'lblSueldoNeto
        '
        Me.lblSueldoNeto.AutoSize = True
        Me.lblSueldoNeto.Location = New System.Drawing.Point(96, 79)
        Me.lblSueldoNeto.Name = "lblSueldoNeto"
        Me.lblSueldoNeto.Size = New System.Drawing.Size(73, 13)
        Me.lblSueldoNeto.TabIndex = 19
        Me.lblSueldoNeto.Text = "......................"
        '
        'lblTurno
        '
        Me.lblTurno.AutoSize = True
        Me.lblTurno.Location = New System.Drawing.Point(66, 55)
        Me.lblTurno.Name = "lblTurno"
        Me.lblTurno.Size = New System.Drawing.Size(73, 13)
        Me.lblTurno.TabIndex = 18
        Me.lblTurno.Text = "......................"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(75, 32)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(73, 13)
        Me.lblNombre.TabIndex = 17
        Me.lblNombre.Text = "......................"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(22, 79)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(68, 13)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = " Salario Neto"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(22, 55)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(38, 13)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Turno:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(22, 32)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(47, 13)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Nombre:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.lblTotalE)
        Me.GroupBox4.Controls.Add(Me.lblPRestamos)
        Me.GroupBox4.Controls.Add(Me.lblFondo)
        Me.GroupBox4.Controls.Add(Me.lblPrencion)
        Me.GroupBox4.Controls.Add(Me.lblERP)
        Me.GroupBox4.Controls.Add(Me.lblEPS)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.cbPrestamos)
        Me.GroupBox4.Controls.Add(Me.cbFondo)
        Me.GroupBox4.Controls.Add(Me.cbPension)
        Me.GroupBox4.Controls.Add(Me.cbERP)
        Me.GroupBox4.Controls.Add(Me.cbEPS)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Location = New System.Drawing.Point(425, 30)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(391, 193)
        Me.GroupBox4.TabIndex = 15
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Egresos"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(22, 16)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(310, 13)
        Me.Label18.TabIndex = 17
        Me.Label18.Text = "Seleccione los campos para generar los respectivos descuentos"
        '
        'lblTotalE
        '
        Me.lblTotalE.AutoSize = True
        Me.lblTotalE.Location = New System.Drawing.Point(300, 176)
        Me.lblTotalE.Name = "lblTotalE"
        Me.lblTotalE.Size = New System.Drawing.Size(73, 13)
        Me.lblTotalE.TabIndex = 16
        Me.lblTotalE.Text = "......................"
        '
        'lblPRestamos
        '
        Me.lblPRestamos.AutoSize = True
        Me.lblPRestamos.Location = New System.Drawing.Point(301, 142)
        Me.lblPRestamos.Name = "lblPRestamos"
        Me.lblPRestamos.Size = New System.Drawing.Size(73, 13)
        Me.lblPRestamos.TabIndex = 15
        Me.lblPRestamos.Text = "......................"
        '
        'lblFondo
        '
        Me.lblFondo.AutoSize = True
        Me.lblFondo.Location = New System.Drawing.Point(301, 116)
        Me.lblFondo.Name = "lblFondo"
        Me.lblFondo.Size = New System.Drawing.Size(73, 13)
        Me.lblFondo.TabIndex = 14
        Me.lblFondo.Text = "......................"
        '
        'lblPrencion
        '
        Me.lblPrencion.AutoSize = True
        Me.lblPrencion.Location = New System.Drawing.Point(301, 93)
        Me.lblPrencion.Name = "lblPrencion"
        Me.lblPrencion.Size = New System.Drawing.Size(73, 13)
        Me.lblPrencion.TabIndex = 13
        Me.lblPrencion.Text = "......................"
        '
        'lblERP
        '
        Me.lblERP.AutoSize = True
        Me.lblERP.Location = New System.Drawing.Point(301, 69)
        Me.lblERP.Name = "lblERP"
        Me.lblERP.Size = New System.Drawing.Size(73, 13)
        Me.lblERP.TabIndex = 12
        Me.lblERP.Text = "......................"
        '
        'lblEPS
        '
        Me.lblEPS.AutoSize = True
        Me.lblEPS.Location = New System.Drawing.Point(301, 47)
        Me.lblEPS.Name = "lblEPS"
        Me.lblEPS.Size = New System.Drawing.Size(73, 13)
        Me.lblEPS.TabIndex = 11
        Me.lblEPS.Text = "......................"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(246, 177)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(48, 13)
        Me.Label17.TabIndex = 10
        Me.Label17.Text = "TOTAL: "
        '
        'cbPrestamos
        '
        Me.cbPrestamos.AutoSize = True
        Me.cbPrestamos.Location = New System.Drawing.Point(37, 135)
        Me.cbPrestamos.Name = "cbPrestamos"
        Me.cbPrestamos.Size = New System.Drawing.Size(75, 17)
        Me.cbPrestamos.TabIndex = 9
        Me.cbPrestamos.Text = "Prestamos"
        Me.cbPrestamos.UseVisualStyleBackColor = True
        '
        'cbFondo
        '
        Me.cbFondo.AutoSize = True
        Me.cbFondo.Location = New System.Drawing.Point(37, 112)
        Me.cbFondo.Name = "cbFondo"
        Me.cbFondo.Size = New System.Drawing.Size(56, 17)
        Me.cbFondo.TabIndex = 8
        Me.cbFondo.Text = "Fondo"
        Me.cbFondo.UseVisualStyleBackColor = True
        '
        'cbPension
        '
        Me.cbPension.AutoSize = True
        Me.cbPension.Location = New System.Drawing.Point(37, 89)
        Me.cbPension.Name = "cbPension"
        Me.cbPension.Size = New System.Drawing.Size(64, 17)
        Me.cbPension.TabIndex = 7
        Me.cbPension.Text = "Pension"
        Me.cbPension.UseVisualStyleBackColor = True
        '
        'cbERP
        '
        Me.cbERP.AutoSize = True
        Me.cbERP.Location = New System.Drawing.Point(36, 66)
        Me.cbERP.Name = "cbERP"
        Me.cbERP.Size = New System.Drawing.Size(48, 17)
        Me.cbERP.TabIndex = 6
        Me.cbERP.Text = "ERP"
        Me.cbERP.UseVisualStyleBackColor = True
        '
        'cbEPS
        '
        Me.cbEPS.AutoSize = True
        Me.cbEPS.Location = New System.Drawing.Point(37, 43)
        Me.cbEPS.Name = "cbEPS"
        Me.cbEPS.Size = New System.Drawing.Size(47, 17)
        Me.cbEPS.TabIndex = 5
        Me.cbEPS.Text = "EPS"
        Me.cbEPS.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(141, 142)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(169, 13)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "......................................................"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(141, 116)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(169, 13)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "......................................................"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(141, 93)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(169, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "......................................................"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(141, 70)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(169, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "......................................................"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(141, 47)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(169, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "......................................................"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblTotalI)
        Me.GroupBox3.Controls.Add(Me.lblAT)
        Me.GroupBox3.Controls.Add(Me.lblPHE)
        Me.GroupBox3.Controls.Add(Me.lblSalario)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 224)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(391, 145)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = " Ingresos"
        '
        'lblTotalI
        '
        Me.lblTotalI.AutoSize = True
        Me.lblTotalI.Location = New System.Drawing.Point(260, 102)
        Me.lblTotalI.Name = "lblTotalI"
        Me.lblTotalI.Size = New System.Drawing.Size(73, 13)
        Me.lblTotalI.TabIndex = 7
        Me.lblTotalI.Text = "......................"
        '
        'lblAT
        '
        Me.lblAT.AutoSize = True
        Me.lblAT.Location = New System.Drawing.Point(260, 79)
        Me.lblAT.Name = "lblAT"
        Me.lblAT.Size = New System.Drawing.Size(73, 13)
        Me.lblAT.TabIndex = 6
        Me.lblAT.Text = "......................"
        '
        'lblPHE
        '
        Me.lblPHE.AutoSize = True
        Me.lblPHE.Location = New System.Drawing.Point(260, 55)
        Me.lblPHE.Name = "lblPHE"
        Me.lblPHE.Size = New System.Drawing.Size(73, 13)
        Me.lblPHE.TabIndex = 5
        Me.lblPHE.Text = "......................"
        '
        'lblSalario
        '
        Me.lblSalario.AutoSize = True
        Me.lblSalario.Location = New System.Drawing.Point(260, 32)
        Me.lblSalario.Name = "lblSalario"
        Me.lblSalario.Size = New System.Drawing.Size(73, 13)
        Me.lblSalario.TabIndex = 4
        Me.lblSalario.Text = "......................"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(216, 102)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(48, 13)
        Me.Label16.TabIndex = 3
        Me.Label16.Text = "TOTAL: "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 79)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(244, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Auxilio de Transporte: ............................................"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(242, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Pago por Horas Extras: ........................................."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(242, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Salario Basico: ......................................................"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbNocturno)
        Me.GroupBox2.Controls.Add(Me.rbdiurno)
        Me.GroupBox2.Controls.Add(Me.txtHE)
        Me.GroupBox2.Controls.Add(Me.txtsalario)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 124)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(391, 88)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Salario"
        '
        'rbNocturno
        '
        Me.rbNocturno.AutoSize = True
        Me.rbNocturno.Location = New System.Drawing.Point(296, 49)
        Me.rbNocturno.Name = "rbNocturno"
        Me.rbNocturno.Size = New System.Drawing.Size(69, 17)
        Me.rbNocturno.TabIndex = 5
        Me.rbNocturno.Text = "Nocturno"
        Me.rbNocturno.UseVisualStyleBackColor = True
        '
        'rbdiurno
        '
        Me.rbdiurno.AutoSize = True
        Me.rbdiurno.Checked = True
        Me.rbdiurno.Location = New System.Drawing.Point(232, 50)
        Me.rbdiurno.Name = "rbdiurno"
        Me.rbdiurno.Size = New System.Drawing.Size(56, 17)
        Me.rbdiurno.TabIndex = 4
        Me.rbdiurno.TabStop = True
        Me.rbdiurno.Text = "Diurno"
        Me.rbdiurno.UseVisualStyleBackColor = True
        '
        'txtHE
        '
        Me.txtHE.Location = New System.Drawing.Point(102, 48)
        Me.txtHE.Name = "txtHE"
        Me.txtHE.Size = New System.Drawing.Size(69, 20)
        Me.txtHE.TabIndex = 3
        '
        'txtsalario
        '
        Me.txtsalario.Location = New System.Drawing.Point(102, 24)
        Me.txtsalario.Name = "txtsalario"
        Me.txtsalario.Size = New System.Drawing.Size(263, 20)
        Me.txtsalario.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Horas Extras:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Salario Basico:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtapellido)
        Me.GroupBox1.Controls.Add(Me.txtnom)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(391, 88)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Personales"
        '
        'txtapellido
        '
        Me.txtapellido.Location = New System.Drawing.Point(102, 48)
        Me.txtapellido.Name = "txtapellido"
        Me.txtapellido.Size = New System.Drawing.Size(263, 20)
        Me.txtapellido.TabIndex = 3
        '
        'txtnom
        '
        Me.txtnom.Location = New System.Drawing.Point(102, 24)
        Me.txtnom.Name = "txtnom"
        Me.txtnom.Size = New System.Drawing.Size(263, 20)
        Me.txtnom.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Apellido:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre:"
        '
        'Erroricono
        '
        Me.Erroricono.ContainerControl = Me
        '
        'ttmensaje
        '
        Me.ttmensaje.IsBalloon = True
        '
        'Nomina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(822, 404)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Nomina"
        Me.Text = "Nomina Trabajador Fabrica"
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Erroricono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents lblSueldoNeto As Label
    Friend WithEvents lblTurno As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label18 As Label
    Friend WithEvents lblTotalE As Label
    Friend WithEvents lblPRestamos As Label
    Friend WithEvents lblFondo As Label
    Friend WithEvents lblPrencion As Label
    Friend WithEvents lblERP As Label
    Friend WithEvents lblEPS As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents cbPrestamos As CheckBox
    Friend WithEvents cbFondo As CheckBox
    Friend WithEvents cbPension As CheckBox
    Friend WithEvents cbERP As CheckBox
    Friend WithEvents cbEPS As CheckBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lblTotalI As Label
    Friend WithEvents lblAT As Label
    Friend WithEvents lblPHE As Label
    Friend WithEvents lblSalario As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rbNocturno As RadioButton
    Friend WithEvents rbdiurno As RadioButton
    Friend WithEvents txtHE As TextBox
    Friend WithEvents txtsalario As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtapellido As TextBox
    Friend WithEvents txtnom As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Erroricono As ErrorProvider
    Friend WithEvents ttmensaje As ToolTip
End Class
