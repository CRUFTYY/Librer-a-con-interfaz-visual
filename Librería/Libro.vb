

Public Class Libro

    Private _id As Integer
    Private _titulo As String
    Private _autor As String
    Private _anio As Integer
    Private _paginas As Integer

    Public Sub New(idd As Integer, titulo_ As String, autor_ As String, anio_ As Integer, paginas_ As Integer)
        Id = idd
        Titulo = titulo_
        Autor = autor_
        Anio = anio_
        Paginas = paginas_
    End Sub

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
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



    Public Function Datos() As String
        Return $"ID: {_id} - Título: {_titulo} - Autor: {_autor} - Año: {_anio} - Páginas: {_paginas}"
    End Function

    ' Método para serializar la lista de libros


    ' Método para deserializar la lista de libros
End Class
