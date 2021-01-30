﻿Imports System.IO

Public Class Main
    Dim strDate As Date
    Dim WeightKG As Decimal
    Dim WeightSt As Integer
    Dim WeightStLbs As String
    Dim WeightLbs As Decimal
    Dim GridView As Object
    Dim userfile As String
    Public goalBen As Decimal = My.Settings.goalBen
    Public kgoalSio As Decimal = My.Settings.goalSio


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAdd.Click


        If radBen.Checked = True Then
            GridView = grdBen
            userfile = "ben.txt"
        ElseIf radSio.Checked = True Then
            GridView = grdSio
            userfile = "siobhan.txt"
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
            Using objreader As New System.IO.StreamWriter(userfile, True) 'True = append.
                objreader.WriteLine(strDate.ToShortDateString & ";" & WeightKG & ";" & WeightLbs & ";" & WeightStLbs)
            End Using
            'MsgBox(strDate.ToShortDateString & "    KG: " & WeightKG & ", Lbs: " & WeightLbs & ", And " & WeightStLbs)
            RefreshCharts()


        ElseIf RadioButton2.Checked = True Then

            strDate = DateTimePicker1.Value
            WeightLbs = (tbxStone.Text * 14) + tbxLbs.Text
            WeightSt = tbxStone.Text
            WeightKG = Math.Round(WeightLbs / 2.20462, 2)
            WeightStLbs = tbxStone.Text & "st, " & tbxLbs.Text & "lbs"
            GridView.Rows.Add(strDate.ToShortDateString, WeightKG, WeightLbs, WeightStLbs)
            GridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            GridView.AutoResizeColumns()
            Using objreader As New System.IO.StreamWriter(userfile, True) 'True = append.
                objreader.WriteLine(strDate.ToShortDateString & ";" & WeightKG & ";" & WeightLbs & ";" & WeightStLbs)
            End Using
            'MsgBox(strDate.ToShortDateString & "    KG: " & WeightKG & ", Lbs: " & WeightLbs & ", And " & WeightStLbs)
            RefreshCharts()

        Else
            MsgBox("Please select a Weight unit")
        End If

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles radBen.CheckedChanged

    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkfiles()
        reader()
        RefreshCharts()
    End Sub

    Sub reader()

        If New FileInfo("ben.txt").Length.Equals(0) Then

        Else
            Using objReader As New StreamReader("ben.txt")
                Do While objReader.Peek() <> -1
                    Dim line As String = objReader.ReadLine()
                    Dim splitLine() As String = line.Split(";")
                    strDate = splitLine(0)
                    WeightKG = splitLine(1)
                    WeightLbs = splitLine(2)
                    WeightStLbs = splitLine(3)
                    Me.grdBen.Rows.Add(strDate.ToShortDateString, WeightKG, WeightLbs, WeightStLbs)
                    grdBen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                    grdBen.AutoResizeColumns()
                Loop
            End Using
        End If


        If New FileInfo("siobhan.txt").Length.Equals(0) Then

        Else
            Using objReader As New StreamReader("siobhan.txt")
                Do While objReader.Peek() <> -1
                    Dim line As String = objReader.ReadLine()
                    Dim splitLine() As String = line.Split(";")
                    strDate = splitLine(0)
                    WeightKG = splitLine(1)
                    WeightLbs = splitLine(2)
                    WeightStLbs = splitLine(3)
                    Me.grdSio.Rows.Add(strDate.ToShortDateString, WeightKG, WeightLbs, WeightStLbs)
                    grdSio.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                    grdSio.AutoResizeColumns()
                Loop
            End Using
        End If


    End Sub

    Private Sub checkfiles()
        If My.Computer.FileSystem.FileExists("Ben.txt") Then
            'MsgBox("We good")

        Else File.Create("ben.txt")
            FileClose()
        End If

        If My.Computer.FileSystem.FileExists("siobhan.txt") Then
            'MsgBox("We good")

        Else File.Create("siobhan.txt")
            FileClose()
        End If
    End Sub

    Private Sub RefreshCharts()
        chtBen.Series(0).Points.Clear()
        For Count As Integer = 0 To grdBen.Rows.Count - 2
            chtBen.Series(0).Points.AddXY(grdBen.Item(0, Count).Value, grdBen.Item(1, Count).Value)
        Next
        chtBen.Series(1).Points.Clear()
        For Count As Integer = 0 To grdBen.Rows.Count - 2
            chtBen.Series(1).Points.AddXY(grdBen.Item(0, Count).Value, goalBen)
            chtBen.Series(1).Color = Color.Green
        Next


        chtSio.Series(0).Points.Clear()
        For Count As Integer = 0 To grdSio.Rows.Count - 2
            chtSio.Series(0).Points.AddXY(grdSio.Item(0, Count).Value, grdSio.Item(1, Count).Value)
        Next
        chtSio.Series(1).Points.Clear()
        For Count As Integer = 0 To grdSio.Rows.Count - 2
            chtSio.Series(1).Points.AddXY(grdSio.Item(0, Count).Value, goalSio)
            chtSio.Series(1).Color = Color.Green
        Next

    End Sub

    Private Sub btnGoal_Click(sender As Object, e As EventArgs) Handles btnGoal.Click
        SetGoal.Show()
    End Sub
End Class
