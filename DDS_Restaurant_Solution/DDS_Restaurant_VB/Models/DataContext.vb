Imports System
Imports System.Data.Entity
Imports System.Linq

Public Class DataContext
    Inherits DbContext

    Public Sub New()
        MyBase.New("name = DDS_Restaurant_VB.My.MySettings.cnnStr")
        Database.SetInitializer(New CreateDatabaseIfNotExists(Of DataContext)())
    End Sub
    Public Property Cargos As DbSet(Of Cargo)
    Public Property Generos As DbSet(Of Genero)
    Public Property Sucursals As DbSet(Of Sucursal)
    Public Property TipoUsuarios As DbSet(Of TipoUsuario)
    Public Property Mesas As DbSet(Of Mesa)
    Public Property Pais As DbSet(Of Pais)
    Public Property Empleados As DbSet(Of Empleado)
    Public Property Departamentos As DbSet(Of Departamento)
    Public Property Municipios As DbSet(Of Municipio)
    Public Property Usuarios As DbSet(Of Usuario)
    Public Property Clientes As DbSet(Of Cliente)
    Public Property Menus As DbSet(Of Menu)
    Public Property DetalleMenus As DbSet(Of DetalleMenu)
    Public Property Productos As DbSet(Of Producto)
    Public Property TipoProductos As DbSet(Of TipoProducto)
    Public Property Pedidos As DbSet(Of Pedido)
    Public Property DetallePedidos As DbSet(Of DetallePedido)
    Public Property Precios As DbSet(Of Precios)

End Class

'Public Class MyEntity
'    Public Property Id() As Int32
'    Public Property Name() As String
'End Class
