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
    }
}
