namespace DDS_Restaurant_Solution.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using DDS_Restaurant_Solution.Data;
    using DDS_Restaurant_Solution.Models;

    public class DataContext : DbContext
    {
        public DataContext() : base("name = DDS_Restaurant_Solution.Properties.Settings.cnnStr")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<DataContext>());
        }
        public DbSet<Cargo> Cargos { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Sucursal> Sucursals { get; set; }
        public DbSet<TipoUsuario> TipoUsuarios { get; set; }
        public DbSet<Mesa> Mesas { get; set; }
        public DbSet<Pais> Pais { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Municipio> Municipios { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<DetalleMenu> DetalleMenus { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<TipoProducto> TipoProductos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<DetallePedido> DetallePedidos { get; set; }

        
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}