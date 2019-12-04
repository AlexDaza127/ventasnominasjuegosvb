Imports System.ComponentModel

Public Class Nomina
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        lblAT.Text = "......................"
        lblSalario.Text = "......................"
        lblEPS.Text = "......................"
        lblERP.Text = "......................"
        lblFondo.Text = "......................"
        lblNombre.Text = "......................"
        lblPHE.Text = "......................"
        lblPrencion.Text = "......................"
        lblPRestamos.Text = "......................"
        lblSueldoNeto.Text = "......................"
        lblTotalE.Text = "......................"
        lblTotalI.Text = "......................"
        lblTurno.Text = "......................"
        cbEPS.Checked = False
        cbERP.Checked = False
        cbFondo.Checked = False
        cbPension.Checked = False
        cbPrestamos.Checked = False
        rbdiurno.Checked = True
        txtapellido.Clear()
        txtHE.Clear()
        txtnom.Clear()
        txtsalario.Clear()
    End Sub

    Private Sub cbEPS_CheckedChanged(sender As Object, e As EventArgs) Handles cbEPS.CheckedChanged
        Try
            If cbEPS.Checked = True Then
                lblEPS.Text = txtsalario.Text * 0.07
            Else
                lblEPS.Text = 0
            End If
        Catch ex As Exception
            MsgBox("Antes de seleccionar debe ingresar el valor del salario")
            cbEPS.Checked = False
        End Try

    End Sub

    Private Sub cbERP_CheckedChanged(sender As Object, e As EventArgs) Handles cbERP.CheckedChanged
        Try
            If cbERP.Checked = True Then
                lblERP.Text = txtsalario.Text * 0.01
            Else
                lblERP.Text = 0
            End If
        Catch ex As Exception
            MsgBox("Antes de seleccionar debe ingresar el valor del salario")
            cbERP.Checked = False
        End Try

    End Sub

    Private Sub cbPension_CheckedChanged(sender As Object, e As EventArgs) Handles cbPension.CheckedChanged
        Try
            If cbERP.Checked = True Then
                lblPrencion.Text = txtsalario.Text * 0.08
            Else
                lblPrencion.Text = 0
            End If
        Catch ex As Exception
            MsgBox("Antes de seleccionar debe ingresar el valor del salario")
            cbERP.Checked = False
        End Try

    End Sub

    Private Sub cbFondo_CheckedChanged(sender As Object, e As EventArgs) Handles cbFondo.CheckedChanged
        Try
            If cbFondo.Checked = True Then
                lblFondo.Text = txtsalario.Text * 0.04
            Else
                lblFondo.Text = 0
            End If
        Catch ex As Exception
            MsgBox("Antes de seleccionar debe ingresar el valor del salario")
            cbFondo.Checked = False
        End Try

    End Sub

    Private Sub cbPrestamos_CheckedChanged(sender As Object, e As EventArgs) Handles cbPrestamos.CheckedChanged
        Try
            If cbPrestamos.Checked = True Then
                lblPRestamos.Text = txtsalario.Text * 0.02
            Else
                lblPRestamos.Text = 0
            End If
        Catch ex As Exception
            MsgBox("Antes de seleccionar debe ingresar el valor del salario")
            cbPrestamos.Checked = False
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If Me.ValidateChildren And txtnom.Text <> String.Empty And txtapellido.Text <> String.Empty And txtsalario.Text <> String.Empty And txtHE.Text <> String.Empty Then
                MessageBox.Show("Datos registrados", "Registro Usiario", MessageBoxButtons.OK, MessageBoxIcon.Information)
                If cbEPS.Checked = False Then
                    lblEPS.Text = 0
                End If
                If cbERP.Checked = False Then
                    lblERP.Text = 0
                End If
                If cbPension.Checked = False Then
                    lblPrencion.Text = 0
                End If
                If cbFondo.Checked = False Then
                    lblFondo.Text = 0
                End If
                If cbPrestamos.Checked = False Then
                    lblPRestamos.Text = 0
                End If
                lblSalario.Text = txtsalario.Text
                lblNombre.Text = txtnom.Text & " " & txtapellido.Text
                lblAT.Text = txtsalario.Text * 0.01
                If rbdiurno.Checked = True Then
                    lblTurno.Text = " Diurno "
                    lblPHE.Text = txtHE.Text * 1000
                Else
                    lblTurno.Text = " Nocturno "
                    lblPHE.Text = txtHE.Text * 1500
                End If
                lblTotalI.Text = Val(lblSalario.Text) + Val(lblPHE.Text) + Val(lblAT.Text)
                lblTotalE.Text = Val(lblEPS.Text) + Val(lblERP.Text) + Val(lblFondo.Text) + Val(lblPrencion.Text) + Val(lblPRestamos.Text)
                lblSueldoNeto.Text = Val(lblTotalI.Text) - Val(lblTotalE.Text)
            Else
                MessageBox.Show("Ingrese algunos datos remarcados", "Registro Usiario", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub



    Private Sub txtnom_Validating(sender As Object, e As CancelEventArgs) Handles txtnom.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.Erroricono.SetError(sender, "")
        Else
            Me.Erroricono.SetError(sender, "Ingrese Nombres, OBLIGATORIO")
        End If
    End Sub


    Private Sub txtapellido_Validating(sender As Object, e As CancelEventArgs) Handles txtapellido.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.Erroricono.SetError(sender, "")
        Else
            Me.Erroricono.SetError(sender, "Ingrese  Apellidos, OBLIGATORIO")
        End If
    End Sub





    Private Sub txtsalario_Validating(sender As Object, e As CancelEventArgs) Handles txtsalario.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.Erroricono.SetError(sender, "")
        Else
            Me.Erroricono.SetError(sender, "Ingrese Salario , OBLIGATORIO")
        End If
    End Sub

    Private Sub txtHE_Validating(sender As Object, e As CancelEventArgs) Handles txtHE.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            If Val(txtHE.Text) - Int(txtHE.Text) = 0 Then
                Me.Erroricono.SetError(sender, "")
            Else
                Me.Erroricono.SetError(sender, "Ingrese Un valor numerico y entero")
            End If
        Else
            txtHE.Text = 0
        End If
    End Sub

    Private Sub txtnom_MouseHover(sender As Object, e As EventArgs) Handles txtnom.MouseHover
        ttmensaje.SetToolTip(txtnom, "Ingrese el nombre del empleado")
        ttmensaje.ToolTipTitle = "Nombre del empleado"
        ttmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtapellido_MouseHover(sender As Object, e As EventArgs) Handles txtapellido.MouseHover
        ttmensaje.SetToolTip(txtapellido, "Ingrese el apellido del empleado")
        ttmensaje.ToolTipTitle = "Apellido del empleado"
        ttmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtsalario_MouseHover(sender As Object, e As EventArgs) Handles txtsalario.MouseHover
        ttmensaje.SetToolTip(txtsalario, "Ingrese el salario del empleado")
        ttmensaje.ToolTipTitle = "Salario del empleado"
        ttmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtHE_MouseHover(sender As Object, e As EventArgs) Handles txtHE.MouseHover
        ttmensaje.SetToolTip(txtHE, "Ingrese las horas extras trabajadas")
        ttmensaje.ToolTipTitle = "Horas Extras"
        ttmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub


End Class