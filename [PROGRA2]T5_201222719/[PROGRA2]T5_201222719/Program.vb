Imports System

Module Program
    Sub Main(args As String())
        Dim i, j, n, indice, suma As Integer
        Console.Clear()
        Console.WriteLine("Ingrese un numero: ")
        n = Console.ReadLine()
        j = 1

        For i = 1 To n Step 1
            j = j * i
        Next
        Console.WriteLine("Factorial: " & j)
        While (indice <= j)
            indice = indice + 1
            If Not (indice Mod 4 = 0) Then

                Continue While

            End If
            Console.WriteLine(indice)
            suma = suma + 1
        End While

        Console.WriteLine("Multiplos de 4: ")
        Console.WriteLine("Hay " & suma & " multiplos de 4")
        Console.ReadKey()
    End Sub
End Module
