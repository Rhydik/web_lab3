using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace web_lab3.Models
{
    class Room
    {
        public int Id { get; set; }
        [Required]
        public String title { get; set; }
        [Required]
        public String description { get; set; }
        [Required]
        public double longitude { get; set; }
        [Required]
        public double cubeSide { get; set; }
        public double latitude { get; set; }


    }
}
