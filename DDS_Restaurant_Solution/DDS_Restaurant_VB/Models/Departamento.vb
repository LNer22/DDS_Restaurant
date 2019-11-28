Imports System.ComponentModel.DataAnnotations.Schema
Imports System.ComponentModel.DataAnnotations
Public Class Departamento
    <Key>
    Public Property idDepartamento As Integer
    <MaxLength(20)>
    Public Property nombreDepartamento As String
    Public Property idPais As Integer
    <ForeignKey("idPais")>
    Public Property Pais As Pais
End Class
