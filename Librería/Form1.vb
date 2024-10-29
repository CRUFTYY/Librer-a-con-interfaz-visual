Imports System.Text.Json
Imports System.IO
Public Class Form1

    Public libros(-1) As Libro
    Private Const archivoLibros As String = "libros.json"

    Dim opti As JsonSerializerOptions = New JsonSerializerOptions
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarLibrosDesdeArchivo()
        actualizarListBox()
    End Sub

    Public Sub actualizarListBox()
        lstLibros.Items.Clear()
        For Each libro In libros
            lstLibros.Items.Add(libro.Datos())
        Next
        txtCantidadLibros.Text = libros.Count.ToString()
    End Sub

    Private Sub CargarLibrosDesdeArchivo()

        Dim jsonArchivo As String = My.Computer.FileSystem.ReadAllText(archivoLibros)
        libros = JsonSerializer.Deserialize(Of Libro())(jsonArchivo, opti)
    End Sub

    Public Sub GuardarLibrosEnArchivo()

    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Form2.Show()
        actualizarListBox()
    End Sub

    Private Sub BtnBorrar_Click_1(sender As Object, e As EventArgs) Handles BtnBorrar.Click
        If lstLibros.SelectedItem IsNot Nothing Then
            For i As Integer = lstLibros.SelectedIndex To (libros.Length) - 2

                libros(i) = libros(i + 1)

            Next
            ReDim Preserve libros(libros.Length - 2)
            actualizarListBox()
        Else
            MessageBox.Show("Por favor, selecciona un libro para borrar.")
        End If
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Form2.Show()
        actualizarListBox()
    End Sub
End Class
