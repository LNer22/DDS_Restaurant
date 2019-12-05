using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDS_Restaurant_Solution.Data;
using DDS_Restaurant_Solution.Models;
using System.Windows.Forms;

namespace DDS_Restaurant_Solution.Data
{
    public class DataAccess
    {
        static string cnnStr = Properties.Settings.Default.cnnStr.ToString();
        static DataContext ctx = new DataContext();

        //***********LOGIN***********
        public static string login(string user, string pass)
        {
            var datos = (from c in ctx.Usuarios
                         where c.user == user && c.password == pass
                         select c).SingleOrDefault();


            if (datos != null)
            {
                Data.GeneralClass.IdUsuario = datos.idUsuario;
                if (datos.estado == true)
                {
                    return "OK";
                }
                else
                {
                    return "Disabled";
                }
            }
            else
            {
                return "NULL";
            }


        }
        //***********USER***********
        public static string nombre(int id)
        {
            var datos = (from c in ctx.Usuarios
                         where c.idUsuario == id
                         select c).SingleOrDefault();
            return string.Concat(datos.Empeado.nombre.ToString(), " ", datos.Empeado.apellidos.ToString());
        }
        //***********MESAS*************
        public static void cargarMesas(DataGridView dgv)
        {
            var datos = (from c in ctx.Mesas
                         where c.activa == true
                         orderby c.estadoMesa descending
                         select new {ID = c.idMesa , N_de_Mesa = c.numMesa, Capacidad = c.capacidad, Disponible = c.estadoMesa }).ToList();
            dgv.DataSource = datos;
        }
        public static void cargarSucursal(ComboBox cbo)
        {
            cbo.DataSource = ctx.Sucursals.ToList();
            cbo.DisplayMember = "establecimiento" +
                "";
            cbo.ValueMember = "idSucursal";
        }
        public static void añadirMesa(Mesa mesa)
        {
            ctx.Mesas.Add(mesa);
            ctx.SaveChanges();
        }
        public static Mesa devM(int id)
        {
            var datos = (from c in ctx.Mesas
                         where c.idMesa == id
                         select c).SingleOrDefault();
            return datos;
        }
        public static void deleteM(int id, bool es)
        {
            var datos = (from c in ctx.Mesas
                         where c.idMesa == id
                         select c).SingleOrDefault();
            datos.activa = es;
            ctx.SaveChanges();
        }
        public static void updateM(int id,string num ,string capacidad)
        {
            var datos = (from c in ctx.Mesas
                         where c.idMesa == id
                         select c).SingleOrDefault();
            datos.capacidad = capacidad;
            datos.numMesa = num;
            ctx.SaveChanges();
        }
        public static void updateME(int id,bool es)
        {
            var datos = (from c in ctx.Mesas
                         where c.idMesa == id
                         select c).SingleOrDefault();
            datos.estadoMesa = es;
            ctx.SaveChanges();
        }

        //***********CLIENTES***********
        public static void cargarClientes(DataGridView dgv)
        {
            var datos = (from c in ctx.Clientes
                         orderby c.nombre descending
                         select new {N_Identidad = c.numIdentidad,Nombre_Completo = string.Concat(c.nombre.ToString() , " ", c.apellidos.ToString()),
                         Email = c.correoElectronico,Celular = c.celular.ToString(), Direccion = c.direccion,
                         Edad = DateTime.Today.Year - c.fechaNacimiento.Year, Genero = c.Genero.genero
                         }).ToList();
            dgv.DataSource = datos;
        }
        //***********PEDIDOS/ORDENES***********
        public static void cargarPedidos(DataGridView dgv)
        {
            var datos = (from c in ctx.DetallePedidos
                         orderby c.Ordenes.fecha ascending
                         select new {N_de_Pedido = c.idPedido,Fecha = c.Ordenes.fecha.ToString(),Estado = c.Ordenes.estadoPedido,
                         N_de_identidad =c.Ordenes.numIdentidad, N_Mesa = c.Ordenes.idMesa,
                         Detalle = string.Concat(c.cantidad.ToString()," ",c.Menu.nombre.ToString())
                         }).ToList();
            dgv.DataSource = datos;
        }
        public static void cargarMenuP(FlowLayoutPanel flp)
        {
            var datos = (from c in ctx.Precios
                         select new
                         {
                             id = c.Menu.idMenu,
                             name = c.Menu.nombre.ToString(),
                             precio = c.precio.ToString()
                         }).ToList();

            
            for (int i = 0; i < datos.Count; i++)
            {
                var datoS = (from c in ctx.Precios
                             where c.idPrecio == (i+1)
                             select new
                             {
                                 id = c.Menu.idMenu,
                                 name = c.Menu.nombre.ToString(),
                                 precio = c.precio.ToString()
                             }).FirstOrDefault();
                Button btn = new Button()
                {
                    BackColor = System.Drawing.Color.Transparent,
                    FlatStyle = System.Windows.Forms.FlatStyle.Flat,
                    Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0),
                    ForeColor = System.Drawing.Color.Black,
                    Size = new System.Drawing.Size(166, 54),
                    UseVisualStyleBackColor = false,
                    Text = $"{datoS.name}\nL.{datoS.precio}"
                };
                flp.Controls.Add(btn);
            }
            
        }
        public static string devD(int i)
        {
            var datoS = (from c in ctx.Precios
                         where c.idPrecio == (i + 1)
                         select new
                         {
                             id = c.Menu.idMenu,
                             name = c.Menu.nombre.ToString(),
                             precio = c.precio.ToString()
                         }).FirstOrDefault();
            return datoS.name.ToString();
        }
        public static string devPre(int i)
        {
            var datoS = (from c in ctx.Precios
                         where c.idPrecio == (i + 1)
                         select new
                         {
                             id = c.Menu.idMenu,
                             name = c.Menu.nombre.ToString(),
                             precio = c.precio.ToString()
                         }).FirstOrDefault();
            return datoS.precio.ToString();
        }
        //***********MENU/PRODUCTOS***********
        public static void cargarTipo(ComboBox cbo)
        {
            cbo.DataSource = ctx.TipoProductos.ToList();
            cbo.DisplayMember = "tipoProducto" +
                "";
            cbo.ValueMember = "idTipoProducto";
        }
        public static int devTipo(string name)
        {
            var datos = (from c in ctx.TipoProductos
                         where c.tipoProducto == name
                         select c).SingleOrDefault();
            return datos.idTipoProducto;
        } 
        public static void cargarMenu(DataGridView dgv)
        {
            var datos = (from c in ctx.DetalleMenus
                         group c by new
                         {
                             c.Menu.nombre,
                             c.Productos.descripcion,
                             c.cantidad
                         } into dtll
                         select new {
                             dtll.Key.descripcion,
                             Nombre_del_combo = dtll.Key.nombre,
                             Cantidad = dtll.Key.cantidad
                         }).ToList();
            dgv.DataSource = datos;
        }
        public static void cargarProductos(DataGridView dgv)
        {
            var datos = (from c in ctx.Productos
                         where c.estado == true
                         orderby c.TipoProducto.idTipoProducto descending
                         select new {ID = c.idProducto ,Descripcion = c.descripcion, Tipo = c.TipoProducto.tipoProducto, Precio = c.precio
                         }).ToList();
            dgv.DataSource = datos;
        }
        public static void añadirP(Producto producto)
        {
            ctx.Productos.Add(producto);
            ctx.SaveChanges();
        }
        public static Producto devP(int id)
        {
            var datos = (from c in ctx.Productos
                         where c.idProducto == id
                         select c).SingleOrDefault();
            return datos;
        }
        public static void deleteP(int id, bool es)
        {
            var datos = (from c in ctx.Productos
                         where c.idProducto == id
                         select c).SingleOrDefault();
            datos.estado = es;
            ctx.SaveChanges();

        }
        public static void updateP(int id, int idTipo, string descripcion, decimal precio)
        {
            var datos = (from c in ctx.Productos
                         where c.idProducto == id
                         select c).SingleOrDefault();
            datos.idTipoProducto = idTipo;
            datos.descripcion = descripcion;
            datos.precio = precio;
            ctx.SaveChanges();
        }
        public static void cargarTab(TabControl tb)
        {
            var datos = (from c in ctx.TipoProductos
                         select new
                         {
                             c.tipoProducto
                         }).ToList();
            foreach (var item in datos)
            {
                tb.TabPages.Add(item.tipoProducto);
            }
            var datoSs = (from c in ctx.Productos
                          where c.TipoProducto.tipoProducto == tb.SelectedTab.Text
                         select new
                         {
                             c.idProducto,
                             c.descripcion
                         }).ToList();




            for (int i = 0; i < datoSs.Count; i++)
            {
                var itm  = datoSs.ElementAt(i);
                Button btn = new Button()
                {
                    BackColor = System.Drawing.Color.Transparent,
                    FlatStyle = System.Windows.Forms.FlatStyle.Flat,
                    Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0),
                    ForeColor = System.Drawing.Color.Black,
                    Size = new System.Drawing.Size(180, 50),
                    UseVisualStyleBackColor = false,
                    Tag = itm.idProducto,
                    Text = $"{itm.descripcion}"
                };

                tb.SelectedTab.Controls.Add(btn);
                //tb.Controls.Add(btn);
                
            }
            

            //tb.Controls.Add;
        }
        public static void cargarTBI(TabControl tb)
        {
           
            var datoSs = (from c in ctx.Productos
                          where c.TipoProducto.tipoProducto == tb.SelectedTab.Text
                          select new
                          {
                              c.idProducto,
                              c.descripcion
                          }).ToList();




            for (int i = 0; i < datoSs.Count; i++)
            {
                var itm = datoSs.ElementAt(i);
                Button btn = new Button()
                {
                    BackColor = System.Drawing.Color.Transparent,
                    FlatStyle = System.Windows.Forms.FlatStyle.Flat,
                    Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0),
                    ForeColor = System.Drawing.Color.Black,
                    Size = new System.Drawing.Size(180, 50),
                    UseVisualStyleBackColor = false,
                    Tag = itm.idProducto,
                    Text = $"{itm.descripcion}"
                };

                tb.SelectedTab.Controls.Add(btn);
            }
        }
        public static decimal devPrecio(int id)
        {
            var datos = (from c in ctx.Productos
                         where c.idProducto == id
                         select c).SingleOrDefault();
            return datos.precio;
        }
        public static int añadirCombo(Models.Menu menu)
        {
            ctx.Menus.Add(menu);
            ctx.SaveChanges();

            return menu.idMenu;
        }
        public static void añadirPrecio(Models.Precios menu)
        {
            ctx.Precios.Add(menu);
            ctx.SaveChanges();
        }
        public static void añadirDetalle(DetalleMenu menu)
        {
            ctx.DetalleMenus.Add(menu);
            ctx.SaveChanges();
        }

    }
}
