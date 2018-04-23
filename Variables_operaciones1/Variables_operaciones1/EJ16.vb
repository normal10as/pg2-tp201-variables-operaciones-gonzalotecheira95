Module EJ16
    Sub Main()
        Dim dia, hora, anio As Byte
        Dim fecha2 As Date
        Dim sum As Integer

        Console.WriteLine("Ingrese un dia del 1 al 31")
        dia = Console.ReadLine()
        Console.WriteLine("Ingrese una hora de 00 a 24")
        hora = Console.ReadLine()
        Console.WriteLine("Ingrese un año")
        anio = Console.ReadLine()

        Dim fecha As New DateTime(anio, Now.Month, dia, hora, Now.Minute, Now.Second)
        fecha = Convert.ToString(fecha)

        Console.WriteLine("Fecha Ingresada: " & fecha)

        Console.WriteLine("Ingrese los dias para sumar: ")
        sum = Console.ReadLine()

        fecha2 = fecha.AddDays(sum)

        Console.WriteLine(fecha2)

        Console.ReadKey()
    End Sub
End Module
