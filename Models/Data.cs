using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HomeAutomation.Models
{
    public class Data
    {
        [Required]
        public string name { get; set; }

        [Required]
        public float temperature { get; set; }

        [Required]
        public float humidity { get; set; }
  
        [Required]
        public ushort soil { get; set; }
        
        [Required]
        public ushort motion { get; set; }
    }
}
