Module EJ12

    Sub Main()
        Dim numero As Decimal
        Dim exce As Single
        Dim defe As Single
        Dim redon As Integer

        Console.WriteLine("Ingrese un Numero")
        numero = Console.ReadLine()

        exce = Math.Ceiling(numero)
        defe = Math.Floor(numero)
        redon = Math.Round(numero)

        Console.WriteLine("por Exceso:" & exce)
        Console.WriteLine("por Defecto:" & defe)
        Console.WriteLine("por Redondeo:" & redon)

        Console.ReadKey()


    End Sub
End Module
