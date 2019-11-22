Module MainModule
    Dim ProductID As Integer = 1
    Dim isActive As Boolean = True
    Dim Name As String = "10 Speed Bike"
    Dim ListPrice As Decimal = 999.99
    Dim SellStartDate As DateTime = #1/1/2019#

    Sub Main()
        Console.WriteLine(Name)
        ModuleOOPpractice02.MainStringOOP()
        ModuleOOPpractice02.MainIntegerOOP()
        ModuleOOPpractice02.MainDateOOP()

        'Main1()
        'Main2()
        'MathModule.MainMath()
        'MathModule.MainMath()
        Console.ReadKey()
    End Sub

    Sub Main1()
        Console.WriteLine($"{Name}, {ListPrice}")

        Console.ReadKey()
    End Sub

    Sub Main2()
        Dim isActive2 As Boolean = ClassConstants.DEFAULT_ACTIVE
        Dim ListPrice2 = ClassConstants.DEFAULT_LIST_PRICE

        Console.WriteLine($"{isActive2} , {ListPrice2}")
    End Sub

End Module
