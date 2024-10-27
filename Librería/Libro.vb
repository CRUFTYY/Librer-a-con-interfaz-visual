Imports System.IO
Imports System.Text.Json.Serialization
Imports System.Xml

Public Class Libro
    Public Shared nextID As Integer = 1000
    Private _id As Integer
    Private _titulo As String
    Private _autor As String
    Private _anio As Integer
    Private _paginas As Integer

    Public Sub New(titulo As String, autor As String, anio As Integer, paginas As Integer)
        _id = nextID
        nextID += 10
        _titulo = titulo
        _autor = autor
        _anio = anio
        _paginas = paginas
    End Sub

    Public ReadOnly Property Id As Integer
        Get
            Return _id
        End Get
    End Property

    Public Property Titulo As String
        Get
            Return _titulo
        End Get
        Set(value As String)
            _titulo = value
        End Set
    End Property

    Public Property Autor As String
        Get
            Return _autor
        End Get
        Set(value As String)
            _autor = value
        End Set
    End Property

    Public Property Anio As Integer
        Get
            Return _anio
        End Get
        Set(value As Integer)
            _anio = value
        End Set
    End Property

    Public Property Paginas As Integer
        Get
            Return _paginas
        End Get
        Set(value As Integer)
            _paginas = value
        End Set
    End Property

    Public Shared Property JsonConvert As Object

    Public Function Datos() As String
        Return $"ID: {_id} - Título: {_titulo} - Autor: {_autor} - Año: {_anio} - Páginas: {_paginas}"
    End Function

    ' Método para serializar la lista de libros
    Public Shared Sub GuardarLibros(libros As List(Of Libro), archivo As String)
        Dim json As String = JsonConvert.SerializeObject(libros, Formatting.Indented)
        File.WriteAllText(archivo, json)
    End Sub

    ' Método para deserializar la lista de libros
    Public Shared Function CargarLibros(archivo As String) As List(Of Libro)
        If Not File.Exists(archivo) Then Return New List(Of Libro)()
        Dim json As String = File.ReadAllText(archivo)
        Dim libros As List(Of Libro) = JsonConvert.DeserializeObject(Of List(Of Libro))(json)

        ' Actualiza el próximo ID
        If libros.Count > 0 Then
            nextID = libros.Last().Id + 10
        End If

        Return libros
    End Function
End Class
