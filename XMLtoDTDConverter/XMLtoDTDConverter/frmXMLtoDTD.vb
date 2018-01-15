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
            btnOpenFile.Enabled = False
            btnConvert.Enabled = False
            btnSavefile.Enabled = False
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
            'LogError(ex, "frmXMLconv OFD1_FileOk")
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
                    If MsgBox("Testing: " & Node.Name & Chr(13) &
                            "Testing", MsgBoxStyle.YesNo, "Testing Failed") = MsgBoxResult.No Then
                        Exit Function
                    End If

            End Select
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Function getNode(ByVal node As Xml.XmlNode) As enumXMLActionType
        Try
            Dim isParentElemet As Boolean = False

            If node.HasChildNodes = True Then
                Dim numEle As Integer = 0
                For Each nde As Xml.XmlNode In node.ChildNodes
                    If nde.NodeType = Xml.XmlNodeType.Element Then
                        If nde.HasChildNodes Then
                            If nde.FirstChild.NodeType = Xml.XmlNodeType.Element Then
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
                If node.NodeType = Xml.XmlNodeType.Element Then
                    getNode = enumXMLActionType.Enum_PrintAsCData
                Else
                    getNode = enumXMLActionType.Enum_Ignore
                End If
            End If

        Catch ex As Exception
            getNode = enumXMLActionType.Failed
            sb.AppendLine("Somethign happened here" & node.Name)
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

TryAgain:   If ArrParentNodes.Contains(NewName) = True Then
                cnt += 1
                newName = oldName & cnt.ToString
                GoTo TryAgain
            End If
            If ArrPrintedChildren.Contains(newName) = True Then
                ArrPrintedChildren.Remove(newName)
                getCDataElement = newName
            Else
                cnt += 1
                newName = oldName & cnt.ToString
                GoTo TryAgain
            End If

        Catch ex As Exception
            getCDataElement = ""
        End Try
    End Function

    Private Function printNode(ByVal node As Xml.XmlNode) As Boolean
        Try
            Dim qualName As String = getParentElement(node)

            If qualName <> "" Then
                Dim childElement As String = ""
                Dim Prefix As String = "     "
                Dim Line1 As String = String.Format("{0}{1}", "<!ELEMENT ", qualName)
                Dim Line2 As String = String.Format("{0}", "(")
                Dim LastLine As String = String.Format("{0}", ")>")

                ArrAllElements.Add(qualName)
                ArrParentNodes.Add(qualName)

                sb.AppendLine(Line1)
                sb.AppendLine(Line2)
                For Each cld As Xml.XmlNode In node.ChildNodes
                    If cld.NodeType = Xml.XmlNodeType.Element Then
                        childElement = getChildElement(cld)
                        Dim LineChild As String = String.Format("{0}{1}", Prefix, childElement)
                        sb.AppendLine(LineChild)
                        Prefix = "    ,"

                        ArrAllElements.Add(childElement)
                        ArrPrintedChildren.Add(childElement)
                    End If
                Next
                sb.AppendLine(LastLine)
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
            Dim XMLfield As String

            For Each name As String In Arrl
                XMLfield = String.Format("{0}{1,-40}{2}", "<!ELEMENT ", name, " (#PCDATA)>")
                sb.AppendLine(XMLfield)
            Next

            Return True

        Catch ex As Exception

            Return False
        End Try

    End Function

    Private Sub btnSavefile_Click(sender As Object, e As EventArgs) Handles btnSavefile.Click
        Try
            sfdDTDfile.Title = "DTD File"
            If InputDirectory <> "" Then
                sfdDTDfile.InitialDirectory = InputDirectory
            End If
            sfdDTDfile.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub sfdDTDfile_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles sfdDTDfile.FileOk
        Try
            OutputFilePath = sfdDTDfile.FileName
            txtOutputFilePath.Text = OutputFilePath
            If OutputFilePath <> "" Then
                If save() = True Then

                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Function save() As Boolean
        Try
            If sfdDTDfile.FileName <> "" Then
                save = saveDTDfile(OutputFilePath, txtOutputDTD.Text)
            Else

                save = False
            End If

        Catch ex As Exception
            save = False
        End Try
    End Function

    Public Function saveDTDfile(ByVal filePath As String, ByVal fileContent As String, Optional appendFile As Boolean = False) As Boolean
        Dim writeTofile As System.IO.StreamWriter = Nothing
        Dim writeTofile2 As System.IO.StreamWriter = Nothing
        Try
            writeTofile = New System.IO.StreamWriter(filePath, appendFile)

            writeTofile.Write(fileContent)
            Return True
        Catch ex As Exception
            Return False
        Finally
            If writeTofile IsNot Nothing Then
                writeTofile.Close()
            End If

        End Try

    End Function

    Private Sub btnOpenFile_Click(sender As Object, e As EventArgs) Handles btnOpenFile.Click

        Try
            If OutputFilePath <> "" Then
                Dim OpenFile As New System.Diagnostics.Process
                Process.Start(OutputFilePath)
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class
