Module semanas
    Private dias_anio As Integer
    Private dias_labor As Integer
    Private dias_sem As Integer

    Sub Main()
        dias_anio = 365
        dias_labor = 5
        dias_sem = 7

        Console.WriteLine(dias_labor * dias_anio)
        Console.WriteLine(dias_sem * dias_anio)


        Console.WriteLine("Semanas del Anio:" & " " & dias_anio / dias_sem)
        Console.WriteLine("Semanas laborables del Anio:" & " " & (dias_anio / dias_labor) / 5)

        Console.ReadKey()


    End Sub
End Module
