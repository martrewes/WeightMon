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
        Me.grdBen = New System.Windows.Forms.DataGridView()
        Me.colDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colWeight = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLbs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.tbxKG = New System.Windows.Forms.TextBox()
        Me.tbxStone = New System.Windows.Forms.TextBox()
        Me.tbxLbs = New System.Windows.Forms.TextBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.grdSio = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.radBen = New System.Windows.Forms.RadioButton()
        Me.radSio = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.grdBen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdSio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdBen
        '
        Me.grdBen.AllowUserToAddRows = False
        Me.grdBen.AllowUserToDeleteRows = False
        Me.grdBen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdBen.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colDate, Me.colWeight, Me.colLbs, Me.colStone})
        Me.grdBen.Location = New System.Drawing.Point(20, 272)
        Me.grdBen.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.grdBen.Name = "grdBen"
        Me.grdBen.RowHeadersVisible = False
        Me.grdBen.RowHeadersWidth = 62
        Me.grdBen.RowTemplate.Height = 28
        Me.grdBen.Size = New System.Drawing.Size(254, 165)
        Me.grdBen.TabIndex = 0
        '
        'colDate
        '
        Me.colDate.HeaderText = "Date"
        Me.colDate.MinimumWidth = 8
        Me.colDate.Name = "colDate"
        Me.colDate.Width = 150
        '
        'colWeight
        '
        Me.colWeight.HeaderText = "Weight"
        Me.colWeight.MinimumWidth = 8
        Me.colWeight.Name = "colWeight"
        Me.colWeight.Width = 150
        '
        'colLbs
        '
        Me.colLbs.HeaderText = "Lbs"
        Me.colLbs.MinimumWidth = 8
        Me.colLbs.Name = "colLbs"
        Me.colLbs.Width = 150
        '
        'colStone
        '
        Me.colStone.HeaderText = "Stone"
        Me.colStone.MinimumWidth = 8
        Me.colStone.Name = "colStone"
        Me.colStone.Width = 150
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(455, 225)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(77, 32)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(208, 19)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(98, 20)
        Me.DateTimePicker1.TabIndex = 2
        '
        'tbxKG
        '
        Me.tbxKG.Location = New System.Drawing.Point(20, 237)
        Me.tbxKG.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tbxKG.Name = "tbxKG"
        Me.tbxKG.Size = New System.Drawing.Size(68, 20)
        Me.tbxKG.TabIndex = 3
        '
        'tbxStone
        '
        Me.tbxStone.Location = New System.Drawing.Point(132, 237)
        Me.tbxStone.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tbxStone.Name = "tbxStone"
        Me.tbxStone.Size = New System.Drawing.Size(68, 20)
        Me.tbxStone.TabIndex = 4
        '
        'tbxLbs
        '
        Me.tbxLbs.Location = New System.Drawing.Point(211, 237)
        Me.tbxLbs.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tbxLbs.Name = "tbxLbs"
        Me.tbxLbs.Size = New System.Drawing.Size(65, 20)
        Me.tbxLbs.TabIndex = 5
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(20, 208)
        Me.RadioButton1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(45, 17)
        Me.RadioButton1.TabIndex = 6
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "KGs"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(132, 208)
        Me.RadioButton2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(55, 17)
        Me.RadioButton2.TabIndex = 7
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "St Lbs"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'grdSio
        '
        Me.grdSio.AllowUserToAddRows = False
        Me.grdSio.AllowUserToDeleteRows = False
        Me.grdSio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdSio.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.grdSio.Location = New System.Drawing.Point(278, 272)
        Me.grdSio.Margin = New System.Windows.Forms.Padding(2)
        Me.grdSio.Name = "grdSio"
        Me.grdSio.RowHeadersVisible = False
        Me.grdSio.RowHeadersWidth = 62
        Me.grdSio.RowTemplate.Height = 28
        Me.grdSio.Size = New System.Drawing.Size(254, 165)
        Me.grdSio.TabIndex = 8
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Weight"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Lbs"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Stone"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 150
        '
        'radBen
        '
        Me.radBen.AutoSize = True
        Me.radBen.Location = New System.Drawing.Point(6, 19)
        Me.radBen.Name = "radBen"
        Me.radBen.Size = New System.Drawing.Size(44, 17)
        Me.radBen.TabIndex = 9
        Me.radBen.TabStop = True
        Me.radBen.Text = "Ben"
        Me.radBen.UseVisualStyleBackColor = True
        '
        'radSio
        '
        Me.radSio.AutoSize = True
        Me.radSio.Location = New System.Drawing.Point(56, 19)
        Me.radSio.Name = "radSio"
        Me.radSio.Size = New System.Drawing.Size(64, 17)
        Me.radSio.TabIndex = 10
        Me.radSio.TabStop = True
        Me.radSio.Text = "Siobhan"
        Me.radSio.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radSio)
        Me.GroupBox1.Controls.Add(Me.radBen)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 133)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(311, 55)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "User and Date"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(759, 544)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grdSio)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.tbxLbs)
        Me.Controls.Add(Me.tbxStone)
        Me.Controls.Add(Me.tbxKG)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.grdBen)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Main"
        Me.Text = "Form1"
        CType(Me.grdBen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdSio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grdBen As DataGridView
    Friend WithEvents colDate As DataGridViewTextBoxColumn
    Friend WithEvents colWeight As DataGridViewTextBoxColumn
    Friend WithEvents colLbs As DataGridViewTextBoxColumn
    Friend WithEvents colStone As DataGridViewTextBoxColumn
    Friend WithEvents btnAdd As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents tbxKG As TextBox
    Friend WithEvents tbxStone As TextBox
    Friend WithEvents tbxLbs As TextBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents grdSio As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents radBen As RadioButton
    Friend WithEvents radSio As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
End Class
