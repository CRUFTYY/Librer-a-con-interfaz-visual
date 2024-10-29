Public Class Form2
    Private form1 As Form1
    Private libroActual As Libro

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs, form1 As Form1)
        If ValidarDatos() Then
            Dim nuevoLibro As New Libro(1000, txtTitulo.Text, txtAutor.Text, Convert.ToInt32(txtAnio.Text), Convert.ToInt32(txtPaginas.Text))

            For i = 0 To form1.libros.Length

                ReDim Preserve form1.libros(form1.libros.Length)

            Next

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

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtAutor.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtTitulo.TextChanged

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles txtPaginas.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

    End Sub
End Class
