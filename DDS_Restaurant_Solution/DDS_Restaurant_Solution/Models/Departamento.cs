using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DDS_Restaurant_Solution.Models
{
    public class Departamento
    {
        [Key]
        public int idDepartamento { get; set; }

        [MaxLength(20)]
        public string nombreDepartamento { get; set; }

        public int idPais { get; set; }
        [ForeignKey("idPais")]
        public Pais Pais { get; set; }
    }
}
