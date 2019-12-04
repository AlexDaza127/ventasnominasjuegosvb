Module OperacionVentas
    Public Total As Double
    Function descuentos(ByVal Desc As Double, ByVal subT As Double) As Double
        If (subT < 100000) Then
            Desc = Desc + 0
        ElseIf (subT >= 100000 And subT < 199999) Then
            Desc = Desc + subT * 0.03
        ElseIf (subT >= 200000 And subT < 299999) Then
            Desc = Desc + subT * 0.04
        ElseIf (subT >= 300000) Then
            Desc = Desc + subT * 0.05
        End If
        descuentos = Desc
    End Function

    Function totalPagar(ByVal Desc As Double, ByVal subT As Double) As Double

        Total = (subT - Desc)
        totalPagar = Total

    End Function


End Module
