Imports System.ComponentModel.DataAnnotations.Schema
Imports System.ComponentModel.DataAnnotations
Public Class Municipio
    <Key>
    Public Property idMunicipio As Integer
    <MaxLength(20)>
    Public Property nombreMunicipio As String
    Public Property idDepartamento As Integer
    <ForeignKey("idDepartamento")>
    Public Property Departamento As Departamento
End Class
