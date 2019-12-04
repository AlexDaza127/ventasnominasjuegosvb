Public Class Registro
    Dim cont As Integer
    Dim Present As New Presentacion


    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Dim pass As String
        Dim usur As String

        pass = "1234"
        usur = "ExamenFinal2019"
        Try
            If (usur = txtUsuario.Text And pass = txtPass.Text) Then
                Present.Show()
            Else
                cont = cont + 1
                MessageBox.Show("Los datos no son correctos, intentos faltantes " & cont)
                txtPass.Clear()
                txtUsuario.Clear()
                If (cont = 3) Then
                    Me.Close()
                End If
            End If
        Catch ex As Exception
        End Try



    End Sub



End Class