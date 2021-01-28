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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.colLbs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.tbxKG = New System.Windows.Forms.TextBox()
        Me.tbxStone = New System.Windows.Forms.TextBox()
        Me.tbxLbs = New System.Windows.Forms.TextBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        CType(Me.grdBen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdBen
        '
        Me.grdBen.AllowUserToAddRows = False
        Me.grdBen.AllowUserToDeleteRows = False
        Me.grdBen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdBen.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colDate, Me.colWeight, Me.colLbs, Me.colStone})
        Me.grdBen.Location = New System.Drawing.Point(42, 267)
        Me.grdBen.Name = "grdBen"
        Me.grdBen.RowHeadersVisible = False
        Me.grdBen.RowHeadersWidth = 62
        Me.grdBen.RowTemplate.Height = 28
        Me.grdBen.Size = New System.Drawing.Size(676, 150)
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
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(108, 87)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 50)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
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
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(283, 69)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 26)
        Me.DateTimePicker1.TabIndex = 2
        '
        'tbxKG
        '
        Me.tbxKG.Location = New System.Drawing.Point(339, 157)
        Me.tbxKG.Name = "tbxKG"
        Me.tbxKG.Size = New System.Drawing.Size(100, 26)
        Me.tbxKG.TabIndex = 3
        '
        'tbxStone
        '
        Me.tbxStone.Location = New System.Drawing.Point(556, 157)
        Me.tbxStone.Name = "tbxStone"
        Me.tbxStone.Size = New System.Drawing.Size(100, 26)
        Me.tbxStone.TabIndex = 4
        '
        'tbxLbs
        '
        Me.tbxLbs.Location = New System.Drawing.Point(675, 157)
        Me.tbxLbs.Name = "tbxLbs"
        Me.tbxLbs.Size = New System.Drawing.Size(95, 26)
        Me.tbxLbs.TabIndex = 5
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(339, 112)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(65, 24)
        Me.RadioButton1.TabIndex = 6
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "KGs"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(556, 112)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(80, 24)
        Me.RadioButton2.TabIndex = 7
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "St Lbs"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.tbxLbs)
        Me.Controls.Add(Me.tbxStone)
        Me.Controls.Add(Me.tbxKG)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.grdBen)
        Me.Name = "Main"
        Me.Text = "Form1"
        CType(Me.grdBen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grdBen As DataGridView
    Friend WithEvents colDate As DataGridViewTextBoxColumn
    Friend WithEvents colWeight As DataGridViewTextBoxColumn
    Friend WithEvents colLbs As DataGridViewTextBoxColumn
    Friend WithEvents colStone As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents tbxKG As TextBox
    Friend WithEvents tbxStone As TextBox
    Friend WithEvents tbxLbs As TextBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
End Class
