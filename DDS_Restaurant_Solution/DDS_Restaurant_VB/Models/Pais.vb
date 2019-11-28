Imports System.ComponentModel.DataAnnotations.Schema
Imports System.ComponentModel.DataAnnotations
Public Class Pais
    <Key>
    Public Property idPais As Integer
    <MaxLength(20)>
    Public Property nombrePais As String
End Class
