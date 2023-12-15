<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        txtValor = New TextBox()
        Label3 = New Label()
        Button4 = New Button()
        TextBox1 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(0, 276)
        Button3.Name = "Button3"
        Button3.Size = New Size(141, 46)
        Button3.TabIndex = 15
        Button3.Text = "Regresar"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(0, 136)
        Button2.Name = "Button2"
        Button2.Size = New Size(141, 46)
        Button2.TabIndex = 14
        Button2.Text = "Mostrar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(0, 69)
        Button1.Name = "Button1"
        Button1.Size = New Size(141, 46)
        Button1.TabIndex = 13
        Button1.Text = "Agregar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' txtValor
        ' 
        txtValor.Location = New Point(174, 77)
        txtValor.Name = "txtValor"
        txtValor.Size = New Size(153, 31)
        txtValor.TabIndex = 11
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Yellow
        Label3.Location = New Point(141, 22)
        Label3.Name = "Label3"
        Label3.Size = New Size(60, 25)
        Label3.TabIndex = 10
        Label3.Text = "Graph"
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(0, 202)
        Button4.Name = "Button4"
        Button4.Size = New Size(141, 46)
        Button4.TabIndex = 16
        Button4.Text = "Agregar"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(174, 144)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(153, 31)
        TextBox1.TabIndex = 17
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Yellow
        Label1.Location = New Point(221, 49)
        Label1.Name = "Label1"
        Label1.Size = New Size(76, 25)
        Label1.TabIndex = 18
        Label1.Text = "Agregar"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Yellow
        Label2.Location = New Point(221, 116)
        Label2.Name = "Label2"
        Label2.Size = New Size(74, 25)
        Label2.TabIndex = 19
        Label2.Text = "Mostrar"
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(351, 334)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox1)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(txtValor)
        Controls.Add(Label3)
        Name = "Form3"
        Text = "Form3"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents txtValor As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
