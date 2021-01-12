Imports System.Data.Entity

Public Class Product
    Public Property Id As Integer
    Public Property Name As Integer
    Public Property Quantity As Integer
    Public Property Price As Integer
    Public Property SalePresentage As Double
    Public Property OnSale As Boolean

End Class
Public Class ProductDBContent
    Inherits DbContext
    Public Property Products() As DbSet(Of Product)
End Class
