using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DDS_Restaurant_Solution.Models
{
    public class Pais
    {
        [Key]
        public int idPais { get; set; }

        [MaxLength(20)]
        public string nombrePais { get; set; }
    }
}
