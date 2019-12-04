Public Class Creditos
    Dim vdir, hdir, vel As Double

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblmensa.Left = lblmensa.Left + (hdir * vel)
        lblmensa.Top = lblmensa.Top + (vdir * vel)
        If lblmensa.Left + lblmensa.Width >= Panel1.Left + Panel1.Width Then
            hdir = -hdir
        End If
        If lblmensa.Top + lblmensa.Height >= Panel1.Top + Panel1.Height Then
            vdir = -vdir
        End If
        If lblmensa.Left <= Panel1.Left Then
            hdir = -hdir
        End If
        If lblmensa.Top <= Panel1.Top Then
            vdir = -vdir
        End If
    End Sub

    Private Sub Creditos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        vdir = 0.1
        hdir = 0.1
        vel = 50
        Timer1.Start()
    End Sub

End Class