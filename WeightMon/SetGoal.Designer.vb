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
        Me.tbxSio = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radBen = New System.Windows.Forms.RadioButton()
        Me.tbxBenSt = New System.Windows.Forms.TextBox()
        Me.tbxBenLb = New System.Windows.Forms.TextBox()
        Me.radBenSt = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSetGoal
        '
        Me.btnSetGoal.Location = New System.Drawing.Point(123, 141)
        Me.btnSetGoal.Name = "btnSetGoal"
        Me.btnSetGoal.Size = New System.Drawing.Size(75, 23)
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
        Me.tbxBen.Text = "80"
        '
        'tbxSio
        '
        Me.tbxSio.Location = New System.Drawing.Point(12, 167)
        Me.tbxSio.Name = "tbxSio"
        Me.tbxSio.Size = New System.Drawing.Size(72, 20)
        Me.tbxSio.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Siobhan"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radBenSt)
        Me.GroupBox1.Controls.Add(Me.tbxBenLb)
        Me.GroupBox1.Controls.Add(Me.tbxBenSt)
        Me.GroupBox1.Controls.Add(Me.radBen)
        Me.GroupBox1.Controls.Add(Me.tbxBen)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(145, 77)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ben"
        '
        'radBen
        '
        Me.radBen.AutoSize = True
        Me.radBen.Location = New System.Drawing.Point(6, 19)
        Me.radBen.Name = "radBen"
        Me.radBen.Size = New System.Drawing.Size(37, 17)
        Me.radBen.TabIndex = 5
        Me.radBen.TabStop = True
        Me.radBen.Text = "kg"
        Me.radBen.UseVisualStyleBackColor = True
        '
        'tbxBenSt
        '
        Me.tbxBenSt.Location = New System.Drawing.Point(65, 48)
        Me.tbxBenSt.Name = "tbxBenSt"
        Me.tbxBenSt.Size = New System.Drawing.Size(31, 20)
        Me.tbxBenSt.TabIndex = 7
        Me.tbxBenSt.Text = "15"
        '
        'tbxBenLb
        '
        Me.tbxBenLb.Location = New System.Drawing.Point(103, 48)
        Me.tbxBenLb.Name = "tbxBenLb"
        Me.tbxBenLb.Size = New System.Drawing.Size(33, 20)
        Me.tbxBenLb.TabIndex = 8
        Me.tbxBenLb.Text = "14.6"
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
        'SetGoal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(297, 215)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSetGoal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbxSio)
        Me.Name = "SetGoal"
        Me.ShowIcon = False
        Me.Text = "Set Weight Goal"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSetGoal As Button
    Friend WithEvents tbxBen As TextBox
    Friend WithEvents tbxSio As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radBenSt As RadioButton
    Friend WithEvents tbxBenLb As TextBox
    Friend WithEvents tbxBenSt As TextBox
    Friend WithEvents radBen As RadioButton
End Class
