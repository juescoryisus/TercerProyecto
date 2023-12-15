<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Stack
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
        btnAgregarStack = New Button()
        btnPopStack = New Button()
        btnMostrarStack = New Button()
        Button4 = New Button()
        cmbEstructura = New ComboBox()
        Label1 = New Label()
        ListBox1 = New ListBox()
        TextBox1 = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' btnAgregarStack
        ' 
        btnAgregarStack.Location = New Point(31, 155)
        btnAgregarStack.Name = "btnAgregarStack"
        btnAgregarStack.Size = New Size(112, 34)
        btnAgregarStack.TabIndex = 0
        btnAgregarStack.Text = "Agregar"
        btnAgregarStack.UseVisualStyleBackColor = True
        ' 
        ' btnPopStack
        ' 
        btnPopStack.Location = New Point(31, 195)
        btnPopStack.Name = "btnPopStack"
        btnPopStack.Size = New Size(112, 34)
        btnPopStack.TabIndex = 1
        btnPopStack.Text = "Mostrar"
        btnPopStack.UseVisualStyleBackColor = True
        ' 
        ' btnMostrarStack
        ' 
        btnMostrarStack.Location = New Point(12, 235)
        btnMostrarStack.Name = "btnMostrarStack"
        btnMostrarStack.Size = New Size(131, 34)
        btnMostrarStack.TabIndex = 2
        btnMostrarStack.Text = "MostrarStack"
        btnMostrarStack.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(31, 275)
        Button4.Name = "Button4"
        Button4.Size = New Size(112, 34)
        Button4.TabIndex = 3
        Button4.Text = "Regresar"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' cmbEstructura
        ' 
        cmbEstructura.FormattingEnabled = True
        cmbEstructura.Items.AddRange(New Object() {"Stack Estatico", "Stack Dinamico"})
        cmbEstructura.Location = New Point(232, 97)
        cmbEstructura.Name = "cmbEstructura"
        cmbEstructura.Size = New Size(203, 33)
        cmbEstructura.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Yellow
        Label1.Location = New Point(-1, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(472, 25)
        Label1.TabIndex = 5
        Label1.Text = "Elegir primero una de las ""colas"" antes de agregar un dato"
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 25
        ListBox1.Location = New Point(211, 156)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(238, 154)
        ListBox1.TabIndex = 6
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(31, 97)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(142, 31)
        TextBox1.TabIndex = 7
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Yellow
        Label2.Location = New Point(43, 69)
        Label2.Name = "Label2"
        Label2.Size = New Size(117, 25)
        Label2.TabIndex = 8
        Label2.Text = "ingresar dato"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Yellow
        Label3.Location = New Point(249, 69)
        Label3.Name = "Label3"
        Label3.Size = New Size(175, 25)
        Label3.TabIndex = 9
        Label3.Text = "Elije una de las Colas"
        ' 
        ' Stack
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(483, 450)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(TextBox1)
        Controls.Add(ListBox1)
        Controls.Add(Label1)
        Controls.Add(cmbEstructura)
        Controls.Add(Button4)
        Controls.Add(btnMostrarStack)
        Controls.Add(btnPopStack)
        Controls.Add(btnAgregarStack)
        Name = "Stack"
        Text = "Stack"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnAgregarStack As Button
    Friend WithEvents btnPopStack As Button
    Friend WithEvents btnMostrarStack As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents cmbEstructura As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
