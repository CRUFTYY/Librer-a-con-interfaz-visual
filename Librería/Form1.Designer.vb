<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer
    Private lblCantidadLibros As Label
    Private txtCantidadLibros As TextBox

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblCantidadLibros = New System.Windows.Forms.Label()
        Me.txtCantidadLibros = New System.Windows.Forms.TextBox()
        Me.lstLibros = New System.Windows.Forms.ListBox()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnBorrar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblCantidadLibros
        '
        Me.lblCantidadLibros.AutoSize = True
        Me.lblCantidadLibros.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Italic)
        Me.lblCantidadLibros.Location = New System.Drawing.Point(394, 25)
        Me.lblCantidadLibros.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCantidadLibros.Name = "lblCantidadLibros"
        Me.lblCantidadLibros.Size = New System.Drawing.Size(122, 16)
        Me.lblCantidadLibros.TabIndex = 1
        Me.lblCantidadLibros.Text = "Cantidad de libros"
        '
        'txtCantidadLibros
        '
        Me.txtCantidadLibros.Location = New System.Drawing.Point(540, 24)
        Me.txtCantidadLibros.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCantidadLibros.Name = "txtCantidadLibros"
        Me.txtCantidadLibros.ReadOnly = True
        Me.txtCantidadLibros.Size = New System.Drawing.Size(31, 20)
        Me.txtCantidadLibros.TabIndex = 1
        '
        'lstLibros
        '
        Me.lstLibros.FormattingEnabled = True
        Me.lstLibros.Location = New System.Drawing.Point(45, 64)
        Me.lstLibros.Name = "lstLibros"
        Me.lstLibros.Size = New System.Drawing.Size(526, 160)
        Me.lstLibros.TabIndex = 6
        '
        'BtnAgregar
        '
        Me.BtnAgregar.BackColor = System.Drawing.Color.LightGreen
        Me.BtnAgregar.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregar.Location = New System.Drawing.Point(76, 244)
        Me.BtnAgregar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(75, 32)
        Me.BtnAgregar.TabIndex = 7
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = False
        '
        'BtnModificar
        '
        Me.BtnModificar.BackColor = System.Drawing.Color.LightPink
        Me.BtnModificar.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModificar.Location = New System.Drawing.Point(191, 244)
        Me.BtnModificar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(75, 32)
        Me.BtnModificar.TabIndex = 8
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = False
        '
        'BtnBorrar
        '
        Me.BtnBorrar.BackColor = System.Drawing.Color.LightCoral
        Me.BtnBorrar.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBorrar.Location = New System.Drawing.Point(307, 244)
        Me.BtnBorrar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(75, 32)
        Me.BtnBorrar.TabIndex = 9
        Me.BtnBorrar.Text = "Borrar"
        Me.BtnBorrar.UseVisualStyleBackColor = False
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.Red
        Me.BtnSalir.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.Location = New System.Drawing.Point(422, 244)
        Me.BtnSalir.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(75, 32)
        Me.BtnSalir.TabIndex = 10
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Bisque
        Me.ClientSize = New System.Drawing.Size(600, 325)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnBorrar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.lstLibros)
        Me.Controls.Add(Me.lblCantidadLibros)
        Me.Controls.Add(Me.txtCantidadLibros)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Gestión de Biblioteca"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstLibros As ListBox
    Private WithEvents BtnAgregar As Button
    Private WithEvents BtnModificar As Button
    Private WithEvents BtnBorrar As Button
    Private WithEvents BtnSalir As Button
End Class
