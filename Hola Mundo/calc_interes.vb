Module calc_interes
    Sub Main()
        Dim m As Single
        Dim r As Single
        Dim t As UInteger
        Const denominador As UInteger = 360 * 100
        Dim i As Single

        Console.WriteLine("Ingrese el monto invertido: ")
        m = Console.ReadLine()
        Console.WriteLine("Ingrese el porcentaje de interes anual: ")
        r = Console.ReadLine()
        Console.WriteLine("Ingrese el numero de dias: ")
        t = Console.ReadLine()
        i = (m * r * t) / denominador

        Console.WriteLine("Los intereses producidos son de " & i)
        Console.WriteLine("El capital acumulado es de  " & m + i)

        Console.ReadKey()

    End Sub
End Module
