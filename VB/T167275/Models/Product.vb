Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Data

Public Class Product
	Private privateProductID As Integer
	Public Property ProductID() As Integer
		Get
			Return privateProductID
		End Get
		Protected Set(ByVal value As Integer)
			privateProductID = value
		End Set
	End Property

	Public Property ProductName() As String

	Public Property SupplierID() As Integer

	Public Property CategoryID() As Integer

	Public Property QuantityPerUnit() As String

	Public Property UnitPrice() As Decimal

	Public Property UnitsInStock() As Short

	Public Property UnitsOnOrder() As Short

	Public Property ReorderLevel() As Short

	Public Property Discontinued() As Boolean

	Public Property EAN13() As String

	Private Shared Function GetProductsFromDataTable(ByVal data As DataTable) As List(Of Product)
		If data IsNot Nothing Then
			Dim products As New List(Of Product)()
			For Each row As DataRow In data.Rows
'INSTANT VB NOTE: The variable product was renamed since it may cause conflicts with calls to static members of the user-defined type with this name:
				Dim product_Renamed As New Product() With {.ProductID = DirectCast(row("ProductID"), Integer), .ProductName = DirectCast(row("ProductName"), String), .SupplierID = DirectCast(row("SupplierID"), Integer), .CategoryID = DirectCast(row("CategoryID"), Integer), .QuantityPerUnit = DirectCast(row("QuantityPerUnit"), String), .UnitPrice = DirectCast(row("UnitPrice"), Decimal), .UnitsInStock = DirectCast(row("UnitsInStock"), Short), .UnitsOnOrder = DirectCast(row("UnitsOnOrder"), Short), .ReorderLevel = DirectCast(row("ReorderLevel"), Short), .Discontinued = DirectCast(row("Discontinued"), Boolean), .EAN13 = DirectCast(row("EAN13"), String)}
				products.Add(product_Renamed)
			Next row
			Return products
		End If
		Return Nothing
	End Function

	Public Shared Function GetProducts() As List(Of Product)
		Dim prodData As DataTable = DataHelper.ProcessSelectCommand("SELECT * FROM [Products]")
		Return GetProductsFromDataTable(prodData)
	End Function

	Public Shared Function GetProducts(ByVal categoryID As Integer) As List(Of Product)
		Dim prodData As DataTable = DataHelper.ProcessSelectCommand("SELECT * FROM [Products] WHERE ([CategoryID] = {0})", categoryID)
		Return GetProductsFromDataTable(prodData)
	End Function
End Class