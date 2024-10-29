Public Class Form2
    Private form1 As Form1
    Private libroActual As Libro

    Private Function ValidarDatos() As Boolean
        If String.IsNullOrWhiteSpace(txtTitulo.Text) Or String.IsNullOrWhiteSpace(txtAutor.Text) Or
           String.IsNullOrWhiteSpace(txtAnio.Text) Or String.IsNullOrWhiteSpace(txtPaginas.Text) Then
            MessageBox.Show("Por favor, completa todos los campos.")
            Return False
        End If
        Return True
    End Function

    Private Sub btnModif_Click_1(sender As Object, e As EventArgs) Handles btnModif.Click
        If libroActual IsNot Nothing AndAlso ValidarDatos() Then
            libroActual.Titulo = txtTitulo.Text
            libroActual.Autor = txtAutor.Text
            libroActual.Anio = Convert.ToInt32(txtAnio.Text)
            libroActual.Paginas = Convert.ToInt32(txtPaginas.Text)
            form1.GuardarLibrosEnArchivo()
            form1.actualizarListBox()
            Me.Close()
        End If
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If ValidarDatos() Then
            ReDim Preserve form1.libros(form1.libros.Length)
            form1.libros(form1.libros.Lenght - 1) = New Libro(1000, txtTitulo.Text, txtAutor.Text, Convert.ToInt32(txtAnio.Text), Convert.ToInt32(txtPaginas.Text))

            For i = 0 To form1.libros.Length

                ReDim Preserve form1.libros(form1.libros.Length)

            Next

            form1.GuardarLibrosEnArchivo()
            form1.actualizarListBox()
            Me.Close()
        End If
    End Sub
End Class
