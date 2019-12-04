<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registro))
        Me.pnlingreso = New System.Windows.Forms.Panel()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlingreso.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlingreso
        '
        Me.pnlingreso.Controls.Add(Me.btnIngresar)
        Me.pnlingreso.Controls.Add(Me.txtPass)
        Me.pnlingreso.Controls.Add(Me.txtUsuario)
        Me.pnlingreso.Controls.Add(Me.Label2)
        Me.pnlingreso.Controls.Add(Me.Label1)
        Me.pnlingreso.Location = New System.Drawing.Point(77, 49)
        Me.pnlingreso.Name = "pnlingreso"
        Me.pnlingreso.Size = New System.Drawing.Size(237, 133)
        Me.pnlingreso.TabIndex = 8
        '
        'btnIngresar
        '
        Me.btnIngresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresar.Location = New System.Drawing.Point(84, 96)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(75, 23)
        Me.btnIngresar.TabIndex = 4
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(114, 57)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(100, 20)
        Me.txtPass.TabIndex = 3
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(114, 22)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(100, 20)
        Me.txtUsuario.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MV Boli", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Contraseña"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario"
        '
        'Registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(391, 230)
        Me.Controls.Add(Me.pnlingreso)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Registro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Usuario"
        Me.pnlingreso.ResumeLayout(False)
        Me.pnlingreso.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlingreso As Panel
    Friend WithEvents btnIngresar As Button
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
