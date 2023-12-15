'Public Class Colas
'    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

'    End Sub
'End Class


Imports System.Collections.Generic
Imports System.Windows.Forms

Public Class Colas
    Private cola As Queue(Of Integer)
    Private prioridadQueue As Queue(Of Integer)
    Private circularQueue As Queue(Of Integer)

    Public Sub New()
        InitializeComponent()

        cola = New Queue(Of Integer)()
        prioridadQueue = New Queue(Of Integer)()
        circularQueue = New Queue(Of Integer)()
    End Sub

    Private Function DesplegarCola() As String
        ' Convierte la cola en una cadena para mostrarla
        Return String.Join(", ", cola.ToArray())
    End Function

    Private Function DesplegarPrioridadQueue() As String
        ' Convierte la PrioridadQueue en una cadena para mostrarla
        Return String.Join(", ", prioridadQueue.ToArray())
    End Function

    Private Function DesplegarCircularQueue() As String
        Return String.Join(",", circularQueue.ToArray())
    End Function

    Private Sub btnAgregarColas_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Integer.TryParse(txtValor.Text, 0) Then
            Dim valor As Integer = Integer.Parse(txtValor.Text)
            Select Case cmbEstructuras.Text
                Case "Cola"
                    cola.Enqueue(valor)
                Case "PrioridadQueue"
                    prioridadQueue.Enqueue(valor)
                Case "CircularQueue"
                    circularQueue.Enqueue(valor)
                Case Else
            End Select
            txtValor.Clear()
            MessageBox.Show("Elemento agregado exitosamente.")
        Else
            MessageBox.Show("Ingrese un valor numérico válido.")
        End If
    End Sub

    Private Sub btnMostrarColas_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Select Case cmbEstructuras.Text
            Case "Cola"
                txtMostrar.Text = "Cola:" & vbCrLf & DesplegarCola()
            Case "PrioridadQueue"
                txtMostrar.Text = "PrioridadQueue:" & vbCrLf & DesplegarPrioridadQueue()
            Case "CircularQueue"
                txtMostrar.Text = "CircularQueue:" & vbCrLf & DesplegarCircularQueue()
            Case Else
        End Select
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs)
        Dim listas As New Form1
        Hide()
        listas.Show()
    End Sub
End Class
