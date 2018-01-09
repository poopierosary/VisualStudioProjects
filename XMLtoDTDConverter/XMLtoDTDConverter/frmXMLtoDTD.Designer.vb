<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmXMLtoDTD
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grpbInputXML = New System.Windows.Forms.GroupBox()
        Me.txtDisplayXML = New System.Windows.Forms.TextBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.txtInputPath = New System.Windows.Forms.TextBox()
        Me.ofdInputXMLFiles = New System.Windows.Forms.OpenFileDialog()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.grpbOutputDTD = New System.Windows.Forms.GroupBox()
        Me.btnSavefile = New System.Windows.Forms.Button()
        Me.txtOutputFilePath = New System.Windows.Forms.TextBox()
        Me.txtOutputDTD = New System.Windows.Forms.TextBox()
        Me.grpbInputXML.SuspendLayout()
        Me.grpbOutputDTD.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpbInputXML
        '
        Me.grpbInputXML.Controls.Add(Me.txtDisplayXML)
        Me.grpbInputXML.Controls.Add(Me.btnBrowse)
        Me.grpbInputXML.Controls.Add(Me.txtInputPath)
        Me.grpbInputXML.Location = New System.Drawing.Point(12, 11)
        Me.grpbInputXML.Name = "grpbInputXML"
        Me.grpbInputXML.Size = New System.Drawing.Size(710, 171)
        Me.grpbInputXML.TabIndex = 0
        Me.grpbInputXML.TabStop = False
        Me.grpbInputXML.Text = "Input XML File"
        '
        'txtDisplayXML
        '
        Me.txtDisplayXML.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDisplayXML.BackColor = System.Drawing.Color.White
        Me.txtDisplayXML.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDisplayXML.Location = New System.Drawing.Point(6, 45)
        Me.txtDisplayXML.Multiline = True
        Me.txtDisplayXML.Name = "txtDisplayXML"
        Me.txtDisplayXML.ReadOnly = True
        Me.txtDisplayXML.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDisplayXML.Size = New System.Drawing.Size(698, 120)
        Me.txtDisplayXML.TabIndex = 2
        Me.txtDisplayXML.WordWrap = False
        '
        'btnBrowse
        '
        Me.btnBrowse.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBrowse.Location = New System.Drawing.Point(498, 16)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(206, 23)
        Me.btnBrowse.TabIndex = 1
        Me.btnBrowse.Text = "Browse File"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'txtInputPath
        '
        Me.txtInputPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtInputPath.Location = New System.Drawing.Point(6, 19)
        Me.txtInputPath.Name = "txtInputPath"
        Me.txtInputPath.Size = New System.Drawing.Size(486, 20)
        Me.txtInputPath.TabIndex = 0
        '
        'ofdInputXMLFiles
        '
        Me.ofdInputXMLFiles.Filter = "XML Fiels|*.xml|All Files|*.*"
        Me.ofdInputXMLFiles.Title = "Open XML File"
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(169, 206)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(208, 23)
        Me.btnConvert.TabIndex = 1
        Me.btnConvert.Text = "Convert To DTD"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'grpbOutputDTD
        '
        Me.grpbOutputDTD.Controls.Add(Me.btnSavefile)
        Me.grpbOutputDTD.Controls.Add(Me.txtOutputFilePath)
        Me.grpbOutputDTD.Controls.Add(Me.txtOutputDTD)
        Me.grpbOutputDTD.Location = New System.Drawing.Point(12, 248)
        Me.grpbOutputDTD.Name = "grpbOutputDTD"
        Me.grpbOutputDTD.Size = New System.Drawing.Size(710, 187)
        Me.grpbOutputDTD.TabIndex = 2
        Me.grpbOutputDTD.TabStop = False
        Me.grpbOutputDTD.Text = "Output DTD File"
        '
        'btnSavefile
        '
        Me.btnSavefile.Location = New System.Drawing.Point(498, 159)
        Me.btnSavefile.Name = "btnSavefile"
        Me.btnSavefile.Size = New System.Drawing.Size(206, 23)
        Me.btnSavefile.TabIndex = 2
        Me.btnSavefile.Text = "Save DTD File"
        Me.btnSavefile.UseVisualStyleBackColor = True
        '
        'txtOutputFilePath
        '
        Me.txtOutputFilePath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOutputFilePath.Location = New System.Drawing.Point(6, 161)
        Me.txtOutputFilePath.Name = "txtOutputFilePath"
        Me.txtOutputFilePath.Size = New System.Drawing.Size(486, 20)
        Me.txtOutputFilePath.TabIndex = 1
        '
        'txtOutputDTD
        '
        Me.txtOutputDTD.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOutputDTD.BackColor = System.Drawing.Color.White
        Me.txtOutputDTD.Location = New System.Drawing.Point(6, 19)
        Me.txtOutputDTD.Multiline = True
        Me.txtOutputDTD.Name = "txtOutputDTD"
        Me.txtOutputDTD.ReadOnly = True
        Me.txtOutputDTD.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOutputDTD.Size = New System.Drawing.Size(698, 124)
        Me.txtOutputDTD.TabIndex = 0
        '
        'frmXMLtoDTD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 537)
        Me.Controls.Add(Me.grpbOutputDTD)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.grpbInputXML)
        Me.Name = "frmXMLtoDTD"
        Me.Text = "XML to DTD Converter"
        Me.grpbInputXML.ResumeLayout(False)
        Me.grpbInputXML.PerformLayout()
        Me.grpbOutputDTD.ResumeLayout(False)
        Me.grpbOutputDTD.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpbInputXML As GroupBox
    Friend WithEvents txtInputPath As TextBox
    Friend WithEvents txtDisplayXML As TextBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents ofdInputXMLFiles As OpenFileDialog
    Friend WithEvents btnConvert As Button
    Friend WithEvents grpbOutputDTD As GroupBox
    Friend WithEvents txtOutputFilePath As TextBox
    Friend WithEvents txtOutputDTD As TextBox
    Friend WithEvents btnSavefile As Button
End Class
