Module sum4num
    Sub Main()
        Dim A, B, C, D, R As Integer
        Console.WriteLine("INGRESE NUMERO A")
        A = Console.ReadLine()
        Console.WriteLine("INGRESE NUMERO B")
        B = Console.ReadLine()
        Console.WriteLine("INGRESE NUMERO C")
        C = Console.ReadLine()
        Console.WriteLine("INGRESE NUMERO D")
        D = Console.ReadLine()

        R = A + B + C + D

        Console.WriteLine(R & " Es el resultado de los cuatro numeros ingresados.")
        Console.WriteLine(R / 4 & " Es la media de los cuatro numeros ingresados.")

        Console.ReadKey()

    End Sub
End Module
