Imports System.Data.Entity

Public Class User
    Public Property Id As Integer
    Public Property Username As Integer
    Public Property CreationDate As DateTime
    Public Property Password As String
    Public Property Email As String

End Class
Public Class UserDBContent
    Inherits DbContext
    Public Property Users() As DbSet(Of User)
End Class
