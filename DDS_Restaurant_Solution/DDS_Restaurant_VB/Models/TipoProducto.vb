Imports System.ComponentModel.DataAnnotations.Schema
Imports System.ComponentModel.DataAnnotations
Public Class TipoProducto
    <Key>
    Public Property idTipoProducto As Integer
    <MaxLength(25)>
    Public Property tipoProducto As String
End Class