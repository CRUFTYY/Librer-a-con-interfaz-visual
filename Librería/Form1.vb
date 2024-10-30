Imports System.Text.Json
Imports System.IO

Public Class Form1
    Public modificar As Boolean = False
    Public libros(-1) As Libro
    Private Const archivoLibros As String = "libros.json"
    Dim opti As JsonSerializerOptions = New JsonSerializerOptions
    Private siguienteId As Integer = 1000

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarLibrosDesdeArchivo()
        actualizarListBox()
    End Sub

    Public Sub actualizarListBox()
        lstLibros.Items.Clear()
        For Each libro In libros
            lstLibros.Items.Add(libro.Datos())
        Next
        txtCantidadLibros.Text = libros.Length.ToString()
    End Sub

    Private Sub CargarLibrosDesdeArchivo()
        Try
            Dim jsonArchivo As String = My.Computer.FileSystem.ReadAllText(archivoLibros)
            libros = JsonSerializer.Deserialize(Of Libro())(jsonArchivo, opti)
            siguienteId = libros(libros.Length - 1).Id + 10
        Catch ex As Exception
            MessageBox.Show($"Error al cargar libros desde el archivo: {ex.Message}")
        End Try
    End Sub


    Public Sub GuardarLibrosEnArchivo()
        Try
            Dim json As String = JsonSerializer.Serialize(libros, opti)
            My.Computer.FileSystem.WriteAllText(archivoLibros, json, False)
        Catch ex As Exception
            MessageBox.Show($"Error al guardar libros en archivo: {ex.Message}")
        End Try
    End Sub


    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        modificar = False
        Dim form2 As New Form2(Me) ' Pasar la instancia de Form1
        form2.Show()
        actualizarListBox()
    End Sub


    Private Sub BtnBorrar_Click_1(sender As Object, e As EventArgs) Handles BtnBorrar.Click
        If lstLibros.SelectedItem IsNot Nothing Then
            Dim index As Integer = lstLibros.SelectedIndex
            For i As Integer = index To (libros.Length - 2)
                libros(i) = libros(i + 1)
            Next
            ReDim Preserve libros(libros.Length - 2)
            GuardarLibrosEnArchivo()
            actualizarListBox()
        Else
            MessageBox.Show("Por favor, selecciona un libro para borrar.")
        End If
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        If lstLibros.SelectedItem IsNot Nothing Then
            Dim form2 As New Form2(Me) ' Pasar la instancia de Form1
            Dim libroSeleccionado As Libro = libros(lstLibros.SelectedIndex)
            form2.txtTitulo.Text = libroSeleccionado.Titulo
            form2.txtAutor.Text = libroSeleccionado.Autor
            form2.txtAnio.Text = libroSeleccionado.Anio.ToString()
            form2.txtPaginas.Text = libroSeleccionado.Paginas.ToString()
            modificar = True
            form2.Show()
        Else
            MessageBox.Show("Por favor, selecciona un libro para modificar.")
        End If
    End Sub


    Public Function ObtenerSiguienteId() As Integer
        Dim id As Integer = siguienteId
        siguienteId += 10 ' Incrementar para el siguiente libro
        Return id
    End Function

    Private Sub lstLibros_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstLibros.SelectedIndexChanged

    End Sub
End Class
