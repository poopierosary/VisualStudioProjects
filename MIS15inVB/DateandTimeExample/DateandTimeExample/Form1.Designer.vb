<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDateTime
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
        Me.lblFullDateTime = New System.Windows.Forms.Label()
        Me.lblLongTime = New System.Windows.Forms.Label()
        Me.lblShortTime = New System.Windows.Forms.Label()
        Me.lblLongDate = New System.Windows.Forms.Label()
        Me.lblShortDate = New System.Windows.Forms.Label()
        Me.btnFullDateTime = New System.Windows.Forms.Button()
        Me.btnLongTime = New System.Windows.Forms.Button()
        Me.btnShortTime = New System.Windows.Forms.Button()
        Me.btnLongDate = New System.Windows.Forms.Button()
        Me.btnShortDate = New System.Windows.Forms.Button()
        Me.lblText = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblFullDateTime
        '
        Me.lblFullDateTime.BackColor = System.Drawing.Color.White
        Me.lblFullDateTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFullDateTime.Location = New System.Drawing.Point(129, 354)
        Me.lblFullDateTime.Name = "lblFullDateTime"
        Me.lblFullDateTime.Size = New System.Drawing.Size(244, 23)
        Me.lblFullDateTime.TabIndex = 21
        Me.lblFullDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblLongTime
        '
        Me.lblLongTime.BackColor = System.Drawing.Color.White
        Me.lblLongTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLongTime.Location = New System.Drawing.Point(129, 294)
        Me.lblLongTime.Name = "lblLongTime"
        Me.lblLongTime.Size = New System.Drawing.Size(244, 23)
        Me.lblLongTime.TabIndex = 20
        Me.lblLongTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblShortTime
        '
        Me.lblShortTime.BackColor = System.Drawing.Color.White
        Me.lblShortTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblShortTime.Location = New System.Drawing.Point(129, 224)
        Me.lblShortTime.Name = "lblShortTime"
        Me.lblShortTime.Size = New System.Drawing.Size(244, 23)
        Me.lblShortTime.TabIndex = 19
        Me.lblShortTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblLongDate
        '
        Me.lblLongDate.BackColor = System.Drawing.Color.White
        Me.lblLongDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLongDate.Location = New System.Drawing.Point(129, 158)
        Me.lblLongDate.Name = "lblLongDate"
        Me.lblLongDate.Size = New System.Drawing.Size(244, 23)
        Me.lblLongDate.TabIndex = 18
        Me.lblLongDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblShortDate
        '
        Me.lblShortDate.BackColor = System.Drawing.Color.White
        Me.lblShortDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblShortDate.Location = New System.Drawing.Point(129, 105)
        Me.lblShortDate.Name = "lblShortDate"
        Me.lblShortDate.Size = New System.Drawing.Size(244, 23)
        Me.lblShortDate.TabIndex = 17
        Me.lblShortDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnFullDateTime
        '
        Me.btnFullDateTime.Location = New System.Drawing.Point(37, 354)
        Me.btnFullDateTime.Name = "btnFullDateTime"
        Me.btnFullDateTime.Size = New System.Drawing.Size(86, 23)
        Me.btnFullDateTime.TabIndex = 16
        Me.btnFullDateTime.Text = "Full Date Time"
        Me.btnFullDateTime.UseVisualStyleBackColor = True
        '
        'btnLongTime
        '
        Me.btnLongTime.Location = New System.Drawing.Point(37, 294)
        Me.btnLongTime.Name = "btnLongTime"
        Me.btnLongTime.Size = New System.Drawing.Size(86, 23)
        Me.btnLongTime.TabIndex = 15
        Me.btnLongTime.Text = "Long Time"
        Me.btnLongTime.UseVisualStyleBackColor = True
        '
        'btnShortTime
        '
        Me.btnShortTime.Location = New System.Drawing.Point(37, 224)
        Me.btnShortTime.Name = "btnShortTime"
        Me.btnShortTime.Size = New System.Drawing.Size(83, 23)
        Me.btnShortTime.TabIndex = 14
        Me.btnShortTime.Text = "Short Time"
        Me.btnShortTime.UseVisualStyleBackColor = True
        '
        'btnLongDate
        '
        Me.btnLongDate.Location = New System.Drawing.Point(37, 158)
        Me.btnLongDate.Name = "btnLongDate"
        Me.btnLongDate.Size = New System.Drawing.Size(86, 23)
        Me.btnLongDate.TabIndex = 13
        Me.btnLongDate.Text = "Long Date"
        Me.btnLongDate.UseVisualStyleBackColor = True
        '
        'btnShortDate
        '
        Me.btnShortDate.Location = New System.Drawing.Point(37, 105)
        Me.btnShortDate.Name = "btnShortDate"
        Me.btnShortDate.Size = New System.Drawing.Size(86, 23)
        Me.btnShortDate.TabIndex = 12
        Me.btnShortDate.Text = "Short Date"
        Me.btnShortDate.UseVisualStyleBackColor = True
        '
        'lblText
        '
        Me.lblText.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblText.Location = New System.Drawing.Point(122, 9)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(305, 23)
        Me.lblText.TabIndex = 11
        Me.lblText.Text = "Date and Time Example"
        Me.lblText.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frmDateTime
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 590)
        Me.Controls.Add(Me.lblFullDateTime)
        Me.Controls.Add(Me.lblLongTime)
        Me.Controls.Add(Me.lblShortTime)
        Me.Controls.Add(Me.lblLongDate)
        Me.Controls.Add(Me.lblShortDate)
        Me.Controls.Add(Me.btnFullDateTime)
        Me.Controls.Add(Me.btnLongTime)
        Me.Controls.Add(Me.btnShortTime)
        Me.Controls.Add(Me.btnLongDate)
        Me.Controls.Add(Me.btnShortDate)
        Me.Controls.Add(Me.lblText)
        Me.Name = "frmDateTime"
        Me.Text = "Date and Time Example"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblFullDateTime As Label
    Friend WithEvents lblLongTime As Label
    Friend WithEvents lblShortTime As Label
    Friend WithEvents lblLongDate As Label
    Friend WithEvents lblShortDate As Label
    Friend WithEvents btnFullDateTime As Button
    Friend WithEvents btnLongTime As Button
    Friend WithEvents btnShortTime As Button
    Friend WithEvents btnLongDate As Button
    Friend WithEvents btnShortDate As Button
    Friend WithEvents lblText As Label
End Class
