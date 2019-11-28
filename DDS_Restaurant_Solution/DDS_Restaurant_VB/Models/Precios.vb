Imports System.ComponentModel.DataAnnotations.Schema
Imports System.ComponentModel.DataAnnotations
Public Class Precios
    <Key>
    Public Property idPrecio As Integer
    Public Property idMenu As Integer
    <ForeignKey("idMenu")>
    Public Property Menu As Menu
    Public Property precio As Single
    Public Property activo As Boolean
End Class
