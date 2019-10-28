using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DDS_Restaurant_Solution.Models
{
    public class Cargo
    {
        [Key]
        public int idCargo { get; set; }

        [MaxLength(30)]
        public string cargo { get; set; }
        
    }
}
