Public Class SetGoal
    Private Sub SetGoal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbxBen.Text = My.Settings.goalBen
        tbxSio.Text = My.Settings.goalSio

    End Sub
End Class