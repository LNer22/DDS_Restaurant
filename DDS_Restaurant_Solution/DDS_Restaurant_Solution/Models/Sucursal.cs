    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DDS_Restaurant_Solution.Models
{
    public class Sucursal
    {
        [Key]
        public int idSucursal { get; set; }

        [MaxLength(15)]
        public string establecimiento { get; set; }

        [MaxLength(15)]
        public string nombreSucursal { get; set; }

        public string plantas { get; set; }

        public string direccion { get; set; }

        [MaxLength(8)]
        public string telefono { get; set; }

        [MaxLength(50)]
        public string correo { get; set; }

        [MaxLength(15)]
        public string RTN { get; set; }
    }
}
