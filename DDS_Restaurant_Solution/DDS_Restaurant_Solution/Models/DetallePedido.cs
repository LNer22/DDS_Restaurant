using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DDS_Restaurant_Solution.Models
{
    public class DetallePedido
    {
        [Key]
        public int idDetalleOrden { get; set; }

        public int cantidad { get; set; }

        public int idPedido { get; set; }
        [ForeignKey("idPedido")]
        public Pedido Ordenes { get; set; }

        public int idMenu { get; set; }
        [ForeignKey("idMenu")]
        public Menu Menu { get; set; }
    }
}
