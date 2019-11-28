Imports System.ComponentModel.DataAnnotations.Schema
Imports System.ComponentModel.DataAnnotations
Public Class Mesa
    <Key>
    Public Property idMesa As Integer
    <MaxLength(3)>
    Public Property numMesa As String
    <MaxLength(2)>
    Public Property capacidad As String
    Public Property estadoMesa As Boolean
    Public Property idSucursal As Integer
    <ForeignKey("idSucursal")>
    Public Property Sucursal As Sucursal
End Class
