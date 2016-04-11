Public Class FormObjectEditor
    Public formType As Integer
    Public globalIndex As Integer

    Private Sub FormObjectEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TeamProjectDataSet.Job' table. You can move, or remove it, as needed.
        Me.JobTableAdapter.Fill(Me.TeamProjectDataSet.Job)
        'TODO: This line of code loads data into the 'TeamProjectDataSet.Customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me.TeamProjectDataSet.Customer)

        comboType.SelectedIndex = globalIndex
        reloadOptions()
    End Sub

    Private Sub comboObjType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboObjType.SelectedIndexChanged
        globalIndex = comboObjType.SelectedIndex
        reloadOptions()
    End Sub

    Private Sub reloadOptions()
        'Reload form based on which object is being edited
        Select Case globalIndex
            Case 0
                'Appointment
                txtName.Enabled = False
                txtAddress.Enabled = True
                txtAmount.Enabled = False
                txtEmail.Enabled = False
                txtHours.Enabled = False
                txtPhone.Enabled = False
                txtPayRate.Enabled = False
                comboCustomers.Enabled = True
                comboJobs.Enabled = False
                comboType.Enabled = False
                dtDate.Enabled = True
                comboObjType.Text = "Appointment"
            Case 1
                'Customer
                txtName.Enabled = True
                txtAddress.Enabled = True
                txtAmount.Enabled = False
                txtEmail.Enabled = True
                txtHours.Enabled = False
                txtPhone.Enabled = True
                txtPayRate.Enabled = False
                comboCustomers.Enabled = False
                comboJobs.Enabled = False
                comboType.Enabled = False
                dtDate.Enabled = False
                comboObjType.Text = "Customer"
            Case 2
                'Employee
                txtName.Enabled = True
                txtAddress.Enabled = True
                txtAmount.Enabled = False
                txtEmail.Enabled = False
                txtHours.Enabled = True
                txtPhone.Enabled = True
                txtPayRate.Enabled = True
                comboCustomers.Enabled = False
                comboJobs.Enabled = False
                comboType.Enabled = True
                dtDate.Enabled = False
                comboObjType.Text = "Employee"
            Case 3
                'Invoice
                txtName.Enabled = False
                txtAddress.Enabled = False
                txtAmount.Enabled = True
                txtEmail.Enabled = False
                txtHours.Enabled = False
                txtPhone.Enabled = False
                txtPayRate.Enabled = False
                comboCustomers.Enabled = True
                comboJobs.Enabled = True
                comboType.Enabled = False
                dtDate.Enabled = True
                comboObjType.Text = "Invoice"
            Case 4
                'Job
                txtName.Enabled = False
                txtAddress.Enabled = True
                txtAmount.Enabled = True
                txtEmail.Enabled = False
                txtHours.Enabled = False
                txtPhone.Enabled = False
                txtPayRate.Enabled = False
                comboCustomers.Enabled = False
                comboJobs.Enabled = False
                comboType.Enabled = False
                dtDate.Enabled = True
                comboObjType.Text = "Job"
        End Select
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Select Case globalIndex
            Case 0

            Case 1

            Case 2

            Case 3

            Case 4

        End Select
    End Sub
End Class