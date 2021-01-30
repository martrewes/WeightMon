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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chtBen = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGoal = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.chtSio = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.grdBen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdSio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.chtBen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chtSio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdBen
        '
        Me.grdBen.AllowUserToAddRows = False
        Me.grdBen.AllowUserToDeleteRows = False
        Me.grdBen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdBen.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colDate, Me.colWeight, Me.colLbs, Me.colStone})
        Me.grdBen.Location = New System.Drawing.Point(11, 165)
        Me.grdBen.Margin = New System.Windows.Forms.Padding(2)
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
        Me.btnAdd.Location = New System.Drawing.Point(447, 104)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(77, 32)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(208, 15)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(2)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(98, 20)
        Me.DateTimePicker1.TabIndex = 2
        '
        'tbxKG
        '
        Me.tbxKG.Location = New System.Drawing.Point(5, 39)
        Me.tbxKG.Margin = New System.Windows.Forms.Padding(2)
        Me.tbxKG.Name = "tbxKG"
        Me.tbxKG.Size = New System.Drawing.Size(68, 20)
        Me.tbxKG.TabIndex = 3
        '
        'tbxStone
        '
        Me.tbxStone.Location = New System.Drawing.Point(169, 39)
        Me.tbxStone.Margin = New System.Windows.Forms.Padding(2)
        Me.tbxStone.Name = "tbxStone"
        Me.tbxStone.Size = New System.Drawing.Size(68, 20)
        Me.tbxStone.TabIndex = 4
        '
        'tbxLbs
        '
        Me.tbxLbs.Location = New System.Drawing.Point(241, 39)
        Me.tbxLbs.Margin = New System.Windows.Forms.Padding(2)
        Me.tbxLbs.Name = "tbxLbs"
        Me.tbxLbs.Size = New System.Drawing.Size(65, 20)
        Me.tbxLbs.TabIndex = 5
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(5, 18)
        Me.RadioButton1.Margin = New System.Windows.Forms.Padding(2)
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
        Me.RadioButton2.Location = New System.Drawing.Point(169, 18)
        Me.RadioButton2.Margin = New System.Windows.Forms.Padding(2)
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
        Me.grdSio.Location = New System.Drawing.Point(269, 165)
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
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(311, 44)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "User and Date"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioButton2)
        Me.GroupBox2.Controls.Add(Me.tbxLbs)
        Me.GroupBox2.Controls.Add(Me.tbxStone)
        Me.GroupBox2.Controls.Add(Me.RadioButton1)
        Me.GroupBox2.Controls.Add(Me.tbxKG)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 65)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(311, 71)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Weight and Unit"
        '
        'chtBen
        '
        Me.chtBen.BackSecondaryColor = System.Drawing.Color.Silver
        Me.chtBen.BorderSkin.BorderColor = System.Drawing.Color.Gray
        ChartArea1.AxisX.LabelStyle.Enabled = False
        ChartArea1.AxisX.MajorGrid.LineWidth = 0
        ChartArea1.AxisY.LineColor = System.Drawing.Color.LightGray
        ChartArea1.AxisY.MajorGrid.LineWidth = 0
        ChartArea1.Name = "ChartArea1"
        Me.chtBen.ChartAreas.Add(ChartArea1)
        Me.chtBen.Enabled = False
        Legend1.Enabled = False
        Legend1.Name = "Legend1"
        Me.chtBen.Legends.Add(Legend1)
        Me.chtBen.Location = New System.Drawing.Point(11, 336)
        Me.chtBen.Name = "chtBen"
        Me.chtBen.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series2.Legend = "Legend1"
        Series2.Name = "Series2"
        Me.chtBen.Series.Add(Series1)
        Me.chtBen.Series.Add(Series2)
        Me.chtBen.Size = New System.Drawing.Size(254, 150)
        Me.chtBen.TabIndex = 13
        Me.chtBen.Text = "Chart1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(176, 398)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 24)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Not Functioning Yet"
        '
        'btnGoal
        '
        Me.btnGoal.Location = New System.Drawing.Point(11, 492)
        Me.btnGoal.Name = "btnGoal"
        Me.btnGoal.Size = New System.Drawing.Size(120, 23)
        Me.btnGoal.TabIndex = 16
        Me.btnGoal.Text = "Set New Goal..."
        Me.btnGoal.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(14, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 24)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Ben"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(272, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 24)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Siobhan"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(456, 31)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(456, 61)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'chtSio
        '
        Me.chtSio.BackSecondaryColor = System.Drawing.Color.Silver
        Me.chtSio.BorderSkin.BorderColor = System.Drawing.Color.Gray
        ChartArea2.AxisX.LabelStyle.Enabled = False
        ChartArea2.AxisX.MajorGrid.LineWidth = 0
        ChartArea2.AxisY.LineColor = System.Drawing.Color.LightGray
        ChartArea2.AxisY.MajorGrid.LineWidth = 0
        ChartArea2.Name = "ChartArea1"
        Me.chtSio.ChartAreas.Add(ChartArea2)
        Me.chtSio.Enabled = False
        Legend2.Enabled = False
        Legend2.Name = "Legend1"
        Me.chtSio.Legends.Add(Legend2)
        Me.chtSio.Location = New System.Drawing.Point(269, 336)
        Me.chtSio.Name = "chtSio"
        Me.chtSio.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series3.Legend = "Legend1"
        Series3.Name = "Series1"
        Series4.ChartArea = "ChartArea1"
        Series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series4.Legend = "Legend1"
        Series4.Name = "Series2"
        Me.chtSio.Series.Add(Series3)
        Me.chtSio.Series.Add(Series4)
        Me.chtSio.Size = New System.Drawing.Size(254, 150)
        Me.chtSio.TabIndex = 21
        Me.chtSio.Text = "Chart1"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 524)
        Me.Controls.Add(Me.chtSio)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnGoal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chtBen)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grdSio)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.grdBen)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Main"
        Me.ShowIcon = False
        Me.Text = "Weight Monitor"
        CType(Me.grdBen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdSio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.chtBen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chtSio, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chtBen As DataVisualization.Charting.Chart
    Friend WithEvents Label1 As Label
    Friend WithEvents btnGoal As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents chtSio As DataVisualization.Charting.Chart
End Class
