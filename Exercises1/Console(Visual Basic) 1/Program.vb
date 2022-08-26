Imports System

Module Program
    Sub Main(args As String())
        Dim n1 As Integer
        Dim n2 As Integer
        n1 = CInt(Console.ReadLine())
        n2 = CInt(Console.ReadLine())
        Console.WriteLine("Num 1: " + CStr(n1))
        Console.WriteLine("Num 2: " + CStr(n2))
        Console.WriteLine(CStr(n1) + "+" + CStr(n2))
        Console.WriteLine(n1 + n2)
        Console.ReadLine()
    End Sub
End Module
