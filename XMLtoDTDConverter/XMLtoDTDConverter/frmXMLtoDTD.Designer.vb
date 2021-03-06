﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmXMLtoDTD
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
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
        Me.sfdDTDfile = New System.Windows.Forms.SaveFileDialog()
        Me.btnOpenFile = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.grpbInputXML.SuspendLayout()
        Me.grpbOutputDTD.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpbInputXML
        '
        Me.grpbInputXML.Controls.Add(Me.txtDisplayXML)
        Me.grpbInputXML.Controls.Add(Me.btnBrowse)
        Me.grpbInputXML.Controls.Add(Me.txtInputPath)
        Me.grpbInputXML.Location = New System.Drawing.Point(12, 42)
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
        Me.txtDisplayXML.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.btnBrowse.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnBrowse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.ForeColor = System.Drawing.Color.White
        Me.btnBrowse.Location = New System.Drawing.Point(498, 16)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(206, 23)
        Me.btnBrowse.TabIndex = 1
        Me.btnBrowse.Text = "Browse File"
        Me.btnBrowse.UseVisualStyleBackColor = False
        '
        'txtInputPath
        '
        Me.txtInputPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtInputPath.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInputPath.Location = New System.Drawing.Point(6, 19)
        Me.txtInputPath.Name = "txtInputPath"
        Me.txtInputPath.Size = New System.Drawing.Size(486, 20)
        Me.txtInputPath.TabIndex = 0
        '
        'ofdInputXMLFiles
        '
        Me.ofdInputXMLFiles.Filter = "XML Files|*.xml|All Files|*.*"
        Me.ofdInputXMLFiles.Title = "Open XML File"
        '
        'btnConvert
        '
        Me.btnConvert.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnConvert.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvert.ForeColor = System.Drawing.Color.White
        Me.btnConvert.Location = New System.Drawing.Point(239, 229)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(208, 23)
        Me.btnConvert.TabIndex = 1
        Me.btnConvert.Text = "Convert To DTD"
        Me.btnConvert.UseVisualStyleBackColor = False
        '
        'grpbOutputDTD
        '
        Me.grpbOutputDTD.Controls.Add(Me.btnSavefile)
        Me.grpbOutputDTD.Controls.Add(Me.txtOutputFilePath)
        Me.grpbOutputDTD.Controls.Add(Me.txtOutputDTD)
        Me.grpbOutputDTD.Location = New System.Drawing.Point(12, 264)
        Me.grpbOutputDTD.Name = "grpbOutputDTD"
        Me.grpbOutputDTD.Size = New System.Drawing.Size(710, 223)
        Me.grpbOutputDTD.TabIndex = 2
        Me.grpbOutputDTD.TabStop = False
        Me.grpbOutputDTD.Text = "Output DTD File"
        '
        'btnSavefile
        '
        Me.btnSavefile.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnSavefile.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSavefile.ForeColor = System.Drawing.Color.White
        Me.btnSavefile.Location = New System.Drawing.Point(498, 159)
        Me.btnSavefile.Name = "btnSavefile"
        Me.btnSavefile.Size = New System.Drawing.Size(206, 23)
        Me.btnSavefile.TabIndex = 2
        Me.btnSavefile.Text = "Save DTD File"
        Me.btnSavefile.UseVisualStyleBackColor = False
        '
        'txtOutputFilePath
        '
        Me.txtOutputFilePath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOutputFilePath.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.txtOutputDTD.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOutputDTD.Location = New System.Drawing.Point(6, 19)
        Me.txtOutputDTD.Multiline = True
        Me.txtOutputDTD.Name = "txtOutputDTD"
        Me.txtOutputDTD.ReadOnly = True
        Me.txtOutputDTD.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOutputDTD.Size = New System.Drawing.Size(698, 134)
        Me.txtOutputDTD.TabIndex = 0
        '
        'sfdDTDfile
        '
        Me.sfdDTDfile.Filter = "XML DTD Files|*.dtd|All Files|*.*"
        Me.sfdDTDfile.Title = "Save DTD Files"
        '
        'btnOpenFile
        '
        Me.btnOpenFile.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnOpenFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpenFile.ForeColor = System.Drawing.Color.White
        Me.btnOpenFile.Location = New System.Drawing.Point(510, 456)
        Me.btnOpenFile.Name = "btnOpenFile"
        Me.btnOpenFile.Size = New System.Drawing.Size(206, 23)
        Me.btnOpenFile.TabIndex = 3
        Me.btnOpenFile.Text = "Open DTD File"
        Me.btnOpenFile.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(641, 493)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 32)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'frmXMLtoDTD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 537)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnOpenFile)
        Me.Controls.Add(Me.grpbOutputDTD)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.grpbInputXML)
        Me.Name = "frmXMLtoDTD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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
    Friend WithEvents sfdDTDfile As SaveFileDialog
    Friend WithEvents btnOpenFile As Button
    Friend WithEvents btnClose As Button
End Class
