Public Class Form2
    Private form1 As Form1
    Private libroActual As Libro

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs, form1 As Form1)
        If ValidarDatos() Then
            Dim nuevoLibro As New Libro(txtTitulo.Text, txtAutor.Text, Convert.ToInt32(txtAnio.Text), Convert.ToInt32(txtPaginas.Text))
            form1.libros.Add(nuevoLibro)
            form1.GuardarLibrosEnArchivo()
            form1.actualizarListBox()
            Me.Close()
        End If
    End Sub

    Private Sub btnModif_Click(sender As Object, e As EventArgs)
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

    Private Function ValidarDatos() As Boolean
        If String.IsNullOrWhiteSpace(txtTitulo.Text) Or String.IsNullOrWhiteSpace(txtAutor.Text) Or
           String.IsNullOrWhiteSpace(txtAnio.Text) Or String.IsNullOrWhiteSpace(txtPaginas.Text) Then
            MessageBox.Show("Por favor, completa todos los campos.")
            Return False
        End If
        Return True
    End Function
End Class
