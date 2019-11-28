Imports System.ComponentModel.DataAnnotations.Schema
Imports System.ComponentModel.DataAnnotations
Public Class Cliente
    <MaxLength(13), Key>
    Public Property numIdentidad As String
    <MaxLength(20)>
    Public Property nombre As String
    <MaxLength(30)>
    Public Property apellidos As String
    <MaxLength(25)>
    Public Property correoElectronico As String
    <MaxLength(50)>
    Public Property direccion As String
    <Column(TypeName:="Date")>
    Public Property fechaNacimiento As DateTime
    <MaxLength(10)>
    Public Property telefono As String
    <MaxLength(10)>
    Public Property celular As String
    Public Property idGenero As Integer
    <ForeignKey("idGenero")>
    Public Property Genero As Genero
End Class
