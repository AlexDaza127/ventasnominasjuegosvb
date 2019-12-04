<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ticTacToe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ticTacToe))
        Me.bntLimpiar = New System.Windows.Forms.Button()
        Me.lblMsgGan = New System.Windows.Forms.Label()
        Me.A1 = New System.Windows.Forms.Button()
        Me.A2 = New System.Windows.Forms.Button()
        Me.A3 = New System.Windows.Forms.Button()
        Me.B1 = New System.Windows.Forms.Button()
        Me.B2 = New System.Windows.Forms.Button()
        Me.B3 = New System.Windows.Forms.Button()
        Me.C2 = New System.Windows.Forms.Button()
        Me.C1 = New System.Windows.Forms.Button()
        Me.C3 = New System.Windows.Forms.Button()
        Me.btnWin = New System.Windows.Forms.Button()
        Me.lblTurno = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'bntLimpiar
        '
        Me.bntLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntLimpiar.Location = New System.Drawing.Point(483, 70)
        Me.bntLimpiar.Name = "bntLimpiar"
        Me.bntLimpiar.Size = New System.Drawing.Size(87, 23)
        Me.bntLimpiar.TabIndex = 8
        Me.bntLimpiar.Text = "Limpiar"
        Me.bntLimpiar.UseVisualStyleBackColor = True
        '
        'lblMsgGan
        '
        Me.lblMsgGan.AutoSize = True
        Me.lblMsgGan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsgGan.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblMsgGan.Location = New System.Drawing.Point(480, 253)
        Me.lblMsgGan.Name = "lblMsgGan"
        Me.lblMsgGan.Size = New System.Drawing.Size(0, 13)
        Me.lblMsgGan.TabIndex = 10
        Me.lblMsgGan.Visible = False
        '
        'A1
        '
        Me.A1.Font = New System.Drawing.Font("Mistral", 50.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.A1.Location = New System.Drawing.Point(64, 38)
        Me.A1.Name = "A1"
        Me.A1.Size = New System.Drawing.Size(105, 90)
        Me.A1.TabIndex = 0
        Me.A1.UseVisualStyleBackColor = True
        '
        'A2
        '
        Me.A2.Font = New System.Drawing.Font("Mistral", 50.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.A2.Location = New System.Drawing.Point(176, 38)
        Me.A2.Name = "A2"
        Me.A2.Size = New System.Drawing.Size(105, 90)
        Me.A2.TabIndex = 11
        Me.A2.UseVisualStyleBackColor = True
        '
        'A3
        '
        Me.A3.Font = New System.Drawing.Font("Mistral", 50.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.A3.Location = New System.Drawing.Point(288, 38)
        Me.A3.Name = "A3"
        Me.A3.Size = New System.Drawing.Size(105, 90)
        Me.A3.TabIndex = 12
        Me.A3.UseVisualStyleBackColor = True
        '
        'B1
        '
        Me.B1.Font = New System.Drawing.Font("Mistral", 50.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B1.Location = New System.Drawing.Point(64, 134)
        Me.B1.Name = "B1"
        Me.B1.Size = New System.Drawing.Size(105, 90)
        Me.B1.TabIndex = 13
        Me.B1.UseVisualStyleBackColor = True
        '
        'B2
        '
        Me.B2.Font = New System.Drawing.Font("Mistral", 50.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B2.Location = New System.Drawing.Point(176, 134)
        Me.B2.Name = "B2"
        Me.B2.Size = New System.Drawing.Size(105, 90)
        Me.B2.TabIndex = 14
        Me.B2.UseVisualStyleBackColor = True
        '
        'B3
        '
        Me.B3.Font = New System.Drawing.Font("Mistral", 50.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B3.Location = New System.Drawing.Point(288, 134)
        Me.B3.Name = "B3"
        Me.B3.Size = New System.Drawing.Size(105, 90)
        Me.B3.TabIndex = 15
        Me.B3.UseVisualStyleBackColor = True
        '
        'C2
        '
        Me.C2.Font = New System.Drawing.Font("Mistral", 50.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C2.Location = New System.Drawing.Point(176, 230)
        Me.C2.Name = "C2"
        Me.C2.Size = New System.Drawing.Size(105, 90)
        Me.C2.TabIndex = 16
        Me.C2.UseVisualStyleBackColor = True
        '
        'C1
        '
        Me.C1.Font = New System.Drawing.Font("Mistral", 50.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1.Location = New System.Drawing.Point(64, 230)
        Me.C1.Name = "C1"
        Me.C1.Size = New System.Drawing.Size(105, 90)
        Me.C1.TabIndex = 16
        Me.C1.UseVisualStyleBackColor = True
        '
        'C3
        '
        Me.C3.Font = New System.Drawing.Font("Mistral", 50.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C3.Location = New System.Drawing.Point(288, 230)
        Me.C3.Name = "C3"
        Me.C3.Size = New System.Drawing.Size(105, 90)
        Me.C3.TabIndex = 17
        Me.C3.UseVisualStyleBackColor = True
        '
        'btnWin
        '
        Me.btnWin.Enabled = False
        Me.btnWin.Font = New System.Drawing.Font("Mistral", 50.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWin.Location = New System.Drawing.Point(465, 160)
        Me.btnWin.Name = "btnWin"
        Me.btnWin.Size = New System.Drawing.Size(105, 90)
        Me.btnWin.TabIndex = 18
        Me.btnWin.UseVisualStyleBackColor = True
        Me.btnWin.Visible = False
        '
        'lblTurno
        '
        Me.lblTurno.AutoSize = True
        Me.lblTurno.Location = New System.Drawing.Point(465, 292)
        Me.lblTurno.Name = "lblTurno"
        Me.lblTurno.Size = New System.Drawing.Size(0, 13)
        Me.lblTurno.TabIndex = 19
        '
        'ticTacToe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(641, 346)
        Me.Controls.Add(Me.lblTurno)
        Me.Controls.Add(Me.btnWin)
        Me.Controls.Add(Me.C3)
        Me.Controls.Add(Me.C1)
        Me.Controls.Add(Me.C2)
        Me.Controls.Add(Me.B3)
        Me.Controls.Add(Me.B2)
        Me.Controls.Add(Me.B1)
        Me.Controls.Add(Me.A3)
        Me.Controls.Add(Me.A2)
        Me.Controls.Add(Me.lblMsgGan)
        Me.Controls.Add(Me.bntLimpiar)
        Me.Controls.Add(Me.A1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ticTacToe"
        Me.Text = "Tic Tac Toe"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents A1 As Button
    Friend WithEvents bntLimpiar As Button
    Friend WithEvents lblMsgGan As Label
    Friend WithEvents A2 As Button
    Friend WithEvents A3 As Button
    Friend WithEvents B1 As Button
    Friend WithEvents B2 As Button
    Friend WithEvents B3 As Button
    Friend WithEvents C2 As Button
    Friend WithEvents C1 As Button
    Friend WithEvents C3 As Button
    Friend WithEvents btnWin As Button
    Friend WithEvents lblTurno As Label
End Class
