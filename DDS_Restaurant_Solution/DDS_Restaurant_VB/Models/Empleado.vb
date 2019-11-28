Imports System.ComponentModel.DataAnnotations.Schema
Imports System.ComponentModel.DataAnnotations
Public Class Empleado
    <MaxLength(13), Key>
    Public Property numIdentidad As String
    <MaxLength(25)>
    Public Property nombre As String
    <MaxLength(35)>
    Public Property apellidos As String
    <MaxLength(50)>
    Public Property direccion As String
    <Column(TypeName:="Date")>
    Public Property fechaNacimiento As DateTime
    <MaxLength(10)>
    Public Property telefono As String
    <MaxLength(10)>
    Public Property celular As String
    <MaxLength(25)>
    Public Property correElectronico As String
    Public Property idMunicipio As Integer
    <ForeignKey("idMunicipio")>
    Public Property Municipio As Municipio
    Public Property idGenero As Integer
    <ForeignKey("idGenero")>
    Public Property Genero As Genero
    Public Property idCargo As Integer
    <ForeignKey("idCargo")>
    Public Property Cargo As Cargo
    Public Property idSucursal As Integer
    <ForeignKey("idSucursal")>
    Public Property Sucursal As Sucursal
End Class
