﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.txtInputPath = New System.Windows.Forms.TextBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.txtDisplayXML = New System.Windows.Forms.TextBox()
        Me.grpbInputXML.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpbInputXML
        '
        Me.grpbInputXML.Controls.Add(Me.txtDisplayXML)
        Me.grpbInputXML.Controls.Add(Me.btnBrowse)
        Me.grpbInputXML.Controls.Add(Me.txtInputPath)
        Me.grpbInputXML.Location = New System.Drawing.Point(12, 74)
        Me.grpbInputXML.Name = "grpbInputXML"
        Me.grpbInputXML.Size = New System.Drawing.Size(710, 173)
        Me.grpbInputXML.TabIndex = 0
        Me.grpbInputXML.TabStop = False
        Me.grpbInputXML.Text = "Input XML File"
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
        'btnBrowse
        '
        Me.btnBrowse.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBrowse.Location = New System.Drawing.Point(498, 17)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(206, 23)
        Me.btnBrowse.TabIndex = 1
        Me.btnBrowse.Text = "Browse File"
        Me.btnBrowse.UseVisualStyleBackColor = True
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
        Me.txtDisplayXML.Size = New System.Drawing.Size(698, 122)
        Me.txtDisplayXML.TabIndex = 2
        Me.txtDisplayXML.WordWrap = False
        '
        'frmXMLtoDTD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 537)
        Me.Controls.Add(Me.grpbInputXML)
        Me.Name = "frmXMLtoDTD"
        Me.Text = "XML to DTD Converter"
        Me.grpbInputXML.ResumeLayout(False)
        Me.grpbInputXML.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpbInputXML As GroupBox
    Friend WithEvents txtInputPath As TextBox
    Friend WithEvents txtDisplayXML As TextBox
    Friend WithEvents btnBrowse As Button
End Class