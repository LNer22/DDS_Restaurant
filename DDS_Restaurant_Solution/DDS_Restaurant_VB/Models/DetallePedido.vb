Imports System.ComponentModel.DataAnnotations.Schema
Imports System.ComponentModel.DataAnnotations
Public Class DetallePedido
    <Key>
    Public Property idDetalleOrden As Integer
    Public Property cantidad As Integer
    Public Property idPedido As Integer
    <ForeignKey("idPedido")>
    Public Property Ordenes As Pedido
    Public Property idMenu As Integer
    <ForeignKey("idMenu")>
    Public Property Menu As Menu
End Class
