using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DDS_Restaurant_Solution.Models
{
    public class Cliente
    {
        [MaxLength(13),Key]
        public string numIdentidad { get; set; }

        [MaxLength(20)]
        public string nombre { get; set; }

        [MaxLength(30)]
        public string apellidos { get; set; }

        [MaxLength(25)]
        public string correoElectronico { get; set; }

        [MaxLength(50)]
        public string direccion { get; set; }

        [Column(TypeName = "Date")]
        public DateTime fechaNacimiento { get; set; }

        [MaxLength(10)]
        public string telefono { get; set; }

        [MaxLength(10)]
        public string celular { get; set; }

        public int idGenero { get; set; }
        [ForeignKey("idGenero")]
        public Genero Genero { get; set; }

        public bool acctivo { get; set; }
    }
}
