Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Public Class Genero
    <Key>
    Public Property idGenero As Integer
    <MaxLength(8)>
    Public Property genero As String
End Class
