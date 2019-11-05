using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDS_Restaurant_Solution.Data;
using DDS_Restaurant_Solution.Models;

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
    }
}
