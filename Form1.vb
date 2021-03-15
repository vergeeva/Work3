Public Class Form1
    Private Sub Flag_Click(sender As Object, e As EventArgs) Handles Flag.Click
        ListBox1.Items.RemoveAt(ListBox1.Items.Count - 1)
    End Sub

    Private Sub TurnOnRadio_Click(sender As Object, e As EventArgs) Handles TurnOnRadio.Click
        Flag.Checked = True
        Flag.Enabled = True
        ListBox1.Items.Add("Включен")

    End Sub

    Private Sub TurnOffRadio_Click(sender As Object, e As EventArgs) Handles TurnOffRadio.Click
        Flag.Checked = False
        Flag.Enabled = True
        ListBox1.Items.Add("Выключен")
    End Sub

    Private Sub NoActiveRadio_Click(sender As Object, e As EventArgs) Handles NoActiveRadio.Click
        Flag.Enabled = False
        ListBox1.Items.Add("Не активен")
    End Sub
End Class
