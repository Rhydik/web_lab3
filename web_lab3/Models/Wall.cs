using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace web_lab3.Models
{
    class Wall
    {
        public int Id { get; set; }
        [Required]
        public String imageURL { get; set; }
        [Required]
        public String title { get; set; }
        [Required]
        public String description { get; set; }
        [Required]
        public int roomType { get; set; }
        [Required]
        public int roomID { get; set; }
        public virtual Room room { get; set; }
    }
}
