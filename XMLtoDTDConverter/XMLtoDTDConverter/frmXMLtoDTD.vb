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

    Private Enum enumXMLActionType
        Failed = 0
        Enum_PrintwChildren = 1
        Enum_PrintAsCData = 2
        Enum_Ignore = 3
    End Enum

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

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Try
            ArrAllElements.Clear()
            ArrParentNodes.Clear()
            ArrPrintedChildren.Clear()
            XMLdoc.Load(InputFilePath)
            sb = New System.Text.StringBuilder

            If XMLdoc.HasChildNodes = True Then
                For Each nd As Xml.XmlNode In XMLdoc.ChildNodes
                    If nd.NodeType = Xml.XmlNodeType.Element Then

                    End If
                Next
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Function nodeProcess(ByVal Node As Xml.XmlNode) As Boolean
        Try
            Dim nodeAcction As enumXMLActionType = getNode(Node)
        Catch ex As Exception

        End Try
    End Function

    Private Function getNode(ByVal nd As Xml.XmlNode) As enumXMLActionType
        Try
            Dim isParentElemet As Boolean = False

            If nd.HasChildNodes = True Then
                Dim numEle As Integer = 0
                For Each node As Xml.XmlNode In nd.ChildNodes
                    If node.NodeType = Xml.XmlNodeType.Element Then
                        If node.HasChildNodes Then
                            If node.FirstChild.NodeType = Xml.XmlNodeType.Element Then
                                isParentElemet = True
                            End If
                        End If
                        numEle += 1
                        If numEle = 2 Then
                            getNode = enumXMLActionType.Enum_PrintwChildren
                            Exit Function
                        End If
                    End If
                Next
                If isParentElemet = True Then
                    getNode = enumXMLActionType.Enum_PrintwChildren
                Else
                    getNode = enumXMLActionType.Enum_PrintAsCData
                End If
            Else
                If nd.NodeType = Xml.XmlNodeType.Element Then
                    getNode = enumXMLActionType.Enum_PrintAsCData
                Else
                    getNode = enumXMLActionType.Enum_Ignore
                End If
            End If

        Catch ex As Exception
            getNode = enumXMLActionType.Failed
            sb.AppendLine("Somethign happened here" & nd.Name)
            sb.AppendLine()
        End Try
    End Function

    Private Function getParentElement(ByVal nd As Xml.XmlNode) As String
        Try
            Dim newName As String = nd.LocalName
            Dim oldName As String = newName
            Dim cnt As Integer = 0

TryAgain:   If ArrParentNodes.Contains(newName) = True Then
                cnt += 1
                newName = oldName & cnt.ToString
                GoTo TryAgain
            End If

            getParentElement = newName
        Catch ex As Exception
            getParentElement = ""
        End Try
    End Function

    Private Function getChildElement(ByVal nd As Xml.XmlNode) As String
        Try
            Try
                Dim newName As String = nd.LocalName
                Dim oldName As String = newName
                Dim cnt As Integer = 0

TryAgain:       If ArrParentNodes.Contains(newName) = True Then
                    cnt += 1
                    newName = oldName & cnt.ToString
                    GoTo TryAgain
                End If

                getChildElement = newName
            Catch ex As Exception
                getChildElement = ""
            End Try
        Catch ex As Exception
            getChildElement = ""
        End Try
    End Function

    Private Function getCDataElement(ByVal nd As Xml.XmlNode) As String
        Try
            Try
                Dim newName As String = nd.LocalName
                Dim oldName As String = newName
                Dim cnt As Integer = 0

TryAgain:       If ArrParentNodes.Contains(newName) = True Then
                    cnt += 1
                    newName = oldName & cnt.ToString
                    GoTo TryAgain
                End If

                getCDataElement = newName
            Catch ex As Exception
                getCDataElement = ""
            End Try
        Catch ex As Exception
            getCDataElement = ""
        End Try
    End Function
End Class
