Imports System.ComponentModel.DataAnnotations.Schema
Imports System.ComponentModel.DataAnnotations
Public Class Menu
    <Key>
    Public Property idMenu As Integer
    <MaxLength(25)>
    Public Property nombre As String
    <Column(TypeName:="Date")>
    Public Property fechaCreacion As DateTime
End Class
