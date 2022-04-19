using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationCalculatorAPI.Data.Models
{
    public  class Calc
    {
        public int Number1 { get; set; }
        [Required]
        [StringLength(2)]
        public int Number2 { get; set; }
        [Required]
        [StringLength(2)]
        public int Result { get; set; }
        [Required]
        [StringLength(5)]
    }
}
