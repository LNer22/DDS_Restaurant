Imports System.ComponentModel.DataAnnotations.Schema
Imports System.ComponentModel.DataAnnotations
Public Class DetalleMenu
    <Key>
    Public Property idDetalleMenu As Integer
    Public Property cantidad As Integer
    Public Property idMenu As Integer
    <ForeignKey("idMenu")>
    Public Property Menu As Menu
    Public Property idProducto As Integer
    <ForeignKey("idProducto")>
    Public Property Productos As Producto
End Class
