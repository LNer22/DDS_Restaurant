using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DDS_Restaurant_Solution.Models
{
    public class TipoUsuario
    {
        [Key]
        public int idTipoUsuario { get; set; }

        [MaxLength(15)]
        public string tipoUsuario { get; set; }
    }
}
