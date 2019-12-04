Module ProcesoTicTacToe
    Dim TTT As New ticTacToe
    Dim X As String
    Dim O As String
    Dim E As String
    Function gananX() As String
        X = "Ganan las X!!!"
        gananX = X
    End Function
    Function gananO() As String
        O = "Ganan las O!!!"
        gananO = O
    End Function

    Function empatados() As String
        E = "Es un empate!!!"
        empatados = E
    End Function

End Module
