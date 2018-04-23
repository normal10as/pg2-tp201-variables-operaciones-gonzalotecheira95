Module variable
    Public nombre As String
    Friend tipoDNI As String
    Friend dni As String
    Private localidad As String
    Private fecha_nacim As Date
    Private edad As Byte
    Private altura_corp As Single
    Private e_civil() As String = {"Soltero", "Casado", "Separado"}
    Private argentino As String

    Sub Main()
        Console.WriteLine("Nombre: ")
        nombre = Console.ReadLine()
        Console.WriteLine("tipoDNI: ")
        nombre = Console.ReadLine()
        Console.WriteLine("DNI: ")
        nombre = Console.ReadLine()
        Console.WriteLine("Localidad: ")
        nombre = Console.ReadLine()
        Console.WriteLine("Fecha de Nacimiento: ")
        nombre = Console.ReadLine()
        Console.WriteLine("Edad: ")
        nombre = Console.ReadLine()
        Console.WriteLine("Altura corporal: ")
        nombre = Console.ReadLine()
        Console.WriteLine("Estado Civil: ")
        nombre = Console.ReadLine()
        Console.WriteLine("Es argentino?: ")
        nombre = Console.ReadLine()

        Console.ReadKey()


    End Sub
End Module