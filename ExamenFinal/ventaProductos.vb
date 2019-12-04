Public Class ventaProductos
    Dim cant As Integer
    Dim subT As Double
    Dim desc As Double
    Dim Total As Double

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles radProd1.CheckedChanged
        lblPrecio.Text = "85000"
        picProd1.Enabled = True
        picProd1.Visible = True
        picProd2.Enabled = False
        picProd2.Visible = False
        picProd3.Enabled = False
        picProd3.Visible = False

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles radProd2.CheckedChanged
        lblPrecio.Text = "110000"
        picProd1.Enabled = False
        picProd1.Visible = False
        picProd2.Enabled = True
        picProd2.Visible = True
        picProd3.Enabled = False
        picProd3.Visible = False
    End Sub
    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles radProd3.CheckedChanged
        lblPrecio.Text = "150000"
        picProd1.Enabled = False
        picProd1.Visible = False
        picProd2.Enabled = False
        picProd2.Visible = False
        picProd3.Enabled = True
        picProd3.Visible = True
    End Sub

    Private Sub ventaProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        picProd1.Enabled = False
        picProd1.Visible = False
        picProd3.Enabled = False
        picProd3.Visible = False
        picProd2.Enabled = False
        picProd2.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCarrito.Click
        Reloj.Enabled = True

    End Sub

    Public Sub operacion()
        txtDesc.Text = descuentos(desc, subT)
        txtTotal.Text = totalPagar(txtDesc.Text, subT)
        If (subT < 100000) Then
            lblDescuento.Text = "Descuento 0%:"
        ElseIf (subT >= 100000 And subT < 199999) Then
            lblDescuento.Text = "Descuento 3%:"
        ElseIf (subT >= 200000 And subT < 299999) Then
            lblDescuento.Text = "Descuento 4%:"
        ElseIf (subT >= 300000) Then
            lblDescuento.Text = "Descuento 5%:"
        End If
    End Sub

    Private Sub Reloj_Tick(sender As Object, e As EventArgs) Handles Reloj.Tick
        If (btnCarrito.Focused And radProd1.Checked = True) Then
            picProd1.Left = picProd1.Left + 10
            radProd1.Enabled = False
            radProd2.Enabled = False
            radProd3.Enabled = False
            If picProd1.Location.X > 442 Then
                picProd1.Enabled = False
                picProd1.Visible = False
                radProd1.Enabled = True
                radProd2.Enabled = True
                radProd3.Enabled = True
                cant = Val(txtCant.Text)
                subT = subT + (cant * Val(lblPrecio.Text))
                txtSub.Text = subT
                operacion()
                Reloj.Stop()
            End If
        End If

        If (btnCarrito.Focused And radProd2.Checked = True) Then
            picProd2.Left = picProd2.Left + 10
            radProd1.Enabled = False
            radProd2.Enabled = False
            radProd3.Enabled = False
            If picProd2.Location.X > 442 Then
                picProd2.Enabled = False
                picProd2.Visible = False
                radProd1.Enabled = True
                radProd2.Enabled = True
                radProd3.Enabled = True
                cant = Val(txtCant.Text)
                subT = subT + (cant * Val(lblPrecio.Text))
                txtSub.Text = subT
                operacion()
                Reloj.Stop()
            End If

        End If

        If (btnCarrito.Focused And radProd3.Checked = True) Then
            picProd3.Left = picProd3.Left + 10
            radProd1.Enabled = False
            radProd2.Enabled = False
            radProd3.Enabled = False
            If picProd3.Location.X > 442 Then
                picProd3.Enabled = False
                picProd3.Visible = False
                radProd1.Enabled = True
                radProd2.Enabled = True
                radProd3.Enabled = True
                cant = Val(txtCant.Text)
                subT = subT + (cant * Val(lblPrecio.Text))
                txtSub.Text = subT
                operacion()
                Reloj.Stop()
            End If
        End If

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        picProd1.Visible = False
        picProd2.Visible = False
        picProd3.Visible = False
        picProd1.Location = New Point(204, 65)
        picProd2.Location = New Point(204, 65)
        picProd3.Location = New Point(204, 65)
        cant = 0
        subT = 0
        desc = 0
        Total = 0
        txtCant.Text = ""
        txtDesc.Text = ""
        txtSub.Text = ""
        txtTotal.Text = ""
    End Sub
End Class