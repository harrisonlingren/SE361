Imports System
Imports System.IO
Imports System.Text
Imports System.Security.AccessControl

Public Class FormCustomers

    Private selectedIndex As Integer

    Private Sub btnAddCust_Click(sender As Object, e As EventArgs) Handles btnAddCust.Click
        FormEditCustomer.Show()
    End Sub

    Private Sub listViewCust_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listViewCust.SelectedIndexChanged
        btnEditCust.Enabled = True

        Try
            selectedIndex = listViewCust.SelectedItems(0).Index
        Catch ex As Exception
            selectedIndex = 0
        End Try

    End Sub

    Private Sub btnEditCust_Click(sender As Object, e As EventArgs) Handles btnEditCust.Click
        FormEditCustomer.loadCustomer(selectedIndex)
    End Sub

    Private Sub listViewCust_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles listViewCust.MouseDoubleClick
        FormEditCustomer.loadCustomer(selectedIndex)
    End Sub

    Private Sub btnSaveCust_Click(sender As Object, e As EventArgs) Handles btnSaveCust.Click
        Me.Close()
    End Sub

    Private Sub saveCustomers()

        Dim path As String
        Dim path2 As String
        path2 = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase)
        path = path2 & "\data"
        path = path.Remove(0, 6)

        If Not System.IO.Directory.Exists(path) Then
            System.IO.Directory.CreateDirectory(path)
        End If

        If System.IO.File.Exists(path & "\customers.txt") = True Then
            Dim result As DialogResult
            result = MessageBox.Show("Overwrite existing data?", "Save", MessageBoxButtons.YesNo)
            If result = Windows.Forms.DialogResult.Yes Then
                System.IO.File.Delete(path & "\customers.txt")
            Else
                Exit Sub
            End If
        End If

        Using fileout As StreamWriter = File.CreateText(path & "\customers.txt")
            For Each item As ListViewItem In listViewCust.Items
                If Not item.Text = "" Then
                    fileout.WriteLine(item.Text)
                    fileout.WriteLine(item.SubItems(1).Text)
                    fileout.WriteLine(item.SubItems(2).Text)
                    fileout.WriteLine(item.SubItems(3).Text)
                    fileout.WriteLine(item.SubItems(4).Text)
                End If
            Next
        End Using

    End Sub

    Private Sub FormCustomers_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim result As DialogResult
        result = MessageBox.Show("Do you want to save your changes?", "Save?", MessageBoxButtons.YesNo)
        If result = Windows.Forms.DialogResult.Yes Then
            saveCustomers()
        End If
    End Sub

    Private Sub FormCustomers_Load(sender As Object, e As EventArgs) Handles Me.Load
        loadCustomers()
    End Sub

    Private Sub loadCustomers()

        Dim path As String
        Dim path2 As String
        Dim path3 As String
        path2 = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase)
        path = path2 & "\data"
        path = path.Remove(0, 6)
        path3 = path & "\customers.txt"

        If System.IO.File.Exists(path3) = True Then
            Using filein As StreamReader = File.OpenText(path3)
                Dim lineCount As Integer = File.ReadAllLines(path3).Length

                For i As Integer = 0 To lineCount Step 1

                    listViewCust.Items.Add(filein.ReadLine())
                    listViewCust.Items(listViewCust.Items.Count - 1).SubItems.Add(filein.ReadLine())
                    listViewCust.Items(listViewCust.Items.Count - 1).SubItems.Add(filein.ReadLine())
                    listViewCust.Items(listViewCust.Items.Count - 1).SubItems.Add(filein.ReadLine())
                    listViewCust.Items(listViewCust.Items.Count - 1).SubItems.Add(filein.ReadLine())
                Next
            End Using
        End If

    End Sub
End Class