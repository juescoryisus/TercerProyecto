Imports System.Text

Public Class StackForm
    Private stackStatic As StackStatic
    Private stackDynamic As StackDynamic

    Public Sub New()
        InitializeComponent()
        stackStatic = New StackStatic()
        stackDynamic = New StackDynamic()
    End Sub

    Private Sub btnMostrarStack_Click(sender As Object, e As EventArgs) Handles btnMostrarStack.Click
        Dim listaPila As String = ObtenerListaPilaSeleccionada()
        MessageBox.Show(listaPila, "Elementos en la Pila", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Function ObtenerListaPilaSeleccionada() As String
        Select Case cmbEstructuraStack.Text
            Case "Stack Estatico"
                Return ObtenerListaPila(stackStatic)
            Case "Stack Dinamico"
                Return ObtenerListaPila(stackDynamic)
            Case Else
                Return "Seleccione una estructura de pila."
        End Select
    End Function

    Private Function ObtenerListaPila(pila As StackStatic) As String
        Dim result As New StringBuilder()
        While Not pila.IsEmpty()
            Dim valor As Integer = pila.Pop()
            result.Insert(0, valor.ToString() & vbCrLf)
        End While
        Return result.ToString()
    End Function

    Private Function ObtenerListaPila(pila As StackDynamic) As String
        Dim result As New StringBuilder()
        While Not pila.IsEmpty()
            Dim valor As Integer = pila.Pop()
            result.Insert(0, valor.ToString() & vbCrLf)
        End While
        Return result.ToString()
    End Function
End Class