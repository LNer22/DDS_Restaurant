Imports System.ComponentModel.DataAnnotations.Schema
Imports System.ComponentModel.DataAnnotations
Public Class TipoUsuario
    <Key>
    Public Property idTipoUsuario As Integer
    <MaxLength(15)>
    Public Property tipoUsuario As String
End Class
