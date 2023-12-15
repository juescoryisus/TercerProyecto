'Public Class Form2
'    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

'    End Sub
'End Class

Imports System.Windows.Forms

Public Class Form2
    Private binaryTree As BinaryTree

    Public Sub New()
        InitializeComponent()
        binaryTree = New BinaryTree()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Integer.TryParse(txtValor.Text, 0) Then
            Dim valor As Integer = Integer.Parse(txtValor.Text)
            Select Case cmbEstructuras.Text
                Case "Árbol Binario"
                    txtMostrar.Text = "Árbol Binario (In-Order Traversal):" & vbCrLf & binaryTree.InOrderTraversal()
                Case Else
            End Select
            txtValor.Clear()
            MessageBox.Show("Elemento agregado exitosamente.")
        Else
            MessageBox.Show("Ingrese un valor numérico válido.")
        End If
    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Select Case cmbEstructuras.Text
            Case "Árbol Binario"
                txtMostrar.Text = "Árbol Binario (In-Order Traversal):" & vbCrLf & binaryTree.InOrderTraversal()
            Case Else
        End Select
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim listas As New Form1()
        Me.Hide()
        listas.Show()
    End Sub
End Class

Public Class BinaryTree
    Private Class TreeNode
        Public Property Data As Integer
        Public Property Left As TreeNode
        Public Property Right As TreeNode

        Public Sub New(data As Integer)
            Me.Data = data
            Me.Left = Nothing
            Me.Right = Nothing
        End Sub
    End Class

    Private root As TreeNode

    Public Sub New()
        root = Nothing
    End Sub

    Public Sub Insert(data As Integer)
        root = InsertRec(root, data)
    End Sub

    Private Function InsertRec(root As TreeNode, data As Integer) As TreeNode
        If root Is Nothing Then
            root = New TreeNode(data)
            Return root
        End If

        If data < root.Data Then
            root.Left = InsertRec(root.Left, data)
        ElseIf data > root.Data Then
            root.Right = InsertRec(root.Right, data)
        End If

        Return root
    End Function

    Public Function InOrderTraversal() As String
        Return InOrderTraversal(root)
    End Function

    Private Function InOrderTraversal(root As TreeNode) As String
        Dim result As String = ""
        If root IsNot Nothing Then
            result += InOrderTraversal(root.Left)
            result += root.Data & " "
            result += InOrderTraversal(root.Right)
        End If
        Return result
    End Function
End Class
