using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DDS_Restaurant_Solution.Models
{
    public class Precios
    {
        [Key]
        public int idPrecio { get; set; }

        public int idMenu { get; set; }
        [ForeignKey("idMenu")]
        public Menu Menu { get; set; }

        public float precio { get; set; }

        public bool activo { get; set; }
    }
}
