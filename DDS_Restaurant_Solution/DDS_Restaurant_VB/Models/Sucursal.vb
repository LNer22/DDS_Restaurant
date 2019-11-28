Imports System.ComponentModel.DataAnnotations.Schema
Imports System.ComponentModel.DataAnnotations
Public Class Sucursal
    <Key>
    Public Property idSucursal As Integer
    <MaxLength(15)>
    Public Property establecimiento As String
    <MaxLength(15)>
    Public Property nombreSucursal As String
    Public Property plantas As String
    Public Property direccion As String
    <MaxLength(8)>
    Public Property telefono As String
    <MaxLength(50)>
    Public Property correo As String
    <MaxLength(15)>
    Public Property RTN As String
End Class