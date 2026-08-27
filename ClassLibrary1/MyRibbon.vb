Imports ExcelDna.Integration.CustomUI
Imports System.Windows.Forms

Public Class MyRibbon
    Inherits ExcelRibbon

    Public Overrides Function GetCustomUI(ribbonID As String) As String
        Return Nothing
    End Function

    Public Sub OnTestClick(control As IRibbonControl)
        MsgBox("Hello Excel-DNA")
    End Sub

End Class