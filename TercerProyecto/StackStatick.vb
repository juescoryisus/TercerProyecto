Imports EstructurasDatosFormulario
Imports System

Public Class StackStatic
    Private Const MaxSize As Integer = 10
    Private stackArray(MaxSize - 1) As Integer
    Private top As Integer

    Public Sub New()
        top = -1
    End Sub

    Public Sub Push(data As Integer)
        If top < MaxSize - 1 Then
            top += 1
            stackArray(top) = data
        Else
            Console.WriteLine("La pila está llena. No se puede agregar más elementos.")
        End If
    End Sub

    Public Function Pop() As Integer
        If top >= 0 Then
            Dim data As Integer = stackArray(top)
            top -= 1
            Return data
        Else
            Console.WriteLine("La pila está vacía. No se puede extraer más elementos.")
            Return -1
        End If
    End Function

    Public Function IsEmpty() As Boolean
        Return top = -1
    End Function
End Class

Public Class StackDynamic
    Private top As Node

    Public Sub New()
        top = Nothing
    End Sub

    Public Sub Push(data As Integer)
        Dim nuevoNodo As New Node(data)
        nuevoNodo.Next = top
        top = nuevoNodo
    End Sub

    Public Function Pop() As Integer
        If top IsNot Nothing Then
            Dim data As Integer = top.Data
            top = top.Next
            Return data
        Else
            Console.WriteLine("La pila está vacía. No se puede extraer más elementos.")
            Return -1
        End If
    End Function

    Public Function IsEmpty() As Boolean
        Return top Is Nothing
    End Function
End Class
