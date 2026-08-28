Imports ExcelDna.Integration

<ComVisible(True)>
Public Module AddInFunctions

    <ExcelFunction(Description:="A simple test function that adds two numbers")>
    Public Function TestAdd(x As Double, y As Double) As Double
        Return x + y
    End Function

    <ExcelFunction(Description:="Calculate pile utilization")>
    Public Function CalculatePileUtilization(appliedLoad As Double, allowableLoad As Double) As Double
        If allowableLoad = 0 Then
            Return 0
        End If
        Return (appliedLoad / allowableLoad) * 100
    End Function

End Module