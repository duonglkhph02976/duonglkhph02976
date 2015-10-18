<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHTTT
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
        Me.lblClassID = New System.Windows.Forms.Label()
        Me.txtClassID = New System.Windows.Forms.TextBox()
        Me.lblMA_KH = New System.Windows.Forms.Label()
        Me.txtMA_KH = New System.Windows.Forms.TextBox()
        Me.lblTEN_KH = New System.Windows.Forms.Label()
        Me.txtTEN_KH = New System.Windows.Forms.TextBox()
        Me.lblADDRESS = New System.Windows.Forms.Label()
        Me.txtPHONE = New System.Windows.Forms.TextBox()
        Me.lblPHONE = New System.Windows.Forms.Label()
        Me.txtADDRESS = New System.Windows.Forms.TextBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblClassID
        '
        Me.lblClassID.AutoSize = True
        Me.lblClassID.Location = New System.Drawing.Point(55, 35)
        Me.lblClassID.Name = "lblClassID"
        Me.lblClassID.Size = New System.Drawing.Size(46, 13)
        Me.lblClassID.TabIndex = 0
        Me.lblClassID.Text = "ClassID:"
        '
        'txtClassID
        '
        Me.txtClassID.Location = New System.Drawing.Point(133, 32)
        Me.txtClassID.Name = "txtClassID"
        Me.txtClassID.ReadOnly = True
        Me.txtClassID.Size = New System.Drawing.Size(100, 20)
        Me.txtClassID.TabIndex = 1
        '
        'lblMA_KH
        '
        Me.lblMA_KH.AutoSize = True
        Me.lblMA_KH.Location = New System.Drawing.Point(55, 61)
        Me.lblMA_KH.Name = "lblMA_KH"
        Me.lblMA_KH.Size = New System.Drawing.Size(47, 13)
        Me.lblMA_KH.TabIndex = 0
        Me.lblMA_KH.Text = "MA_KH:"
        '
        'txtMA_KH
        '
        Me.txtMA_KH.Location = New System.Drawing.Point(133, 58)
        Me.txtMA_KH.Name = "txtMA_KH"
        Me.txtMA_KH.Size = New System.Drawing.Size(100, 20)
        Me.txtMA_KH.TabIndex = 1
        '
        'lblTEN_KH
        '
        Me.lblTEN_KH.AutoSize = True
        Me.lblTEN_KH.Location = New System.Drawing.Point(55, 87)
        Me.lblTEN_KH.Name = "lblTEN_KH"
        Me.lblTEN_KH.Size = New System.Drawing.Size(53, 13)
        Me.lblTEN_KH.TabIndex = 0
        Me.lblTEN_KH.Text = "TEN_KH:"
        '
        'txtTEN_KH
        '
        Me.txtTEN_KH.Location = New System.Drawing.Point(133, 84)
        Me.txtTEN_KH.Name = "txtTEN_KH"
        Me.txtTEN_KH.Size = New System.Drawing.Size(100, 20)
        Me.txtTEN_KH.TabIndex = 1
        '
        'lblADDRESS
        '
        Me.lblADDRESS.AutoSize = True
        Me.lblADDRESS.Location = New System.Drawing.Point(55, 143)
        Me.lblADDRESS.Name = "lblADDRESS"
        Me.lblADDRESS.Size = New System.Drawing.Size(48, 13)
        Me.lblADDRESS.TabIndex = 0
        Me.lblADDRESS.Text = "PHONE:"
        '
        'txtPHONE
        '
        Me.txtPHONE.Location = New System.Drawing.Point(133, 110)
        Me.txtPHONE.Name = "txtPHONE"
        Me.txtPHONE.Size = New System.Drawing.Size(100, 20)
        Me.txtPHONE.TabIndex = 1
        '
        'lblPHONE
        '
        Me.lblPHONE.AutoSize = True
        Me.lblPHONE.Location = New System.Drawing.Point(55, 117)
        Me.lblPHONE.Name = "lblPHONE"
        Me.lblPHONE.Size = New System.Drawing.Size(62, 13)
        Me.lblPHONE.TabIndex = 0
        Me.lblPHONE.Text = "ADDRESS:"
        '
        'txtADDRESS
        '
        Me.txtADDRESS.Location = New System.Drawing.Point(133, 136)
        Me.txtADDRESS.Name = "txtADDRESS"
        Me.txtADDRESS.Size = New System.Drawing.Size(100, 20)
        Me.txtADDRESS.TabIndex = 1
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(58, 190)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "&OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(158, 190)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'FrmHTTT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.txtPHONE)
        Me.Controls.Add(Me.txtMA_KH)
        Me.Controls.Add(Me.lblADDRESS)
        Me.Controls.Add(Me.lblMA_KH)
        Me.Controls.Add(Me.txtTEN_KH)
        Me.Controls.Add(Me.lblTEN_KH)
        Me.Controls.Add(Me.txtADDRESS)
        Me.Controls.Add(Me.lblPHONE)
        Me.Controls.Add(Me.txtClassID)
        Me.Controls.Add(Me.lblClassID)
        Me.Name = "FrmHTTT"
        Me.Text = "HTTT"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblClassID As Label
    Friend WithEvents txtClassID As TextBox
    Friend WithEvents lblMA_KH As Label
    Friend WithEvents txtMA_KH As TextBox
    Friend WithEvents lblTEN_KH As Label
    Friend WithEvents txtTEN_KH As TextBox
    Friend WithEvents lblADDRESS As Label
    Friend WithEvents txtPHONE As TextBox
    Friend WithEvents lblPHONE As Label
    Friend WithEvents txtADDRESS As TextBox
    Friend WithEvents btnOK As Button
    Friend WithEvents btnCancel As Button
End Class
