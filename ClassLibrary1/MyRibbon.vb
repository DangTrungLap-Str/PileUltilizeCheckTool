Imports ExcelDna.Integration.CustomUI

Imports System.IO
Imports System.Reflection

Public Class MyRibbon
    Inherits ExcelRibbon

    Public Overrides Function GetCustomUI(ribbonID As String) As String

        Dim asm = Assembly.GetExecutingAssembly()

        Using stream = asm.GetManifestResourceStream("PileUtilize.Ribbon.xml")
            Using reader As New StreamReader(stream)
                Return reader.ReadToEnd()
            End Using
        End Using

    End Function

    Public Sub OnTestClick(control As IRibbonControl)
        MsgBox("Hello Excel-DNA")
    End Sub

End Class