<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.equations = New System.Windows.Forms.Button()
        Me.helpBttn = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.thickTxt = New System.Windows.Forms.TextBox()
        Me.volTxt = New System.Windows.Forms.TextBox()
        Me.holeDiamTxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.reset = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Calculate = New System.Windows.Forms.Button()
        Me.fippleDiamTxt = New System.Windows.Forms.TextBox()
        Me.desiredFreqTxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.baseFreqTxt = New System.Windows.Forms.TextBox()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'equations
        '
        Me.equations.Location = New System.Drawing.Point(129, 221)
        Me.equations.Name = "equations"
        Me.equations.Size = New System.Drawing.Size(100, 23)
        Me.equations.TabIndex = 22
        Me.equations.Text = "Equations Used"
        Me.equations.UseVisualStyleBackColor = True
        '
        'helpBttn
        '
        Me.helpBttn.Location = New System.Drawing.Point(18, 221)
        Me.helpBttn.Name = "helpBttn"
        Me.helpBttn.Size = New System.Drawing.Size(51, 23)
        Me.helpBttn.TabIndex = 21
        Me.helpBttn.Text = "Help"
        Me.helpBttn.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.thickTxt)
        Me.Panel2.Controls.Add(Me.volTxt)
        Me.Panel2.Controls.Add(Me.holeDiamTxt)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Location = New System.Drawing.Point(12, 115)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(222, 100)
        Me.Panel2.TabIndex = 19
        '
        'thickTxt
        '
        Me.thickTxt.Location = New System.Drawing.Point(117, 54)
        Me.thickTxt.Name = "thickTxt"
        Me.thickTxt.Size = New System.Drawing.Size(100, 20)
        Me.thickTxt.TabIndex = 18
        '
        'volTxt
        '
        Me.volTxt.Location = New System.Drawing.Point(117, 32)
        Me.volTxt.Name = "volTxt"
        Me.volTxt.Size = New System.Drawing.Size(100, 20)
        Me.volTxt.TabIndex = 17
        '
        'holeDiamTxt
        '
        Me.holeDiamTxt.Location = New System.Drawing.Point(117, 76)
        Me.holeDiamTxt.Name = "holeDiamTxt"
        Me.holeDiamTxt.Size = New System.Drawing.Size(100, 20)
        Me.holeDiamTxt.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Results:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 79)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(106, 13)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Open Hole Diameter:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Volume: "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Thickness: "
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.reset)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Calculate)
        Me.Panel1.Controls.Add(Me.fippleDiamTxt)
        Me.Panel1.Controls.Add(Me.desiredFreqTxt)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.baseFreqTxt)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(222, 108)
        Me.Panel1.TabIndex = 20
        '
        'reset
        '
        Me.reset.Location = New System.Drawing.Point(7, 74)
        Me.reset.Name = "reset"
        Me.reset.Size = New System.Drawing.Size(75, 23)
        Me.reset.TabIndex = 19
        Me.reset.Text = "Restart"
        Me.reset.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fipple Diameter:"
        '
        'Calculate
        '
        Me.Calculate.Location = New System.Drawing.Point(142, 74)
        Me.Calculate.Name = "Calculate"
        Me.Calculate.Size = New System.Drawing.Size(75, 23)
        Me.Calculate.TabIndex = 6
        Me.Calculate.Text = "Calculate"
        Me.Calculate.UseVisualStyleBackColor = True
        '
        'fippleDiamTxt
        '
        Me.fippleDiamTxt.Location = New System.Drawing.Point(117, 3)
        Me.fippleDiamTxt.Name = "fippleDiamTxt"
        Me.fippleDiamTxt.Size = New System.Drawing.Size(100, 20)
        Me.fippleDiamTxt.TabIndex = 1
        '
        'desiredFreqTxt
        '
        Me.desiredFreqTxt.Location = New System.Drawing.Point(117, 48)
        Me.desiredFreqTxt.Name = "desiredFreqTxt"
        Me.desiredFreqTxt.Size = New System.Drawing.Size(100, 20)
        Me.desiredFreqTxt.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Base Frequency:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Next Note Frequency:"
        '
        'baseFreqTxt
        '
        Me.baseFreqTxt.Location = New System.Drawing.Point(117, 26)
        Me.baseFreqTxt.Name = "baseFreqTxt"
        Me.baseFreqTxt.Size = New System.Drawing.Size(100, 20)
        Me.baseFreqTxt.TabIndex = 3
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(240, 253)
        Me.Controls.Add(Me.equations)
        Me.Controls.Add(Me.helpBttn)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Main"
        Me.Text = "Main"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents equations As Button
    Friend WithEvents helpBttn As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents thickTxt As TextBox
    Friend WithEvents volTxt As TextBox
    Friend WithEvents holeDiamTxt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents reset As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Calculate As Button
    Friend WithEvents fippleDiamTxt As TextBox
    Friend WithEvents desiredFreqTxt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents baseFreqTxt As TextBox
End Class
