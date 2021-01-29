Public Class Main
    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim strDate As Date
        Dim WeightKG As Decimal
        Dim WeightSt As Integer
        Dim WeightStLbs As String
        Dim WeightLbs As Decimal




        If RadioButton1.Checked = True Then
            strDate = DateTimePicker1.Value
            WeightKG = tbxKG.Text
            WeightLbs = Math.Round(WeightKG * 2.20462, 2)
            WeightSt = WeightLbs \ 14
            WeightStLbs = WeightSt & "st, " & WeightLbs - (WeightSt * 14) & "lbs"
            grdBen.Rows.Add(strDate.ToShortDateString, WeightKG, WeightLbs, WeightStLbs)

            grdBen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            grdBen.AutoResizeColumns()
            MsgBox(strDate.ToShortDateString & "    KG: " & WeightKG & ", Lbs: " & WeightLbs & ", And " & WeightStLbs)


        ElseIf RadioButton2.Checked = True Then

            strDate = DateTimePicker1.Value

            WeightLbs = (tbxStone.Text * 14) + tbxLbs.Text
            WeightSt = tbxStone.Text
            WeightKG = Math.Round(WeightLbs / 2.20462, 2)
            WeightStLbs = tbxStone.Text & "st, " & tbxLbs.Text & "lbs"
            grdBen.Rows.Add(strDate.ToShortDateString, WeightKG, WeightLbs, WeightStLbs)
            MsgBox(strDate.ToShortDateString & "    KG: " & WeightKG & ", Lbs: " & WeightLbs & ", And " & WeightStLbs)

        Else
            MsgBox("Please select a Weight unit")
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
End Class
