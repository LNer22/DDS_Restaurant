using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DDS_Restaurant_Solution.Models
{
    public class Mesa
    {
        [Key]
        public int idMesa { get; set; }

        [MaxLength(2)]
        public string capacidad { get; set; }

        public bool estadoMesa { get; set; }

        public int idSucursal { get; set; }
        [ForeignKey("idSucursal")]
        public Sucursal Sucursal { get; set; }
    }
}
