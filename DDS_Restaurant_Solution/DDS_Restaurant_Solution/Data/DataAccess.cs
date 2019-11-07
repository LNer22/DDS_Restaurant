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

        public static string login(string user, string pass)
        {
            var datos = (from c in ctx.Usuarios
                        where c.user == user && c.password == pass
                        select c).SingleOrDefault();
            if (datos != null)
            {
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
        public static void cargarMesas(DataGridView dgv)
        {
            var datos = (from c in ctx.Mesas
                         orderby c.estadoMesa descending
                         select new { N_de_Mesa = c.idMesa, Capacidad = c.capacidad, Disponible = c.estadoMesa}).ToList();
            dgv.DataSource = datos;
        }
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
    }
}
