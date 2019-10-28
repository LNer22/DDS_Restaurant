using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DDS_Restaurant_Solution.Models
{
    public class Empleado
    {
        [MaxLength(13),Key]
        public string numIdentidad { get; set; }

        [MaxLength(25)]
        public string nombre { get; set; }

        [MaxLength(35)]
        public string apellidos { get; set; }

        [MaxLength(50)]
        public string direccion { get; set; }

        [Column(TypeName = "Date")]
        public DateTime fechaNacimiento { get; set; }

        [MaxLength(10)]
        public string telefono { get; set; }

        [MaxLength(10)]
        public string celular { get; set; }
        
        [MaxLength(25)]
        public string correElectronico { get; set; }

        public int idMunicipio { get; set; }
        [ForeignKey("idMunicipio")]
        public Municipio Municipio { get; set; }

        public int idGenero { get; set; }
        [ForeignKey("idGenero")]
        public Genero Genero { get; set; }

        public int idCargo { get; set; }
        [ForeignKey("idCargo")]
        public Cargo Cargo { get; set; }

        public int idSucursal { get; set; }
        [ForeignKey("idSucursal")]
        public Sucursal Sucursal { get; set; }
    }
}
