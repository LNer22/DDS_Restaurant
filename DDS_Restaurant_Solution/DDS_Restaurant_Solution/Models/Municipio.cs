using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DDS_Restaurant_Solution.Models
{
    public class Municipio
    {
        [Key]
        public int idMunicipio { get; set; }

        [MaxLength(20)]
        public string nombreMunicipio { get; set; }

        public int idDepartamento { get; set; }
        [ForeignKey("idDepartamento")]
        public Departamento Departamento { get; set; }
    }
}
