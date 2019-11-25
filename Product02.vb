Public Class Product02

    ' Auto-implemented properties can be used if you dont need code in your Get or Set methods
    ' You can combine these with regular properteis
    Public Property IsActive As Boolean
    Public Property Name As String
    Public Property ProducNumber As String
    Public Property ListPrice As Decimal

    Public ReadOnly Property NameAndNumber() As String
        ' This can be used when your property only needs to be read (Get) and not Set

        Get
            Return Name + "-" + ProducNumber
        End Get
    End Property

    Sub CalculateSellEndDate(ByVal days As Integer)
        ' This does not return a value, only performs some kind of operation 
    End Sub


End Class
