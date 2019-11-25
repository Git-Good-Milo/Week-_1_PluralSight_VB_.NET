Module MainModule
    'Dim ProductID As Integer = 1
    'Dim isActive As Boolean = True
    'Dim Name As String = "10 Speed Bike"
    'Dim ListPrice As Decimal = 999.99
    'Dim SellStartDate As DateTime = #1/1/2019#

    Sub Main()

        Dim prod As New Product02
        Dim sellDate As DateTime


        prod.SellStartDate = #1/1/2019#
        ' Pass sellDate by Reference 
        prod.CalculateSellEndDate(30, sellDate)
        Console.WriteLine(sellDate)

        'Console.WriteLine(Name)
        'ModuleOOPpractice02.MainStringOOP()
        'ModuleOOPpractice02.MainIntegerOOP()
        'ModuleOOPpractice02.MainDateOOP()
        'Main1()
        'Main2()
        'MathModule.MainMath()
        'MathModule.MainMath()
        Console.ReadKey()
    End Sub



End Module
