Imports System.Windows.Forms

Public Class Presentacion


    Private Sub opcSalir_Click(sender As Object, e As EventArgs) Handles opcSalir.Click
        Me.Close()
        Registro.Close()
    End Sub

    Private Sub opcVentasProduc_Click(sender As Object, e As EventArgs) Handles opcVentasProduc.Click
        Dim ventaProd As ventaProductos = New ventaProductos()
        ventaProd.MdiParent = Me
        ventaProd.Show()
    End Sub

    Private Sub opcTicTacToe_Click(sender As Object, e As EventArgs) Handles opcTicTacToe.Click
        Dim ticTacToe As ticTacToe = New ticTacToe()
        ticTacToe.MdiParent = Me
        ticTacToe.Show()
    End Sub

    Private Sub Presentacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Registro.Visible = False
    End Sub

    Private Sub opcNomina_Click(sender As Object, e As EventArgs) Handles opcNomina.Click
        Dim Nomina As Nomina = New Nomina()
        Nomina.MdiParent = Me
        Nomina.Show()

    End Sub

    Private Sub opcConcentrese_Click(sender As Object, e As EventArgs) Handles opcConcentrese.Click
        Dim Memoria As Memoria = New Memoria()
        Memoria.MdiParent = Me
        Memoria.Show()
    End Sub

    Private Sub opcCreditos_Click(sender As Object, e As EventArgs) Handles opcCreditos.Click
        Dim cred As Creditos = New Creditos()
        cred.MdiParent = Me
        cred.Show()
    End Sub
End Class
