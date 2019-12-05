using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DDS_Restaurant_Solution.Models
{
    public class Producto
    {
        [Key]
        public int idProducto { get; set; }

        [MaxLength(25)]
        public string descripcion { get; set; }

        public bool estado { get; set; }

        [Column(TypeName ="money")]
        public decimal precio { get; set; }

        public int idTipoProducto { get; set; }
        [ForeignKey("idTipoProducto")]
        public TipoProducto TipoProducto { get; set; }

    }
}
