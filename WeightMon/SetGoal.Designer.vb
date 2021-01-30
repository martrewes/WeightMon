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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSetGoal
        '
        Me.btnSetGoal.Location = New System.Drawing.Point(123, 78)
        Me.btnSetGoal.Name = "btnSetGoal"
        Me.btnSetGoal.Size = New System.Drawing.Size(75, 23)
        Me.btnSetGoal.TabIndex = 0
        Me.btnSetGoal.Text = "Set Goals"
        Me.btnSetGoal.UseVisualStyleBackColor = True
        '
        'tbxBen
        '
        Me.tbxBen.Location = New System.Drawing.Point(6, 32)
        Me.tbxBen.Name = "tbxBen"
        Me.tbxBen.Size = New System.Drawing.Size(72, 20)
        Me.tbxBen.TabIndex = 1
        '
        'tbxSio
        '
        Me.tbxSio.Location = New System.Drawing.Point(107, 32)
        Me.tbxSio.Name = "tbxSio"
        Me.tbxSio.Size = New System.Drawing.Size(72, 20)
        Me.tbxSio.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Ben"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(104, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Siobhan"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tbxSio)
        Me.GroupBox1.Controls.Add(Me.tbxBen)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(186, 60)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Please use KG only"
        '
        'SetGoal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(209, 113)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSetGoal)
        Me.Name = "SetGoal"
        Me.ShowIcon = False
        Me.Text = "Set Weight Goal"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSetGoal As Button
    Friend WithEvents tbxBen As TextBox
    Friend WithEvents tbxSio As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
End Class
