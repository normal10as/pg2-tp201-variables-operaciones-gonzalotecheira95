Module concatenacion

    Sub Main()
        Dim nom_empresa As String
        Dim nom_calle As String
        Dim alt_calle As Integer
        Dim fecha_inicio As Date
        Dim consoless As String

        Console.WriteLine("Ingrese nombre de la empresa: ")
        nom_empresa = Console.ReadLine()
        Console.WriteLine("Ingrese nombre de la calle: ")
        nom_calle = Console.ReadLine()
        Console.WriteLine("Ingrese altura de la calle: ")
        alt_calle = Console.ReadLine()
        Console.WriteLine("Ingrese fecha de inicio: ")
        fecha_inicio = Console.ReadLine()

        'Explicita
        consoless = Convert.ToString(nom_empresa & vbLf & nom_calle & vbLf & alt_calle & vbLf & fecha_inicio)

        Console.WriteLine(consoless)

        'Implicita
        Console.WriteLine(nom_empresa & vbLf & nom_calle & vbLf & alt_calle & vbLf & fecha_inicio)

        Console.ReadKey()

    End Sub

End Module
