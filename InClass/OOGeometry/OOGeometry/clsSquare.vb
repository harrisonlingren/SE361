Public Class clsSquare

    Private dblSide As Double 'make attributes private

    'implement a constructor
    Public Sub New()
        dblSide = 0
    End Sub

    'establish a way to access my attributes
    Public Property side As Double
        Get
            Return dblSide
        End Get
        Set(value As Double)
            dblSide = value
        End Set
    End Property

    'implement necessary operations for square
    Public Function area() As Double
        Return dblSide * dblSide
    End Function

    Public Function perimeter() As Double
        Return 4 * dblSide
    End Function

End Class
