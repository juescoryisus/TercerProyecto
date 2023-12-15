Imports System.Windows.Forms
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form3
    Private directedGraph As DirectedGraph

    Public Sub New()
        InitializeComponent()
        directedGraph = New DirectedGraph()
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Integer.TryParse(TextBox1.Text, 0) Then
            Dim valor As Integer = Integer.Parse(TextBox1.Text)
            Dim newNode As New GraphNode(valor)
            directedGraph.AddNode(newNode)
            TextBox1.Clear()
            MessageBox.Show("Nodo agregado al grafo dirigido exitosamente.")
        Else
            MessageBox.Show("Ingrese un valor numérico válido.")
        End If
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Integer.TryParse(txtValor.Text, 0) AndAlso Integer.TryParse(txtValor.Text, 0) Then
            Dim desde As Integer = Integer.Parse(txtValor.Text)
            Dim hasta As Integer = Integer.Parse(txtValor.Text)
            Dim nodeDesde As New GraphNode(desde)
            Dim nodeHasta As New GraphNode(hasta)
            directedGraph.AddEdge(nodeDesde, nodeHasta)
            MessageBox.Show("Arista agregada al grafo dirigido exitosamente.")
        Else
            MessageBox.Show("Ingrese valores numéricos válidos para los nodos.")
        End If
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim listas As New Form1()
        Me.Hide()
        listas.Show()
    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' Lógica para el botón 4
    End Sub
End Class

Public Class GraphNode
    Public Property Value As Integer

    Public Sub New(value As Integer)
        Me.Value = value
    End Sub
End Class

' Clase para el grafo dirigido
Public Class DirectedGraph
    Private adjacencyList As Dictionary(Of GraphNode, List(Of GraphNode))

    Public Sub New()
        adjacencyList = New Dictionary(Of GraphNode, List(Of GraphNode))()
    End Sub

    Public Sub AddNode(node As GraphNode)
        If Not adjacencyList.ContainsKey(node) Then
            adjacencyList(node) = New List(Of GraphNode)()
        End If
    End Sub

    Public Sub AddEdge(from As GraphNode, [to] As GraphNode)
        AddNode(from)
        AddNode([to])

        adjacencyList(from).Add([to])
    End Sub
End Class

' Clase para el grafo no dirigido
Public Class UndirectedGraph
    Private adjacencyList As Dictionary(Of GraphNode, List(Of GraphNode))

    Public Sub New()
        adjacencyList = New Dictionary(Of GraphNode, List(Of GraphNode))()
    End Sub

    Public Sub AddNode(node As GraphNode)
        If Not adjacencyList.ContainsKey(node) Then
            adjacencyList(node) = New List(Of GraphNode)()
        End If
    End Sub

    Public Sub AddEdge(node1 As GraphNode, node2 As GraphNode)
        AddNode(node1)
        AddNode(node2)

        adjacencyList(node1).Add(node2)
        adjacencyList(node2).Add(node1)
    End Sub
End Class
