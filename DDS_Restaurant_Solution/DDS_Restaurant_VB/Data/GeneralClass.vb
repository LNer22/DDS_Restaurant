Imports System.Security.Cryptography
Public Class GeneralClass
    Public Shared Property IdUsuario As Integer

    Public Shared Function SHA1(ByVal text As String) As String
        'Dim data = Encoding.ASCII.GetBytes(text)
        'Dim data = Encoding.ASCII.GetBytes(text)
        'Dim hashData = New SHA1Managed().ComputeHash(data)
        Dim hash = String.Empty

        'For Each b In hashData
        'hash += b.ToString("X2")
        'Next

        Return hash.ToLower()
    End Function

End Class
