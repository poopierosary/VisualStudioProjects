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

    Public Function OpenForm() As Boolean
        Try
            btnConvert.Enabled = False
            Me.Show()

        Catch ex As Exception
            Return False

        End Try
    End Function

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
                btnConvert.Enabled = True
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadInputFile()
        Try
            txtOutputDTD.Text = ""
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
            txtOutputDTD.Text = ""

            If XMLdoc.HasChildNodes = True Then
                For Each nd As Xml.XmlNode In XMLdoc.ChildNodes
                    If nd.NodeType = Xml.XmlNodeType.Element Then
                        nodeProcess(nd)
                    End If
                Next
            End If

            If printCData(ArrCDataNodes) = True Then
                txtOutputDTD.Text = sb.ToString
                btnBrowse.Enabled = True
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Function nodeProcess(ByVal Node As Xml.XmlNode) As Boolean
        Try
            Dim nodeAcction As enumXMLActionType = getNode(Node)

            Select Case nodeAcction
                Case enumXMLActionType.Enum_PrintwChildren
                    printNode(Node)
                    For Each chd As Xml.XmlNode In Node.ChildNodes
                        nodeProcess(chd)
                    Next

                Case enumXMLActionType.Enum_PrintAsCData
                    Dim qualName As String = getCDataElement(Node)
                    ArrCDataNodes.Add(qualName)

                Case enumXMLActionType.Enum_Ignore

                Case enumXMLActionType.Failed
                    If MsgBox("Translation failed at Element: " & Node.Name & Chr(13) &
                            "Would you like to continue processing?", MsgBoxStyle.YesNo, "Translation Failed") = MsgBoxResult.No Then
                        Exit Function
                    End If

            End Select
            Return True
        Catch ex As Exception
            Return False
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
            Dim newName As String = nd.LocalName
            Dim oldName As String = newName
            Dim cnt As Integer = 0

TryAgain:   If ArrParentNodes.Contains(newName) = True Then
                cnt += 1
                newName = oldName & cnt.ToString
                GoTo TryAgain
            End If

            getChildElement = newName

        Catch ex As Exception
            getChildElement = ""
        End Try
    End Function

    Private Function getCDataElement(ByVal nd As Xml.XmlNode) As String
        Try
            Dim newName As String = nd.LocalName
            Dim oldName As String = newName
            Dim cnt As Integer = 0

TryAgain:   If ArrParentNodes.Contains(newName) = True Then
                cnt += 1
                newName = oldName & cnt.ToString
                GoTo TryAgain
            End If
            'If ArrPrintedChildren.Contains(newName) = True Then
            '    '  ArrPrintedChildren.Remove(newName)
            '    getCDataElement = newName
            'Else
            '    cnt += 1
            '    newName = oldName & cnt.ToString
            '    GoTo TryAgain

            'End If
        Catch ex As Exception
            getCDataElement = ""
        End Try
    End Function

    Private Function printNode(ByVal node As Xml.XmlNode) As Boolean
        Try
            Dim qualName As String = getParentElement(node)

            If qualName <> "" Then
                Dim childElement As String = ""
                Dim prefix As String = "     "
                Dim lineOne As String = String.Format("{0}{1}", "<!ELEMENT ", qualName)
                Dim lineTwo As String = String.Format("{0}", "(")
                Dim lineLast As String = String.Format("{0}", ")>")

                ArrAllElements.Add(qualName)
                ArrParentNodes.Add(qualName)

                sb.Append(lineOne)
                sb.Append(lineTwo)
                For Each chd As Xml.XmlNode In node.ChildNodes
                    If chd.NodeType = Xml.XmlNodeType.Element Then
                        Dim lineChd As String = String.Format("{0}{1}", prefix, childElement)
                        sb.Append(lineChd)
                        prefix = "    ,"
                        ArrAllElements.Add(childElement)
                        ArrPrintedChildren.Add(childElement)
                    End If
                Next
                sb.AppendLine(lineLast)
                sb.AppendLine()

                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Function printCData(ByVal Arrl As ArrayList) As Boolean
        Try
            Dim xmlField As String

            For Each name As String In Arrl
                xmlField = String.Format("{0}{1,-40}{2}", "<!ELEMENT ", name, " (#PCDATA)>")
                sb.AppendLine(xmlField)
            Next
            Return True

        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
