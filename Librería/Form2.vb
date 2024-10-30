Public Class Form2
    Private form1 As Form1

    ' Constructor para recibir la instancia de Form1
    Public Sub New(parent As Form1)
        InitializeComponent()
        form1 = parent ' Asignar la instancia de Form1
    End Sub

    Private Function ValidarDatos() As Boolean
        If String.IsNullOrWhiteSpace(txtTitulo.Text) Or String.IsNullOrWhiteSpace(txtAutor.Text) Or
           String.IsNullOrWhiteSpace(txtAnio.Text) Or String.IsNullOrWhiteSpace(txtPaginas.Text) Then
            MessageBox.Show("Por favor, completa todos los campos.")
            Return False
        End If
        Return True
    End Function

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        If ValidarDatos() And form1.modificar = True Then
            form1.libros(form1.lstLibros.SelectedIndex).Titulo = txtTitulo.Text
            form1.libros(form1.lstLibros.SelectedIndex).Autor = txtAutor.Text
            form1.libros(form1.lstLibros.SelectedIndex).Anio = Convert.ToInt32(txtAnio.Text)
            form1.libros(form1.lstLibros.SelectedIndex).Paginas = Convert.ToInt32(txtPaginas.Text)
            form1.GuardarLibrosEnArchivo()
            form1.actualizarListBox()
            Me.Close()
        ElseIf form1.modificar = False Then
            Try
                If ValidarDatos() Then
                    ReDim Preserve form1.libros(form1.libros.Length)
                    form1.libros(form1.libros.Length - 1) = New Libro(form1.ObtenerSiguienteId(), txtTitulo.Text, txtAutor.Text, Convert.ToInt32(txtAnio.Text), Convert.ToInt32(txtPaginas.Text))

                    form1.GuardarLibrosEnArchivo()
                    form1.actualizarListBox()
                    Me.Close()
                End If
            Catch ex As Exception
                MessageBox.Show($"Error al agregar libro: {ex.Message}")
            End Try
        End If
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Hide()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
