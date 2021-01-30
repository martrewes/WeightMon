Public Class SetGoal
    Private Sub SetGoal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbxBen.Text = My.Settings.goalBen
        tbxSio.Text = My.Settings.goalSio

    End Sub

    Private Sub btnSetGoal_Click(sender As Object, e As EventArgs) Handles btnSetGoal.Click
        Main.goalBen = tbxBen.Text
        Main.goalSio = tbxSio.Text
        My.Settings.goalBen = tbxBen.Text
        My.Settings.goalSio = tbxSio.Text
        Main.refreshCheck = True

        Me.Close()


    End Sub
End Class