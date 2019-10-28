using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DDS_Restaurant_Solution.Models
{
    public class Usuario
    {
        [Key]
        public int idUsuario { get; set; }

        [MaxLength(20)]
        public string user { get; set; }

        [MaxLength(40)]
        public string password { get; set; }

        public bool estado { get; set; }

        public DateTime lastLog { get; set; }

        public string numIdentidad { get; set; }
        [ForeignKey("numIdentidad")]
        public Empleado Empeado { get; set; }

        public int idTipoUsuario { get; set; }
        [ForeignKey("idTipoUsuario")]
        public TipoUsuario TipoUsuario { get; set; }
    }
}
