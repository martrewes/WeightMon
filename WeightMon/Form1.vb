Public Class Main

    Dim strDate As Date
    Dim WeightKG As Decimal
    Dim WeightSt As Integer
    Dim WeightStLbs As String
    Dim WeightLbs As Decimal
    Dim GridView As Object

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAdd.Click


        If radBen.Checked = True Then
            GridView = grdBen
        ElseIf radSio.Checked = True Then
            GridView = grdSio
        End If

        If GridView Is Nothing Then
            MsgBox("Select user")
        Else AddData()
        End If

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        tbxLbs.Enabled = True
        tbxStone.Enabled = True
        tbxKG.Enabled = False
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        tbxLbs.Enabled = False
        tbxStone.Enabled = False
        tbxKG.Enabled = True
    End Sub

    Private Sub AddData()
        If RadioButton1.Checked = True Then



            strDate = DateTimePicker1.Value
            WeightKG = tbxKG.Text
            WeightLbs = Math.Round(WeightKG * 2.20462, 2)
            WeightSt = WeightLbs \ 14
            WeightStLbs = WeightSt & "st, " & WeightLbs - (WeightSt * 14) & "lbs"
            GridView.Rows.Add(strDate.ToShortDateString, WeightKG, WeightLbs, WeightStLbs)

            GridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            GridView.AutoResizeColumns()
            MsgBox(strDate.ToShortDateString & "    KG: " & WeightKG & ", Lbs: " & WeightLbs & ", And " & WeightStLbs)


        ElseIf RadioButton2.Checked = True Then

            strDate = DateTimePicker1.Value

            WeightLbs = (tbxStone.Text * 14) + tbxLbs.Text
            WeightSt = tbxStone.Text
            WeightKG = Math.Round(WeightLbs / 2.20462, 2)
            WeightStLbs = tbxStone.Text & "st, " & tbxLbs.Text & "lbs"
            GridView.Rows.Add(strDate.ToShortDateString, WeightKG, WeightLbs, WeightStLbs)
            GridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            GridView.AutoResizeColumns()
            MsgBox(strDate.ToShortDateString & "    KG: " & WeightKG & ", Lbs: " & WeightLbs & ", And " & WeightStLbs)

        Else
            MsgBox("Please select a Weight unit")
        End If

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles radBen.CheckedChanged

    End Sub
End Class
