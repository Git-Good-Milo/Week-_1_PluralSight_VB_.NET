Module MathModule

    Sub MainMath()
        Dim ListPriceM As Decimal = 900D

        ' Evaluated as ListPriceM + (1 * 2)
        Console.WriteLine(ListPriceM + 1 * 2)
        ' Evaluated as 1 + (ListPriceM * 2)
        Console.WriteLine(1 + ListPriceM * 2)
        Console.WriteLine((ListPriceM + 1) * 2)
        'Console.WriteLine(ClassConstants)
        Console.ReadKey()
    End Sub

End Module
