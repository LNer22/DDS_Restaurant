Imports System.ComponentModel.DataAnnotations.Schema
Imports System.ComponentModel.DataAnnotations
Public Class Usuario
    <Key>
    Public Property idUsuario As Integer
    <MaxLength(20)>
    Public Property user As String
    <MaxLength(40)>
    Public Property password As String
    Public Property estado As Boolean
    Public Property lastLog As DateTime
    Public Property numIdentidad As String
    <ForeignKey("numIdentidad")>
    Public Property Empeado As Empleado
    Public Property idTipoUsuario As Integer
    <ForeignKey("idTipoUsuario")>
    Public Property TipoUsuario As TipoUsuario
End Class
