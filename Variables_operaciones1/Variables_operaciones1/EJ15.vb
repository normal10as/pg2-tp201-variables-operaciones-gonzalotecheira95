Module EJ15
    Sub Main()

        Dim dia, hora As Byte



        Console.WriteLine("Ingrese un dia del 1 al 31")
        dia = Console.ReadLine()
        Console.WriteLine("Ingrese una hora de 00 a 24")
        hora = Console.ReadLine()

        Dim fecha As New DateTime(Now.Year, Now.Month, dia, hora, Now.Minute, Now.Second)
        fecha = Convert.ToString(fecha)

        Console.WriteLine(fecha)


        Console.ReadKey()
    End Sub
End Module
