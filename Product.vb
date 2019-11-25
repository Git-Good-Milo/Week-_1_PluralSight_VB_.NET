Public Class Product

    ' This is a follow on from the ModuleOOPpractice02.vb
    ' This .vb will show me how to make my own class and add my own properties

    Private _IsActive As Boolean
    Public Property IsActive() As Boolean
        Get
            ' When you ask for the value from _IsActive it calls the get portion of Property
            ' eg. Console.WriteLine(prod.IsActive)

            Return _IsActive
        End Get
        Set(ByVal value As Boolean)
            ' When you set the property,
            ' You assign a value to it using the "="
            ' eg prod.IsActive = True

            _IsActive = value
        End Set
    End Property

End Class
