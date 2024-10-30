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
        Me.DirectoryEntry1 = New System.DirectoryServices.DirectoryEntry()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblCantidadLibros
        '
        Me.lblCantidadLibros.AutoSize = True
        Me.lblCantidadLibros.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidadLibros.Location = New System.Drawing.Point(491, 22)
        Me.lblCantidadLibros.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCantidadLibros.Name = "lblCantidadLibros"
        Me.lblCantidadLibros.Size = New System.Drawing.Size(202, 27)
        Me.lblCantidadLibros.TabIndex = 1
        Me.lblCantidadLibros.Text = "Cantidad de libros"
        '
        'txtCantidadLibros
        '
        Me.txtCantidadLibros.Location = New System.Drawing.Point(715, 11)
        Me.txtCantidadLibros.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCantidadLibros.Multiline = True
        Me.txtCantidadLibros.Name = "txtCantidadLibros"
        Me.txtCantidadLibros.ReadOnly = True
        Me.txtCantidadLibros.Size = New System.Drawing.Size(59, 48)
        Me.txtCantidadLibros.TabIndex = 1
        '
        'lstLibros
        '
        Me.lstLibros.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.15!, System.Drawing.FontStyle.Bold)
        Me.lstLibros.FormattingEnabled = True
        Me.lstLibros.ItemHeight = 17
        Me.lstLibros.Location = New System.Drawing.Point(12, 103)
        Me.lstLibros.Name = "lstLibros"
        Me.lstLibros.Size = New System.Drawing.Size(775, 242)
        Me.lstLibros.TabIndex = 6
        '
        'BtnAgregar
        '
        Me.BtnAgregar.BackColor = System.Drawing.Color.LightGreen
        Me.BtnAgregar.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BtnAgregar.Location = New System.Drawing.Point(116, 367)
        Me.BtnAgregar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(91, 58)
        Me.BtnAgregar.TabIndex = 7
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = False
        '
        'BtnModificar
        '
        Me.BtnModificar.BackColor = System.Drawing.Color.Khaki
        Me.BtnModificar.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BtnModificar.Location = New System.Drawing.Point(252, 367)
        Me.BtnModificar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(94, 58)
        Me.BtnModificar.TabIndex = 8
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = False
        '
        'BtnBorrar
        '
        Me.BtnBorrar.BackColor = System.Drawing.Color.LightCoral
        Me.BtnBorrar.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BtnBorrar.Location = New System.Drawing.Point(478, 367)
        Me.BtnBorrar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(97, 58)
        Me.BtnBorrar.TabIndex = 9
        Me.BtnBorrar.Text = "Borrar"
        Me.BtnBorrar.UseVisualStyleBackColor = False
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.LightGray
        Me.BtnSalir.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BtnSalir.Location = New System.Drawing.Point(618, 367)
        Me.BtnSalir.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(91, 58)
        Me.BtnSalir.TabIndex = 10
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 20)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(134, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 20)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "TITULO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(441, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 20)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "AUTOR"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(647, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 20)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "AÑO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(699, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 20)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "PAGINAS"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(90, 22)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(281, 37)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Bibiloteca ""Teto"""
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(799, 451)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
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
    Friend WithEvents DirectoryEntry1 As DirectoryServices.DirectoryEntry
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Private WithEvents Label6 As Label
End Class
