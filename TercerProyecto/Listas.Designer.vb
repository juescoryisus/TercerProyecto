<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Listas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtValor = New TextBox()
        cmbEstructuras = New ComboBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        txtMostrar = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Yellow
        Label1.Location = New Point(21, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(381, 25)
        Label1.TabIndex = 0
        Label1.Text = "Elije una de las listas antes de agregar un dato "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Yellow
        Label2.Location = New Point(59, 82)
        Label2.Name = "Label2"
        Label2.Size = New Size(118, 25)
        Label2.TabIndex = 1
        Label2.Text = "Ingresar dato"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Yellow
        Label3.Location = New Point(214, 82)
        Label3.Name = "Label3"
        Label3.Size = New Size(204, 25)
        Label3.TabIndex = 2
        Label3.Text = "Elije una de las opciones"
        ' 
        ' txtValor
        ' 
        txtValor.Location = New Point(44, 131)
        txtValor.Name = "txtValor"
        txtValor.Size = New Size(153, 31)
        txtValor.TabIndex = 3
        ' 
        ' cmbEstructuras
        ' 
        cmbEstructuras.FormattingEnabled = True
        cmbEstructuras.Items.AddRange(New Object() {"SimpleList", "DoubleList", "CircularList", "CircularDoublyLinkedList"})
        cmbEstructuras.Location = New Point(220, 129)
        cmbEstructuras.Name = "cmbEstructuras"
        cmbEstructuras.Size = New Size(182, 33)
        cmbEstructuras.TabIndex = 4
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(55, 192)
        Button1.Name = "Button1"
        Button1.Size = New Size(141, 46)
        Button1.TabIndex = 5
        Button1.Text = "Agregar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(56, 267)
        Button2.Name = "Button2"
        Button2.Size = New Size(141, 46)
        Button2.TabIndex = 6
        Button2.Text = "Mostrar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(59, 336)
        Button3.Name = "Button3"
        Button3.Size = New Size(141, 46)
        Button3.TabIndex = 7
        Button3.Text = "Regresar"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' txtMostrar
        ' 
        txtMostrar.Location = New Point(220, 192)
        txtMostrar.Multiline = True
        txtMostrar.Name = "txtMostrar"
        txtMostrar.Size = New Size(182, 190)
        txtMostrar.TabIndex = 8
        ' 
        ' Listas
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(430, 450)
        Controls.Add(txtMostrar)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(cmbEstructuras)
        Controls.Add(txtValor)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Listas"
        Text = "Listas"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtValor As TextBox
    Friend WithEvents cmbEstructuras As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents txtMostrar As TextBox
End Class
