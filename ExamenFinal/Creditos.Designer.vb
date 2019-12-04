<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Creditos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Creditos))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblmensa = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Controls.Add(Me.lblmensa)
        Me.Panel1.Location = New System.Drawing.Point(36, 31)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(750, 335)
        Me.Panel1.TabIndex = 2
        '
        'lblmensa
        '
        Me.lblmensa.AutoCompleteCustomSource.AddRange(New String() {"", "MICHAEL ALEXANDER MORA DAZA   ", "20171578053", "HÉCTOR EDUARDO GONZÁLEZ LÓPEZ  ", "2017157813"})
        Me.lblmensa.BackColor = System.Drawing.Color.Black
        Me.lblmensa.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblmensa.Enabled = False
        Me.lblmensa.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmensa.ForeColor = System.Drawing.Color.White
        Me.lblmensa.Location = New System.Drawing.Point(246, 15)
        Me.lblmensa.Multiline = True
        Me.lblmensa.Name = "lblmensa"
        Me.lblmensa.Size = New System.Drawing.Size(256, 95)
        Me.lblmensa.TabIndex = 1
        Me.lblmensa.Text = " " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "MICHAEL ALEXANDER MORA DAZA   " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "20171578053" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "UNIVERSIDAD DISTRITAL FRANCISCO J" &
    "OSÉ DE CALDAS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblmensa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Timer1
        '
        '
        'Creditos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(822, 404)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Creditos"
        Me.Text = "Creditos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblmensa As TextBox
    Friend WithEvents Timer1 As Timer
End Class
