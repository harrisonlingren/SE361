'Author:        Harrison Lingren
'Date:          2016-02-23
'Project:       OOGeometry
'Description:   A simple Geometry application that demonstrates
'               object-oriented development using separate classes
'               in a 3-tier architecture using entity, boundary and
'               controller classes

Public Class MainForm
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtSide1.Clear()
        txtSide2.Clear()
        txtRadius.Clear()
        lblArea.Text = String.Empty
        lblPerimeter.Text = String.Empty
        rbtCircle.Checked = False
        rbtRectangle.Checked = False
        rbtSquare.Checked = False
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Create instances of square and rectangle
        Dim objSquare As New clsSquare
        Dim objRectangle As New clsRectangle

        Try
            'Decide which shape is selected
            If rbtSquare.Checked = True Then
                objSquare.side = CDbl(txtSide1.Text)
                lblArea.Text = CStr(objSquare.area)
                lblPerimeter.Text = CStr(objSquare.perimeter)
            ElseIf rbtRectangle.Checked = True Then
                objRectangle.side1 = CDbl(txtSide1.Text)
                objRectangle.side2 = CDbl(txtSide2.Text)
                lblArea.Text = CStr(objRectangle.Area)
                lblPerimeter.Text = CStr(objRectangle.Perimeter)
            Else
                MessageBox.Show("Please select a shape")
            End If
        Catch ex As Exception

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
