<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SetGoal
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
        Me.btnSetGoal = New System.Windows.Forms.Button()
        Me.tbxBen = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radBenSt = New System.Windows.Forms.RadioButton()
        Me.tbxBenLb = New System.Windows.Forms.TextBox()
        Me.tbxBenSt = New System.Windows.Forms.TextBox()
        Me.radBenKg = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radSioSt = New System.Windows.Forms.RadioButton()
        Me.tbxSioLb = New System.Windows.Forms.TextBox()
        Me.tbxSioSt = New System.Windows.Forms.TextBox()
        Me.radSioKg = New System.Windows.Forms.RadioButton()
        Me.tbxSio = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSetGoal
        '
        Me.btnSetGoal.Location = New System.Drawing.Point(115, 95)
        Me.btnSetGoal.Name = "btnSetGoal"
        Me.btnSetGoal.Size = New System.Drawing.Size(91, 23)
        Me.btnSetGoal.TabIndex = 0
        Me.btnSetGoal.Text = "Set Goals"
        Me.btnSetGoal.UseVisualStyleBackColor = True
        '
        'tbxBen
        '
        Me.tbxBen.Location = New System.Drawing.Point(65, 19)
        Me.tbxBen.Name = "tbxBen"
        Me.tbxBen.Size = New System.Drawing.Size(71, 20)
        Me.tbxBen.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radBenSt)
        Me.GroupBox1.Controls.Add(Me.tbxBenLb)
        Me.GroupBox1.Controls.Add(Me.tbxBenSt)
        Me.GroupBox1.Controls.Add(Me.radBenKg)
        Me.GroupBox1.Controls.Add(Me.tbxBen)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(145, 77)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ben"
        '
        'radBenSt
        '
        Me.radBenSt.AutoSize = True
        Me.radBenSt.Location = New System.Drawing.Point(6, 49)
        Me.radBenSt.Name = "radBenSt"
        Me.radBenSt.Size = New System.Drawing.Size(53, 17)
        Me.radBenSt.TabIndex = 9
        Me.radBenSt.TabStop = True
        Me.radBenSt.Text = "St, Lb"
        Me.radBenSt.UseVisualStyleBackColor = True
        '
        'tbxBenLb
        '
        Me.tbxBenLb.Location = New System.Drawing.Point(103, 48)
        Me.tbxBenLb.Name = "tbxBenLb"
        Me.tbxBenLb.Size = New System.Drawing.Size(33, 20)
        Me.tbxBenLb.TabIndex = 8
        '
        'tbxBenSt
        '
        Me.tbxBenSt.Location = New System.Drawing.Point(65, 48)
        Me.tbxBenSt.Name = "tbxBenSt"
        Me.tbxBenSt.Size = New System.Drawing.Size(31, 20)
        Me.tbxBenSt.TabIndex = 7
        '
        'radBenKg
        '
        Me.radBenKg.AutoSize = True
        Me.radBenKg.Location = New System.Drawing.Point(6, 19)
        Me.radBenKg.Name = "radBenKg"
        Me.radBenKg.Size = New System.Drawing.Size(37, 17)
        Me.radBenKg.TabIndex = 5
        Me.radBenKg.TabStop = True
        Me.radBenKg.Text = "kg"
        Me.radBenKg.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radSioSt)
        Me.GroupBox2.Controls.Add(Me.tbxSioLb)
        Me.GroupBox2.Controls.Add(Me.tbxSioSt)
        Me.GroupBox2.Controls.Add(Me.radSioKg)
        Me.GroupBox2.Controls.Add(Me.tbxSio)
        Me.GroupBox2.Location = New System.Drawing.Point(163, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(145, 77)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Siobhan"
        '
        'radSioSt
        '
        Me.radSioSt.AutoSize = True
        Me.radSioSt.Location = New System.Drawing.Point(6, 49)
        Me.radSioSt.Name = "radSioSt"
        Me.radSioSt.Size = New System.Drawing.Size(53, 17)
        Me.radSioSt.TabIndex = 9
        Me.radSioSt.TabStop = True
        Me.radSioSt.Text = "St, Lb"
        Me.radSioSt.UseVisualStyleBackColor = True
        '
        'tbxSioLb
        '
        Me.tbxSioLb.Location = New System.Drawing.Point(103, 48)
        Me.tbxSioLb.Name = "tbxSioLb"
        Me.tbxSioLb.Size = New System.Drawing.Size(33, 20)
        Me.tbxSioLb.TabIndex = 8
        '
        'tbxSioSt
        '
        Me.tbxSioSt.Location = New System.Drawing.Point(65, 48)
        Me.tbxSioSt.Name = "tbxSioSt"
        Me.tbxSioSt.Size = New System.Drawing.Size(31, 20)
        Me.tbxSioSt.TabIndex = 7
        '
        'radSioKg
        '
        Me.radSioKg.AutoSize = True
        Me.radSioKg.Location = New System.Drawing.Point(6, 19)
        Me.radSioKg.Name = "radSioKg"
        Me.radSioKg.Size = New System.Drawing.Size(37, 17)
        Me.radSioKg.TabIndex = 5
        Me.radSioKg.TabStop = True
        Me.radSioKg.Text = "kg"
        Me.radSioKg.UseVisualStyleBackColor = True
        '
        'tbxSio
        '
        Me.tbxSio.Location = New System.Drawing.Point(65, 19)
        Me.tbxSio.Name = "tbxSio"
        Me.tbxSio.Size = New System.Drawing.Size(71, 20)
        Me.tbxSio.TabIndex = 1
        '
        'SetGoal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(320, 130)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSetGoal)
        Me.Name = "SetGoal"
        Me.ShowIcon = False
        Me.Text = "Set Weight Goal"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSetGoal As Button
    Friend WithEvents tbxBen As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radBenSt As RadioButton
    Friend WithEvents tbxBenLb As TextBox
    Friend WithEvents tbxBenSt As TextBox
    Friend WithEvents radBenKg As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents radSioSt As RadioButton
    Friend WithEvents tbxSioLb As TextBox
    Friend WithEvents tbxSioSt As TextBox
    Friend WithEvents radSioKg As RadioButton
    Friend WithEvents tbxSio As TextBox
End Class
