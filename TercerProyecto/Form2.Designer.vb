<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        txtMostrar = New TextBox()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        cmbEstructuras = New ComboBox()
        txtValor = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' txtMostrar
        ' 
        txtMostrar.Location = New Point(180, 185)
        txtMostrar.Multiline = True
        txtMostrar.Name = "txtMostrar"
        txtMostrar.Size = New Size(182, 190)
        txtMostrar.TabIndex = 16
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(19, 329)
        Button3.Name = "Button3"
        Button3.Size = New Size(141, 46)
        Button3.TabIndex = 15
        Button3.Text = "Regresar"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(16, 260)
        Button2.Name = "Button2"
        Button2.Size = New Size(141, 46)
        Button2.TabIndex = 14
        Button2.Text = "Mostrar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(15, 185)
        Button1.Name = "Button1"
        Button1.Size = New Size(141, 46)
        Button1.TabIndex = 13
        Button1.Text = "Agregar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' cmbEstructuras
        ' 
        cmbEstructuras.FormattingEnabled = True
        cmbEstructuras.Items.AddRange(New Object() {"SimpleList", "DoubleList", "CircularList", "CircularDoublyLinkedList"})
        cmbEstructuras.Location = New Point(180, 122)
        cmbEstructuras.Name = "cmbEstructuras"
        cmbEstructuras.Size = New Size(182, 33)
        cmbEstructuras.TabIndex = 12
        ' 
        ' txtValor
        ' 
        txtValor.Location = New Point(4, 124)
        txtValor.Name = "txtValor"
        txtValor.Size = New Size(153, 31)
        txtValor.TabIndex = 11
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Yellow
        Label3.Location = New Point(174, 75)
        Label3.Name = "Label3"
        Label3.Size = New Size(204, 25)
        Label3.TabIndex = 10
        Label3.Text = "Elije una de las opciones"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Yellow
        Label2.Location = New Point(19, 75)
        Label2.Name = "Label2"
        Label2.Size = New Size(118, 25)
        Label2.TabIndex = 9
        Label2.Text = "Ingresar dato"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(382, 450)
        Controls.Add(txtMostrar)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(cmbEstructuras)
        Controls.Add(txtValor)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtMostrar As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents cmbEstructuras As ComboBox
    Friend WithEvents txtValor As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
