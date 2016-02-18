Public Class clsRectangle

    Private dblSide1 As Double 'make attributes private
    Private dblSide2 As Double

    'implement a constructor
    Public Sub New()
        dblSide1 = 0
        dblSide2 = 0
    End Sub

    'establish a way to access my attributes
    Public Property side1 As Double
        Get
            Return dblSide1
        End Get
        Set(value As Double)
            dblSide1 = value
        End Set
    End Property
    Public Property side2 As Double
        Get
            Return dblSide2
        End Get
        Set(value As Double)
            dblSide2 = value
        End Set
    End Property

    'implement necessary operations for rectangle
    Public Function Area() As Double
        Return dblSide1 * dblSide2
    End Function

    Public Function Perimeter() As Double
        Return 2 * (dblSide1 + dblSide2)
    End Function

End Class
