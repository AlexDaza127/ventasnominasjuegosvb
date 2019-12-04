Public Class Memoria
    Dim vi(20) As Integer
    Dim Imagen As String
    Dim N, I1, I2, p1, p2 As Integer 'variables para almacenar
    Dim s As Integer

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Ver_Imagen(vi(1))
        PictureBox2.Image = Image.FromFile(My.Application.Info.DirectoryPath + Imagen)
        Jugada(vi(1), 2)
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Ver_Imagen(vi(2))
        PictureBox3.Image = Image.FromFile(My.Application.Info.DirectoryPath + Imagen)
        Jugada(vi(2), 3)
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Ver_Imagen(vi(3))
        PictureBox4.Image = Image.FromFile(My.Application.Info.DirectoryPath + Imagen)
        Jugada(vi(3), 4)
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Ver_Imagen(vi(4))
        PictureBox5.Image = Image.FromFile(My.Application.Info.DirectoryPath + Imagen)
        Jugada(vi(4), 5)
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        Ver_Imagen(vi(9))
        PictureBox10.Image = Image.FromFile(My.Application.Info.DirectoryPath + Imagen)
        Jugada(vi(9), 10)
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        Ver_Imagen(vi(8))
        PictureBox9.Image = Image.FromFile(My.Application.Info.DirectoryPath + Imagen)
        Jugada(vi(8), 9)
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Ver_Imagen(vi(7))
        PictureBox8.Image = Image.FromFile(My.Application.Info.DirectoryPath + Imagen)
        Jugada(vi(7), 8)
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Ver_Imagen(vi(6))
        PictureBox7.Image = Image.FromFile(My.Application.Info.DirectoryPath + Imagen)
        Jugada(vi(6), 7)
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Ver_Imagen(vi(5))
        PictureBox6.Image = Image.FromFile(My.Application.Info.DirectoryPath + Imagen)
        Jugada(vi(5), 6)
    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click
        Ver_Imagen(vi(14))
        PictureBox15.Image = Image.FromFile(My.Application.Info.DirectoryPath + Imagen)
        Jugada(vi(14), 15)
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        Ver_Imagen(vi(13))
        PictureBox14.Image = Image.FromFile(My.Application.Info.DirectoryPath + Imagen)
        Jugada(vi(13), 14)
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        Ver_Imagen(vi(12))
        PictureBox13.Image = Image.FromFile(My.Application.Info.DirectoryPath + Imagen)
        Jugada(vi(12), 13)
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        Ver_Imagen(vi(11))
        PictureBox12.Image = Image.FromFile(My.Application.Info.DirectoryPath + Imagen)
        Jugada(vi(11), 12)
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        Ver_Imagen(vi(10))
        PictureBox11.Image = Image.FromFile(My.Application.Info.DirectoryPath + Imagen)
        Jugada(vi(10), 11)
    End Sub

    Private Sub PictureBox20_Click(sender As Object, e As EventArgs) Handles PictureBox20.Click
        Ver_Imagen(vi(19))
        PictureBox20.Image = Image.FromFile(My.Application.Info.DirectoryPath + Imagen)
        Jugada(vi(19), 20)
    End Sub

    Private Sub PictureBox19_Click(sender As Object, e As EventArgs) Handles PictureBox19.Click
        Ver_Imagen(vi(18))
        PictureBox19.Image = Image.FromFile(My.Application.Info.DirectoryPath + Imagen)
        Jugada(vi(18), 19)
    End Sub

    Private Sub PictureBox18_Click(sender As Object, e As EventArgs) Handles PictureBox18.Click
        Ver_Imagen(vi(17))
        PictureBox18.Image = Image.FromFile(My.Application.Info.DirectoryPath + Imagen)
        Jugada(vi(17), 18)
    End Sub

    Private Sub PictureBox17_Click(sender As Object, e As EventArgs) Handles PictureBox17.Click
        Ver_Imagen(vi(16))
        PictureBox17.Image = Image.FromFile(My.Application.Info.DirectoryPath + Imagen)
        Jugada(vi(16), 17)
    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        Ver_Imagen(vi(15))
        PictureBox16.Image = Image.FromFile(My.Application.Info.DirectoryPath + Imagen)
        Jugada(vi(15), 16)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Ver_Imagen(vi(0))
        PictureBox1.Image = Image.FromFile(My.Application.Info.DirectoryPath + Imagen)
        Jugada(vi(0), 1)
    End Sub




    Public Sub Ver_Imagen(ByVal im As Integer)

        Select Case im
            Case 1 : Imagen = "\1.jpg"
            Case 2 : Imagen = "\2.jpg"
            Case 3 : Imagen = "\3.jpg"
            Case 4 : Imagen = "\4.jpg"
            Case 5 : Imagen = "\5.jpg"
            Case 6 : Imagen = "\6.jpg"
            Case 7 : Imagen = "\7.jpg"
            Case 8 : Imagen = "\8.jpg"
            Case 9 : Imagen = "\9.jpg"
            Case 10 : Imagen = "\10.jpg"
        End Select
    End Sub

    Public Sub Termina_Jugada(ByVal Npb As Integer)
        Imagen = "\incognita.jpg"
        Select Case Npb
            Case 1 : PictureBox1.Image = Image.FromFile(My.Application.Info.DirectoryPath + Imagen)
            Case 2 : PictureBox2.Image = Image.FromFile(My.Application.Info.DirectoryPath + Imagen)
            Case 3 : PictureBox3.Image = Image.FromFile(My.Application.Info.DirectoryPath + Imagen)
            Case 4 : PictureBox4.Image = Image.FromFile(My.Application.Info.DirectoryPath + Imagen)
            Case 5 : PictureBox5.Image = Image.FromFile(My.Application.Info.DirectoryPath + Imagen)
            Case 6 : PictureBox6.Image = Image.FromFile(My.Application.Info.DirectoryPath + Imagen)
            Case 7 : PictureBox7.Image = Image.FromFile(My.Application.Info.DirectoryPath + Imagen)
            Case 8 : PictureBox8.Image = Image.FromFile(My.Application.Info.DirectoryPath + Imagen)
            Case 9 : PictureBox9.Image = Image.FromFile(My.Application.Info.DirectoryPath + Imagen)
            Case 10 : PictureBox10.Image = Image.FromFile(My.Application.Info.DirectoryPath + Imagen)
            Case 11 : PictureBox11.Image = Image.FromFile(My.Application.Info.DirectoryPath + Imagen)
            Case 12 : PictureBox12.Image = Image.FromFile(My.Application.Info.DirectoryPath + Imagen)
            Case 13 : PictureBox13.Image = Image.FromFile(My.Application.Info.DirectoryPath + Imagen)
            Case 14 : PictureBox14.Image = Image.FromFile(My.Application.Info.DirectoryPath + Imagen)
            Case 15 : PictureBox15.Image = Image.FromFile(My.Application.Info.DirectoryPath + Imagen)
            Case 16 : PictureBox16.Image = Image.FromFile(My.Application.Info.DirectoryPath + Imagen)
            Case 17 : PictureBox17.Image = Image.FromFile(My.Application.Info.DirectoryPath + Imagen)
            Case 18 : PictureBox18.Image = Image.FromFile(My.Application.Info.DirectoryPath + Imagen)
            Case 19 : PictureBox19.Image = Image.FromFile(My.Application.Info.DirectoryPath + Imagen)
            Case 20 : PictureBox20.Image = Image.FromFile(My.Application.Info.DirectoryPath + Imagen)
        End Select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Imagen = "\incognita.jpg"
        lblpuntaje.Text = 0
        PictureBox1.Image = Image.FromFile(My.Application.Info.DirectoryPath + Imagen)
        PictureBox2.Image = Image.FromFile(My.Application.Info.DirectoryPath + Imagen)
        PictureBox3.Image = Image.FromFile(My.Application.Info.DirectoryPath + Imagen)
        PictureBox4.Image = Image.FromFile(My.Application.Info.DirectoryPath + Imagen)
        PictureBox5.Image = Image.FromFile(My.Application.Info.DirectoryPath + Imagen)
        PictureBox6.Image = Image.FromFile(My.Application.Info.DirectoryPath + Imagen)
        PictureBox7.Image = Image.FromFile(My.Application.Info.DirectoryPath + Imagen)
        PictureBox8.Image = Image.FromFile(My.Application.Info.DirectoryPath + Imagen)
        PictureBox9.Image = Image.FromFile(My.Application.Info.DirectoryPath + Imagen)
        PictureBox10.Image = Image.FromFile(My.Application.Info.DirectoryPath + Imagen)
        PictureBox11.Image = Image.FromFile(My.Application.Info.DirectoryPath + Imagen)
        PictureBox12.Image = Image.FromFile(My.Application.Info.DirectoryPath + Imagen)
        PictureBox13.Image = Image.FromFile(My.Application.Info.DirectoryPath + Imagen)
        PictureBox14.Image = Image.FromFile(My.Application.Info.DirectoryPath + Imagen)
        PictureBox15.Image = Image.FromFile(My.Application.Info.DirectoryPath + Imagen)
        PictureBox16.Image = Image.FromFile(My.Application.Info.DirectoryPath + Imagen)
        PictureBox17.Image = Image.FromFile(My.Application.Info.DirectoryPath + Imagen)
        PictureBox18.Image = Image.FromFile(My.Application.Info.DirectoryPath + Imagen)
        PictureBox19.Image = Image.FromFile(My.Application.Info.DirectoryPath + Imagen)
        PictureBox20.Image = Image.FromFile(My.Application.Info.DirectoryPath + Imagen)

        N = 0

        Cargar_Imagenes()

    End Sub

    Public Sub Jugada(ByVal Ni As Integer, ByVal numpic As Integer)
        'chapo=Jugada
        N = N + 1 'incrementar contador
        If N = 1 Then '1º imagen visible
            I1 = Ni
            p1 = numpic
        End If
        If N = 2 Then '2º imagen visible
            I2 = Ni
            p2 = numpic

            If I1 = I2 Then
                MsgBox("Imágenes iguales")
                lblpuntaje.Text = lblpuntaje.Text + 2
            Else
                MsgBox("Imgen incorrecta")
                lblpuntaje.Text = lblpuntaje.Text - 1
                Termina_Jugada(p1)
                Termina_Jugada(p2)
            End If
            N = 0
        End If
    End Sub


    Private Sub Memoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar_Imagenes()
        s = 0
    End Sub

    Public Sub Cargar_Imagenes()
        Dim Nr As New Random()
        Dim Va As Integer
        Dim x, y, b As Integer

        For x = 0 To 19
            vi(x) = 0
        Next
        x = 0
        Do
            Do
                b = 0
                Va = Nr.Next(10) + 1
                For y = 0 To 19
                    If Va = vi(y) Then
                        b = b + 1
                    End If
                Next
            Loop While (b >= 2)
            vi(x) = Va
            x = x + 1
        Loop While (x <= 19)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

End Class