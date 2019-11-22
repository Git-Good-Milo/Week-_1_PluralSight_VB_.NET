Module ModuleOOPpractice02
    Sub MainStringOOP()
        Dim Name As String = "10 Speed Bike"

        Console.WriteLine("Built In String Methods")
        Console.WriteLine(Name.Length)
        Console.WriteLine(Name.IndexOf("B"))
        Console.WriteLine(Name.ToUpper)
        Console.WriteLine(Name.StartsWith("f"))
    End Sub

    Sub MainIntegerOOP()
        Dim ListPrince As Decimal = 999.99D
        Dim round_value As Decimal

        Console.WriteLine("Buil-In Numeric Methods")
        Console.WriteLine(Decimal.MinValue)

        round_value = Decimal.Round(ListPrince)
        Console.WriteLine(round_value)

        Decimal.TryParse("450", ListPrince)
        Console.WriteLine(ListPrince)

        Console.WriteLine("Boo Yeah!!!")

    End Sub

    Sub MainDateOOP()
        Dim SellDate As DateTime
        SellDate = #1/1/2019 12:05:01 PM#

        Console.WriteLine("Built-In DatTime Methods")
        Console.WriteLine(SellDate.AddDays(10))
        Console.WriteLine(SellDate.AddDays(-10))

        Console.WriteLine(SellDate.Date)
        Console.WriteLine(SellDate.Day)
        Console.WriteLine(SellDate.DayOfWeek)
        Console.WriteLine(SellDate.Hour)
        Console.WriteLine(SellDate.Minute)
        Console.WriteLine(SellDate.Second)

    End Sub

End Module
