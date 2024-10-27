﻿Imports System.Drawing.Text
Imports System.Text.Json
Public Class Form1

    Public libros As New List(Of Libro)()
    Private Const archivoLibros As String = "libros.json"


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
        libros = Libro.CargarLibros(archivoLibros)
    End Sub

    Public Sub GuardarLibrosEnArchivo()
        Libro.GuardarLibros(libros, archivoLibros)
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Me.Hide()
        Form2.Show()
        actualizarListBox()
    End Sub

    Private Sub BtnBorrar_Click_1(sender As Object, e As EventArgs) Handles BtnBorrar.Click
        If lstLibros.SelectedItem IsNot Nothing Then
            libros.RemoveAt(lstLibros.SelectedIndex)
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
        Me.Hide()
        Form2.Show()
        actualizarListBox()
    End Sub
End Class

