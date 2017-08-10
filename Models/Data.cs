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
        // Including measurement for soil moisture from a plant per room
        [Required]
        public ushort soil { get; set; }
        // Including motion detection from a PIR sensor in each room
        [Required]
        public ushort motion { get; set; }
    }
}
