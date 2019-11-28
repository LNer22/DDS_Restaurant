Imports System.ComponentModel.DataAnnotations.Schema
Imports System.ComponentModel.DataAnnotations
Public Class Pedido
    <Key>
    Public Property idPedido As Integer
    Public Property fecha As DateTime
    <MaxLength(10)>
    Public Property estadoPedido As String
    Public Property numIdentidad As String
    <ForeignKey("numIdentidad")>
    Public Property Cliente As Cliente
    Public Property idMesa As Integer
    <ForeignKey("idMesa")>
    Public Property Mesa As Mesa
End Class
