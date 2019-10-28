using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DDS_Restaurant_Solution.Models
{
    public class TipoProducto
    {
        [Key]
        public int idTipoProducto { get; set; }

        [MaxLength(25)]
        public string tipoProducto { get; set; }
    }
}
