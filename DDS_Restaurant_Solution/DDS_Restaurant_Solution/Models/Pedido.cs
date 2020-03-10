using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DDS_Restaurant_Solution.Models
{
    public class Pedido
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idPedido { get; set; }
        
        public DateTime fecha { get; set; }

        [MaxLength(10)]
        public string estadoPedido { get; set; }
        
        public string numIdentidad { get; set; }
        [ForeignKey("numIdentidad")]
        public Cliente Cliente { get; set; }

        public int idMesa { get; set; }
        [ForeignKey("idMesa")]
        public Mesa Mesa { get; set; }

        public int idUsuario { get; set; }
        [ForeignKey("idUsuario")]
        public Usuario Usuario { get; set; }
    }
}
