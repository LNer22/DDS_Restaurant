Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Public Class Cargo
    <Key>
    Public Property idCargo As Integer
    <MaxLength(30)>
    Public Property cargo As String
End Class
