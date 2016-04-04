'Boundary Class
'Responsible for wrtitting/reading to/from an external text file from a listbox and vice-versa

'Need to import the following library for file manipulation
Imports System.IO

Public Class cFileManager

    Private strFileName As String

    Public Sub New()
        strFileName = String.Empty
    End Sub

    Public Property filename As String
        Get
            Return strFileName
        End Get
        Set(ByVal value As String)
            strFileName = value
        End Set
    End Property

    'this is an overloaded version of saveToFile with different signature
    'it takes a list-of-customers parameter as a collection 
    'it then saves all data from the collection onto a text file
    Public Sub saveToFile(ByVal objList As Collection)

        'create a stream writer object
        Dim objFile As StreamWriter

        Try
            If strFileName <> "" Then

                If File.Exists(strFileName) Then
                    Dim resp = MessageBox.Show("Overwrite existing data?", "Save to file", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If resp = DialogResult.Yes Then
                        My.Computer.FileSystem.DeleteFile(strFileName)
                    End If
                End If

                'NOTE: Need to create an external text file first before you can append on it
                'Open a given text file for appending data to it
                objFile = File.AppendText(strFileName)

                'Write all information from the collection to the file
                For Each obj As cTransaction In objList
                    objFile.WriteLine(obj.datetime & vbTab & obj.name & vbTab & obj.amount & vbTab & obj.type)
                Next

                'Close the file when finished
                objFile.Close()

                MessageBox.Show("Records were saved succesfully to " & vbTab & strFileName,
                                "User Feedback", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Message")
        End Try
    End Sub


    'this is an overloaded version of the readFromFile()
    'it retrieves all customer information from a selected text file and populates a given collection
    Public Sub readFromFile(ByRef objList As Collection)

        'create a stream reader object variable
        Dim objFile As StreamReader

        Try
            'Open the text file to read from it
            objFile = File.OpenText(strFileName)

                While objFile.Peek <> -1    'while end-of-file
                    'Read a line from the file and store it as an item to the given collection
                    Dim parseString As String = objFile.ReadLine()
                    Dim parsedString As String() = Split(parseString, vbTab, , CompareMethod.Text)
                    Dim trans As New cTransaction
                    trans.datetime = CDate(parsedString(0))
                    trans.name = parsedString(1)
                    trans.amount = CDec(parsedString(2))
                    trans.type = parsedString(3)

                    objList.Add(trans)
                End While

                'Close the file
                objFile.Close()

            MessageBox.Show("File was read succesfully from " & vbTab & strFileName,
                "User Feedback", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Message")
        End Try
    End Sub
End Class
