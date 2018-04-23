Module valor_absolut
    Sub Main()
        Dim valor As Integer
        Dim raiz As Integer

        Console.WriteLine("Ingrese un numero: ")
        valor = Console.ReadLine()

        If valor < 0 Then
            valor = valor - valor * 2
        End If

        raiz = valor ^ (1 / 2)

        Console.WriteLine("El valor absoluto" & valor)

        Console.WriteLine("Su decima potencia es" & valor ^ 10)

        Console.WriteLine("La raiz de ese numero es " & raiz)



        Console.ReadKey()

    End Sub
End Module
