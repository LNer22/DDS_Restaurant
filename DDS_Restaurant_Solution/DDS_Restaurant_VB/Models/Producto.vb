Imports System.ComponentModel.DataAnnotations.Schema
Imports System.ComponentModel.DataAnnotations
Public Class Producto
    <Key>
    Public Property idProducto As Integer
    <MaxLength(25)>
    Public Property descripcion As String
    Public Property idTipoProducto As Integer
    <ForeignKey("idTipoProducto")>
    Public Property TipoProducto As TipoProducto
End Class
