Imports ExcelDna.Integration.CustomUI
Imports System.Windows.Forms
Imports System.Runtime.InteropServices

<ComVisible(True)>
Public Class MyRibbon
    Inherits ExcelRibbon

    Public Sub OnTestClick(control As IRibbonControl)
        MsgBox("Hello Excel-DNA")
    End Sub

End Class