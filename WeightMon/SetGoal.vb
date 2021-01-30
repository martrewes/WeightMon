Public Class SetGoal
    Private Sub SetGoal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbxBen.Text = My.Settings.goalBen
        tbxSio.Text = My.Settings.goalSio
        radBenKg.Checked = True
        radSioKg.Checked = True


    End Sub

    Private Sub btnSetGoal_Click(sender As Object, e As EventArgs) Handles btnSetGoal.Click
        If radBenKg.Checked = True Then
            Main.goalBen = tbxBen.Text
        Else
            Dim goal As Decimal
            goal = (tbxBenSt.Text * 14) + tbxBenLb.Text
            goal = Math.Round(goal / 2.20462, 2)
            Main.goalBen = goal
        End If

        If radSioKg.Checked = True Then
            Main.goalSio = tbxSio.Text
        Else
            Dim goal As Decimal
            goal = (tbxSioSt.Text * 14) + tbxSioLb.Text
            goal = Math.Round(goal / 2.20462, 2)
            Main.goalSio = goal
        End If

        Main.refreshCheck = True

        Me.Close()


    End Sub


    Private Sub tbxBen_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxBen.KeyPress
        'Validating only numbers and decimal points
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "." Then
            e.Handled = True
        End If

    End Sub
    Private Sub tbxBenKg_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxBenSt.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "." Then
            e.Handled = True
        End If

    End Sub
    Private Sub tbxBenLb_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxBenLb.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "." Then
            e.Handled = True
        End If

    End Sub
    Private Sub tbxSio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxBen.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "." Then
            e.Handled = True
        End If

    End Sub
    Private Sub tbxSioSt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxBen.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "." Then
            e.Handled = True
        End If

    End Sub
    Private Sub tbxSioLb_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxBen.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "." Then
            e.Handled = True
        End If

    End Sub

    Private Sub radBenKg_CheckedChanged(sender As Object, e As EventArgs) Handles radBenKg.CheckedChanged
        tbxBenSt.Enabled = False
        tbxBenLb.Enabled = False
        tbxBen.Enabled = True

    End Sub

    Private Sub radBenSt_CheckedChanged(sender As Object, e As EventArgs) Handles radBenSt.CheckedChanged
        tbxBenSt.Enabled = True
        tbxBenLb.Enabled = True
        tbxBen.Enabled = False


    End Sub

    Private Sub radSioKg_CheckedChanged(sender As Object, e As EventArgs) Handles radSioKg.CheckedChanged
        tbxSioSt.Enabled = False
        tbxSioLb.Enabled = False
        tbxSio.Enabled = True

    End Sub

    Private Sub radSioSt_CheckedChanged(sender As Object, e As EventArgs) Handles radSioSt.CheckedChanged
        tbxSioSt.Enabled = True
        tbxSioLb.Enabled = True
        tbxSio.Enabled = False


    End Sub
End Class