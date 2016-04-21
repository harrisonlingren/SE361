Public Class cPrintData
    Inherits System.Drawing.Printing.PrintDocument

    Private pdata As DataGridViewCellCollection
    Private titleFont, detailFont As Font

    Property data As DataGridViewCellCollection
        Get
            Return pdata
        End Get
        Set(value As DataGridViewCellCollection)
            pdata = CType(value, DataGridViewCellCollection)
        End Set
    End Property

    Private Sub cPrintData_BeginPrint(sender As Object, e As Printing.PrintEventArgs) Handles Me.BeginPrint
        ' Create font objects to print with
        titleFont = New Font(FontFamily.GenericSerif, 16, FontStyle.Bold, GraphicsUnit.Point)
        detailFont = New Font(FontFamily.GenericSansSerif, 9, FontStyle.Regular, GraphicsUnit.Point)
    End Sub

    Private Sub cPrintData_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles Me.PrintPage
        Dim yPos As Single = 100
        'Title -- ID: $id and Date:  $date
        e.Graphics.DrawString("Invoice ID:  " & pdata(0).Value & "                    Date:  " & pdata(1).Value, titleFont, Brushes.Black, 20, 20)
        yPos += e.Graphics.MeasureString("Invoice ID:  " & pdata(0).Value & "                    Date:  " & pdata(1).Value, titleFont).Height

        'Amount -- Amount owed:  $amt
        e.Graphics.DrawString("Amount owed:  $" & FormatNumber(CDec(pdata(2).Value), 2), detailFont, Brushes.Black, 20, yPos)
        yPos += e.Graphics.MeasureString("Amount owed:  $" & FormatNumber(CDec(pdata(2).Value), 2), detailFont).Height

        'Date Due -- Date Due:  $ddate
        e.Graphics.DrawString("Due Date:  " & pdata(3).Value, detailFont, Brushes.Black, 20, yPos)
        yPos += e.Graphics.MeasureString("Due Date:  " & pdata(3).Value, detailFont).Height
    End Sub

End Class
