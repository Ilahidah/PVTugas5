Public Class TIO1
    Private Sub btn2Buttons_Click(sender As Object, e As EventArgs) Handles btn2Buttons.Click
        If MessageBox.Show("Your Internet connection will now be closed.", "Network Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
            lblResults.Text = "OK Clicked"
            'Call some method here
        Else
            lblResults.Text = "Cancel Clicked"
            'Call some method here
        End If
    End Sub


    Private Sub btn3Buttons_Click(sender As Object, e As EventArgs) Handles btn3Buttons.Click
        'Declare local variable
        Dim intResult As DialogResult
        'Get the results of the button clicked
        intResult = MessageBox.Show("Do you want to save changes to New Document?", "My Word Processor", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3)
        'Process the results of the button clicked
        Select Case intResult
            Case Windows.Forms.DialogResult.Yes
                lblResults.Text = "Yes Clicked"
'Do yes processing here
            Case Windows.Forms.DialogResult.No
                lblResults.Text = "No Clicked"
'Do no processing here
            Case Windows.Forms.DialogResult.Cancel
                lblResults.Text = "Cancel Clicked"
                'Do cancel processing here
        End Select
    End Sub

    Private Sub SubenumerationsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SubenumerationsToolStripMenuItem.Click
        TIO2.Show()
    End Sub

    Private Sub SubconstantsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SubconstantsToolStripMenuItem.Click
        TIO2.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        TIO2.Show()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        TIO2.Show()
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        TIO2.Show()
    End Sub

    Private Sub FolderBrowserDialogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FolderBrowserDialogToolStripMenuItem.Click
        TIO2.Show()
    End Sub
End Class