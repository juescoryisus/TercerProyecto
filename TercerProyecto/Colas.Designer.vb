<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Colas
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
        btnRegresar = New Button()
        Button2 = New Button()
        Button1 = New Button()
        cmbEstructuras = New ComboBox()
        txtValor = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' txtMostrar
        ' 
        txtMostrar.Location = New Point(233, 216)
        txtMostrar.Multiline = True
        txtMostrar.Name = "txtMostrar"
        txtMostrar.Size = New Size(182, 190)
        txtMostrar.TabIndex = 17
        ' 
        ' btnRegresar
        ' 
        btnRegresar.Location = New Point(72, 360)
        btnRegresar.Name = "btnRegresar"
        btnRegresar.Size = New Size(141, 46)
        btnRegresar.TabIndex = 16
        btnRegresar.Text = "Regresar"
        btnRegresar.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(69, 291)
        Button2.Name = "Button2"
        Button2.Size = New Size(141, 46)
        Button2.TabIndex = 15
        Button2.Text = "Mostrar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(68, 216)
        Button1.Name = "Button1"
        Button1.Size = New Size(141, 46)
        Button1.TabIndex = 14
        Button1.Text = "Agregar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' cmbEstructuras
        ' 
        cmbEstructuras.FormattingEnabled = True
        cmbEstructuras.Items.AddRange(New Object() {"SimpleList", "DoubleList", "CircularList", "CircularDoublyLinkedList"})
        cmbEstructuras.Location = New Point(233, 153)
        cmbEstructuras.Name = "cmbEstructuras"
        cmbEstructuras.Size = New Size(182, 33)
        cmbEstructuras.TabIndex = 13
        ' 
        ' txtValor
        ' 
        txtValor.Location = New Point(57, 155)
        txtValor.Name = "txtValor"
        txtValor.Size = New Size(153, 31)
        txtValor.TabIndex = 12
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Yellow
        Label3.Location = New Point(227, 106)
        Label3.Name = "Label3"
        Label3.Size = New Size(204, 25)
        Label3.TabIndex = 11
        Label3.Text = "Elije una de las opciones"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Yellow
        Label2.Location = New Point(72, 106)
        Label2.Name = "Label2"
        Label2.Size = New Size(118, 25)
        Label2.TabIndex = 10
        Label2.Text = "Ingresar dato"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Yellow
        Label1.Location = New Point(34, 44)
        Label1.Name = "Label1"
        Label1.Size = New Size(381, 25)
        Label1.TabIndex = 9
        Label1.Text = "Elije una de las listas antes de agregar un dato "
        ' 
        ' Colas
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(465, 450)
        Controls.Add(txtMostrar)
        Controls.Add(btnRegresar)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(cmbEstructuras)
        Controls.Add(txtValor)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Colas"
        Text = "Colas"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtMostrar As TextBox
    Friend WithEvents btnRegresar As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents cmbEstructuras As ComboBox
    Friend WithEvents txtValor As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
