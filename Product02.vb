﻿Public Class Product02

    ' Auto-implemented properties can be used if you dont need code in your Get or Set methods
    ' You can combine these with regular properteis
    Public Property ProductID As Integer
    Public Property Name As String
    Public Property ProductNumber As String
    Public Property Color As String
    Public Property ListPrice As Decimal
    Public Property StandardCost As Decimal
    Public Property Size As String
    Public Property Weight As Decimal
    Public Property SellStartDate As DateTime
    Public Property SellEndDate As DateTime

    Public ReadOnly Property NameAndNumber() As String
        ' This can be used when your property only needs to be read (Get) and not Set

        Get
            Return Name + "-" + ProductNumber
        End Get
    End Property

    Sub CalculateSellEndDate(ByVal days As Integer,
                             ByRef sellDate As DateTime)
        ' This does not return a value, only performs some kind of operation 
        SellEndDate = SellStartDate.AddDays(days)
        sellDate = SellEndDate
    End Sub


End Class
