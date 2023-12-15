Imports System.Text

Public Class Node
    Public Property Data As Integer
    Public Property NextNode As Node
    Public Property PreviousNode As Node

    Public Sub New(data As Integer)
        Me.Data = data
        Me.NextNode = Nothing
        Me.PreviousNode = Nothing
    End Sub
End Class

Public Class SimpleList
    Private head As Node

    Public Sub New()
        head = Nothing
    End Sub

    Public Sub AgregarElemento(data As Integer)
        Dim nuevoNodo As New Node(data)
        If head Is Nothing Then
            head = nuevoNodo
        Else
            Dim temp As Node = head
            While temp.NextNode IsNot Nothing
                temp = temp.NextNode
            End While
            temp.NextNode = nuevoNodo
        End If
    End Sub

    Public Function MostrarLista() As String
        Dim result As New StringBuilder()
        Dim temp As Node = head
        While temp IsNot Nothing
            result.Append(temp.Data).Append(" ")
            temp = temp.NextNode
        End While
        Return result.ToString()
    End Function
End Class

Public Class DoubleList
    Private head As Node
    Private tail As Node

    Public Sub New()
        head = Nothing
        tail = Nothing
    End Sub

    Public Sub InsertarNodo(data As Integer)
        Dim nuevoNodo As New Node(data)
        If head Is Nothing Then
            head = nuevoNodo
            tail = nuevoNodo
        Else
            tail.NextNode = nuevoNodo
            nuevoNodo.PreviousNode = tail
            tail = nuevoNodo
        End If
    End Sub

    Public Function DesplegarLista() As String
        Dim result As New StringBuilder()
        Dim temp As Node = head
        While temp IsNot Nothing
            result.Append(temp.Data).Append(" ")
            temp = temp.NextNode
        End While
        Return result.ToString()
    End Function
End Class

Public Class CircularList
    Private head As Node

    Public Sub New()
        head = Nothing
    End Sub

    Public Sub InsertarNodo(data As Integer)
        Dim nuevoNodo As New Node(data)
        If head Is Nothing Then
            head = nuevoNodo
            head.NextNode = head
        Else
            Dim temp As Node = head
            While temp.NextNode IsNot head
                temp = temp.NextNode
            End While
            temp.NextNode = nuevoNodo
            nuevoNodo.NextNode = head
        End If
    End Sub

    Public Function DesplegarLista() As String
        If head Is Nothing Then
            Return String.Empty
        End If

        Dim result As New StringBuilder()
        Dim temp As Node = head
        Do
            result.Append(temp.Data).Append(" ")
            temp = temp.NextNode
        Loop While temp IsNot head

        Return result.ToString()
    End Function
End Class

Public Class CircularDoublyLinkedList
    Private head As Node

    Public Sub New()
        head = Nothing
    End Sub

    Public Sub InsertarNodo(data As Integer)
        Dim nuevoNodo As New Node(data)
        If head Is Nothing Then
            head = nuevoNodo
            head.NextNode = head
            head.PreviousNode = head
        Else
            Dim tail As Node = head.PreviousNode
            tail.NextNode = nuevoNodo
            nuevoNodo.PreviousNode = tail
            nuevoNodo.NextNode = head
            head.PreviousNode = nuevoNodo
        End If
    End Sub

    Public Function DesplegarLista() As String
        If head Is Nothing Then
            Return String.Empty
        End If

        Dim result As New StringBuilder()
        Dim temp As Node = head
        Do
            result.Append(temp.Data).Append(" ")
            temp = temp.NextNode
        Loop While temp IsNot head

        Return result.ToString()
    End Function
End Class