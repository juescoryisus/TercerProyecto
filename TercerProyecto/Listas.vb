
Public Class Listas
    Private simpleList As SimpleList
    Private doubleList As DoubleList
    Private circularList As CircularList
    Private circularDoublyLinkedList As CircularDoublyLinkedList

    Public Sub New()
        InitializeComponent()
        simpleList = New SimpleList()
        doubleList = New DoubleList()
        circularList = New CircularList()
        circularDoublyLinkedList = New CircularDoublyLinkedList()
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs)
        Dim listas As New Form1
        Hide()
        listas.Show()
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Integer.TryParse(txtValor.Text, 0) Then
            Dim valor As Integer = Integer.Parse(txtValor.Text)

            Select Case cmbEstructuras.Text
                Case "Lista Simple"
                    simpleList.AgregarElemento(valor)
                Case "Lista Doble"
                    doubleList.InsertarNodo(valor)
                Case "Lista Circular"
                    circularList.InsertarNodo(valor)
                Case "Lista Doble Circular"
                    circularDoublyLinkedList.InsertarNodo(valor)
                Case Else
            End Select

            txtValor.Clear()
            MessageBox.Show("Elemento agregado exitosamente.")
        Else
            MessageBox.Show("Ingrese un valor numérico válido.")
        End If
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Select Case cmbEstructuras.Text
            Case "Lista Simple"
                txtMostrar.Text = "Lista Simple:" & vbCrLf & simpleList.MostrarLista()
            Case "Lista Doble"
                txtMostrar.Text = "Lista Doble:" & vbCrLf & doubleList.DesplegarLista()
            Case "Lista Circular"
                txtMostrar.Text = "Lista Circular:" & vbCrLf & circularList.DesplegarLista()
            Case "Lista Doble Circular"
                txtMostrar.Text = "Lista Doble Circular:" & vbCrLf & circularDoublyLinkedList.DesplegarLista()
            Case Else

        End Select
    End Sub

    Private Sub button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Dim listas As New Form1()
        Me.Hide()
        listas.Show()
    End Sub
End Class
