Public Class MainForm
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        lblArea.Text = String.Empty
        lblPerimeter.Text = String.Empty
        txtSide1.Clear()
        txtSide2.Clear()
        rbtRectangle.Checked = False
        rbtSquare.Checked = False
    End Sub
    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        Dim side1, side2, radius, area, perimeter As Double
        Try
            If Double.TryParse(txtSide1.Text, side1) And side1 > 0 Then
                If Double.TryParse(txtSide2.Text, side2) And side2 > 0 Then
                    If Double.TryParse(txtRadius.Text, radius) And radius > 0 Then
                        radius = CDbl(txtRadius.Text)
                        If rbtSquare.Checked = True Then
                            area = side1 * side1
                            perimeter = 4 * side1
                        ElseIf rbtRectangle.Checked = True Then
                            area = side1 * side2
                            perimeter = (2 * side1) + (2 * side2)
                        ElseIf rbtCircle.Checked = True Then
                            area = radius * radius * Math.PI
                            perimeter = 2 * Math.PI * radius
                        End If
                        lblArea.Text = area.ToString("F2")
                        lblPerimeter.Text = perimeter.ToString("F2")
                    Else
                        MessageBox.Show("Only positive numeric data for Radius", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                Else
                    MessageBox.Show("Only positive numeric data for Side2", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Else
                MessageBox.Show("Only positive numeric data for Side1", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub rbtCircle_CheckedChanged(sender As Object, e As EventArgs) Handles rbtCircle.CheckedChanged
        txtRadius.Enabled = True
        txtSide1.Enabled = False
        txtSide2.Enabled = False
    End Sub

    Private Sub rbtRectangle_CheckedChanged(sender As Object, e As EventArgs) Handles rbtRectangle.CheckedChanged
        txtRadius.Enabled = False
        txtSide1.Enabled = True
        txtSide2.Enabled = True
    End Sub

    Private Sub rbtSquare_CheckedChanged(sender As Object, e As EventArgs) Handles rbtSquare.CheckedChanged
        txtRadius.Enabled = False
        txtSide1.Enabled = True
        txtSide2.Enabled = False
    End Sub
End Class