Public Class frmXMLtoDTD
    Private InputFilePath As String
    Private OutputFilePath As String
    Private XMLdoc As New Xml.XmlDocument

    Private ArrAllElements As New ArrayList
    Private ArrParentNodes As New ArrayList
    Private ArrPrintedChildren As New ArrayList
    Private ArrCDataNodes As New ArrayList
    Private InputDirectory As String = ""

    Private sb As System.Text.StringBuilder

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click

        Try
            ofdInputXMLFiles.Title = "XML Message"
            If InputDirectory <> "" Then
                ofdInputXMLFiles.InitialDirectory = InputDirectory
            End If
            ofdInputXMLFiles.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ofdInputXMLFiles_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ofdInputXMLFiles.FileOk

        Try
            InputFilePath = ofdInputXMLFiles.FileName
            If InputFilePath <> "" Then
                txtInputPath.Text = InputFilePath
                LoadInputFile()

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadInputFile()
        Try
            txtDisplayXML.Text = LoadXMLFile(InputFilePath)
        Catch ex As Exception

        End Try
    End Sub

    Function LoadXMLFile(ByVal XMLFilePath As String) As String
        Dim sr As System.IO.StreamReader = Nothing

        Try
            sr = New System.IO.StreamReader(XMLFilePath)
            LoadXMLFile = sr.ReadToEnd()
        Catch ex As Exception
            Return ""
        Finally
            If Not sr Is Nothing Then sr.Close()
        End Try
    End Function



End Class
