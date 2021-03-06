﻿Public Class FormJobs

    Private selectedIndex As Integer

    Private Sub btnAddJob_Click(sender As Object, e As EventArgs) Handles btnAddJob.Click
        FormObjectEditor.globalIndex = 4
        FormObjectEditor.formType = 0
        FormObjectEditor.Show()
    End Sub

    Private Sub btnEditJob_Click(sender As Object, e As EventArgs) Handles btnEditJob.Click
        FormObjectEditor.globalIndex = 4
        FormObjectEditor.formType = 1
        FormObjectEditor.Show()
    End Sub

    Private Sub btnSaveJob_Click(sender As Object, e As EventArgs) Handles btnSaveJob.Click
        Me.Close()
    End Sub

    Private Sub FormJobs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reloadData()
    End Sub

    Public Sub reloadData()
        Me.JobTableAdapter.Fill(Me.TeamProjectDataSet.Job)
    End Sub

    Private Sub btnDelJob_Click(sender As Object, e As EventArgs) Handles btnDelJob.Click
        Dim jobID As String = CType(dvJob.CurrentRow.Cells(0).Value, String)
        Console.WriteLine(jobID & " to be deleted.")

        Dim resp = MessageBox.Show("Are you sure you want to delete job'" & jobID & "'?", "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If resp = Windows.Forms.DialogResult.Yes Then
            Dim data As DataGridViewCellCollection = dvJob.Rows(selectedIndex).Cells
            Dim jm As New cJobManager
            jm.delete(data)
        End If

        reloadData()
    End Sub
End Class