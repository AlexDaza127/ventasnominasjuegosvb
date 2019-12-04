Public Class ticTacToe
    Dim turno As Integer
    Dim result As Integer

    Public Sub turnoT()
        If (result = 1) Then
            lblTurno.Text = "El turno es de las O"
        Else
            lblTurno.Text = "El turno es de las X"
        End If
    End Sub

    Public Sub empate()
        If (A1.Enabled = False And
            A2.Enabled = False And
            A3.Enabled = False And
            B1.Enabled = False And
            B2.Enabled = False And
            B3.Enabled = False And
            C1.Enabled = False And
            C2.Enabled = False And
            C3.Enabled = False And
            btnWin.Text = "") Then
            lblTurno.Text = ""
            MsgBox(empatados())

        End If

    End Sub

    Public Sub winX()

        A1.Enabled = False
        A2.Enabled = False
        A3.Enabled = False
        B1.Enabled = False
        B2.Enabled = False
        B3.Enabled = False
        C1.Enabled = False
        C2.Enabled = False
        C3.Enabled = False
        btnWin.Visible = True
        btnWin.Enabled = True
        btnWin.Text = "X"
        lblMsgGan.Text = gananX()
        lblMsgGan.Visible = True
        lblTurno.Text = ""


    End Sub

    Public Sub winO()

        A1.Enabled = False
        A2.Enabled = False
        A3.Enabled = False
        B1.Enabled = False
        B2.Enabled = False
        B3.Enabled = False
        C1.Enabled = False
        C2.Enabled = False
        C3.Enabled = False
        btnWin.Visible = True
        btnWin.Enabled = True
        btnWin.Text = "O"
        lblMsgGan.Text = gananO()
        lblMsgGan.Visible = True
        lblTurno.Text = ""
    End Sub

    Public Sub ganador()

        'Jugadas X

        If (A1.Text = "X" And A2.Text = "X" And A3.Text = "X") Then
            winX()
        End If

        If (B1.Text = "X" And B2.Text = "X" And B3.Text = "X") Then
            winX()
        End If

        If (C1.Text = "X" And C2.Text = "X" And C3.Text = "X") Then
            winX()
        End If

        If (A1.Text = "X" And B1.Text = "X" And C1.Text = "X") Then
            winX()
        End If

        If (A2.Text = "X" And B2.Text = "X" And C2.Text = "X") Then
            winX()
        End If

        If (A3.Text = "X" And B3.Text = "X" And C3.Text = "X") Then
            winX()
        End If

        If (A1.Text = "X" And B2.Text = "X" And C3.Text = "X") Then
            winX()
        End If

        If (A3.Text = "X" And B2.Text = "X" And C1.Text = "X") Then
            winX()
        End If


        ' Jugadas O

        If (A1.Text = "O" And A2.Text = "O" And A3.Text = "O") Then
            winO()
        End If

        If (B1.Text = "O" And B2.Text = "O" And B3.Text = "O") Then
            winO()
        End If

        If (C1.Text = "O" And C2.Text = "O" And C3.Text = "O") Then
            winO()
        End If

        If (A1.Text = "O" And B1.Text = "O" And C1.Text = "O") Then
            winO()
        End If

        If (A2.Text = "O" And B2.Text = "O" And C2.Text = "O") Then
            winO()
        End If

        If (A3.Text = "O" And B3.Text = "O" And C3.Text = "O") Then
            winO()
        End If

        If (A1.Text = "O" And B2.Text = "O" And C3.Text = "O") Then
            winO()
        End If

        If (A3.Text = "O" And B2.Text = "O" And C1.Text = "O") Then
            winO()
        End If
    End Sub


    Private Sub bntLimpiar_Click(sender As Object, e As EventArgs) Handles bntLimpiar.Click
        A1.Text = ""
        A2.Text = ""
        A3.Text = ""
        B1.Text = ""
        B2.Text = ""
        B3.Text = ""
        C1.Text = ""
        C2.Text = ""
        C3.Text = ""
        btnWin.Text = ""
        btnWin.Enabled = False
        lblMsgGan.Text = ""
        A1.Enabled = True
        A2.Enabled = True
        A3.Enabled = True
        B1.Enabled = True
        B2.Enabled = True
        B3.Enabled = True
        C1.Enabled = True
        C2.Enabled = True
        C3.Enabled = True
        turno = 0
        lblTurno.Text = ""
    End Sub

    Private Sub A1_Click(sender As Object, e As EventArgs) Handles A1.Click

        turno = turno + 1
        result = turno Mod 2
        turnoT()

        If (result = 1) Then
            A1.Text = "X"
            A1.Enabled = False
        Else
            A1.Text = "O"
            A1.Enabled = False
        End If
        ganador()
        empate()
    End Sub

    Private Sub A2_Click(sender As Object, e As EventArgs) Handles A2.Click
        turno = turno + 1
        result = turno Mod 2
        turnoT()

        If (result = 1) Then
            A2.Text = "X"
            A2.Enabled = False
        Else
            A2.Text = "O"
            A2.Enabled = False
        End If
        ganador()
        empate()
    End Sub

    Private Sub A3_Click(sender As Object, e As EventArgs) Handles A3.Click
        turno = turno + 1
        result = turno Mod 2
        turnoT()

        If (result = 1) Then
            A3.Text = "X"
            A3.Enabled = False
        Else
            A3.Text = "O"
            A3.Enabled = False
        End If
        ganador()
        empate()
    End Sub

    Private Sub B1_Click(sender As Object, e As EventArgs) Handles B1.Click
        turno = turno + 1
        result = turno Mod 2
        turnoT()

        If (result = 1) Then
            B1.Text = "X"
            B1.Enabled = False
        Else
            B1.Text = "O"
            B1.Enabled = False
        End If
        ganador()
        empate()
    End Sub

    Private Sub B2_Click(sender As Object, e As EventArgs) Handles B2.Click
        turno = turno + 1
        result = turno Mod 2
        turnoT()

        If (result = 1) Then
            B2.Text = "X"
            B2.Enabled = False
        Else
            B2.Text = "O"
            B2.Enabled = False
        End If
        ganador()
        empate()
    End Sub

    Private Sub B3_Click(sender As Object, e As EventArgs) Handles B3.Click
        turno = turno + 1
        result = turno Mod 2
        turnoT()

        If (result = 1) Then
            B3.Text = "X"
            B3.Enabled = False
        Else
            B3.Text = "O"
            B3.Enabled = False
        End If
        ganador()
        empate()
    End Sub

    Private Sub C1_Click(sender As Object, e As EventArgs) Handles C1.Click
        turno = turno + 1
        result = turno Mod 2
        turnoT()

        If (result = 1) Then
            C1.Text = "X"
            C1.Enabled = False
        Else
            C1.Text = "O"
            C1.Enabled = False
        End If
        ganador()
        empate()
    End Sub

    Private Sub C2_Click(sender As Object, e As EventArgs) Handles C2.Click
        turno = turno + 1
        result = turno Mod 2
        turnoT()

        If (result = 1) Then
            C2.Text = "X"
            C2.Enabled = False
        Else
            C2.Text = "O"
            C2.Enabled = False
        End If
        ganador()
        empate()
    End Sub

    Private Sub C3_Click(sender As Object, e As EventArgs) Handles C3.Click
        turno = turno + 1
        result = turno Mod 2
        turnoT()

        If (result = 1) Then
            C3.Text = "X"
            C3.Enabled = False
        Else
            C3.Text = "O"
            C3.Enabled = False
        End If
        ganador()
        empate()
    End Sub
End Class