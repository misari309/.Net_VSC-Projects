Imports System

Module Program
    Sub Main(args As String())
        Dim sVivo As String
        sVivo = Console.ReadLine
        If sVivo = "Perro" Or sVivo = "Gato" Or sVivo = "Serpiente" Or sVivo = "Zorro" Or sVivo = "Tigre" Then
            Console.WriteLine("Animal")
        End If
        If sVivo = "Arbol" Or sVivo = "Coliflor" Or sVivo = "Orquidea" Or sVivo = "Girasol" Or sVivo = "Manzana" Then
            Console.WriteLine("Vegetal")
        End If
        Console.ReadLine()
    End Sub
End Module
