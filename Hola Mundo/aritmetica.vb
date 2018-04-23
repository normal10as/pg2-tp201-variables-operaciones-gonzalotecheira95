Module aritmetica
    Dim ent1, ent2 As Integer
    Dim float1, float2 As Decimal


    Sub Main()

        Console.WriteLine("Ingrese Entero: ")
        ent1 = Console.ReadLine()
        Console.WriteLine("Ingrese Entero: ")
        ent2 = Console.ReadLine
        Console.WriteLine("Ingrese Flotante: ")
        float1 = Console.ReadLine
        Console.WriteLine("Ingrese Flotante: ")
        float2 = Console.ReadLine


        Console.WriteLine("Resultado de Entero y Entero" & " " & ent1 + ent2)
        Console.WriteLine("Resultado de Entero mas Flotante" & " " & ent1 + float1)
        Console.WriteLine("Resultado de Flotante mas Flotante" & " " & float1 + float2)
        Console.ReadKey()



    End Sub
End Module