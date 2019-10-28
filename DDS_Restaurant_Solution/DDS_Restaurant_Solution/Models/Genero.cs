using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DDS_Restaurant_Solution.Models
{
    public class Genero
    {
        [Key]
        public int idGenero { get; set; }

        [MaxLength(8)]
        public string genero { get; set; }

    }
}
