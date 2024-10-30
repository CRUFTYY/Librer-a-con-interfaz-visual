<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.txtAutor = New System.Windows.Forms.TextBox()
        Me.txtAnio = New System.Windows.Forms.TextBox()
        Me.txtPaginas = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnModif = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtTitulo
        '
        Me.txtTitulo.Location = New System.Drawing.Point(194, 65)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(100, 20)
        Me.txtTitulo.TabIndex = 0
        '
        'txtAutor
        '
        Me.txtAutor.Location = New System.Drawing.Point(194, 126)
        Me.txtAutor.Name = "txtAutor"
        Me.txtAutor.Size = New System.Drawing.Size(100, 20)
        Me.txtAutor.TabIndex = 1
        '
        'txtAnio
        '
        Me.txtAnio.Location = New System.Drawing.Point(194, 191)
        Me.txtAnio.Name = "txtAnio"
        Me.txtAnio.Size = New System.Drawing.Size(100, 20)
        Me.txtAnio.TabIndex = 2
        '
        'txtPaginas
        '
        Me.txtPaginas.Location = New System.Drawing.Point(194, 244)
        Me.txtPaginas.Name = "txtPaginas"
        Me.txtPaginas.Size = New System.Drawing.Size(100, 20)
        Me.txtPaginas.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(117, 129)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Autor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(116, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Titulo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(118, 194)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Año"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(117, 247)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Paginas"
        '
        'btnModif
        '
        Me.btnModif.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModif.Location = New System.Drawing.Point(102, 302)
        Me.btnModif.Name = "btnModif"
        Me.btnModif.Size = New System.Drawing.Size(88, 37)
        Me.btnModif.TabIndex = 8
        Me.btnModif.Text = "Modificar"
        Me.btnModif.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Location = New System.Drawing.Point(219, 302)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(86, 37)
        Me.btnAgregar.TabIndex = 9
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightYellow
        Me.ClientSize = New System.Drawing.Size(530, 373)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnModif)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPaginas)
        Me.Controls.Add(Me.txtAnio)
        Me.Controls.Add(Me.txtAutor)
        Me.Controls.Add(Me.txtTitulo)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form2"
        Me.Text = "Agregar/Modificar Libro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTitulo As TextBox
    Friend WithEvents txtAutor As TextBox
    Friend WithEvents txtAnio As TextBox
    Friend WithEvents txtPaginas As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnModif As Button
    Friend WithEvents btnAgregar As Button
End Class
