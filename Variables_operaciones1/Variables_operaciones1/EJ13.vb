Module EJ13
    Sub Main()
        Dim num1, num2, num3, mayor As Integer

        Console.WriteLine("Ingrese un numero:")
        num1 = Console.ReadLine()
        Console.WriteLine("Ingrese otro numero:")
        num2 = Console.ReadLine()
        Console.WriteLine("Ingrese el ultimo num:")
        num3 = Console.ReadLine()

        mayor = Math.Max(num1, num2)
        mayor = Math.Max(mayor, num3)

        Console.WriteLine("El mayo numero ingresado es: " & mayor)

        Console.ReadKey()


    End Sub
End Module
