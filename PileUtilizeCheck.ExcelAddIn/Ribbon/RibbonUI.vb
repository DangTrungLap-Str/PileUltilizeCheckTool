Imports ExcelDna.Integration
Imports Microsoft.Office.Interop.Excel

<ComVisible(True)>
Public Class RibbonUI

    ''' <summary>
    ''' Load image callback for ribbon UI
    ''' </summary>
    <ExcelRibbon>
    Public Function LoadImage(imageId As String) As Object
        ' Implement image loading logic here
        Return Nothing
    End Function

    ''' <summary>
    ''' Test button click handler
    ''' </summary>
    <ExcelCommand>
    Public Sub OnTestClick(control As Object)
        Try
            Dim app = ExcelDnaUtil.Application
            app.StatusBar = "Pile Utilize Add-In Test Button Clicked!"
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub

End Class