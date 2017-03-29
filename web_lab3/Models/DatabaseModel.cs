using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace web_lab3.Models
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Wall> Walls { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=web_lab3.db");
        }
    }

    public class Room
    {
        public int Id { get; set; }
        [Required]
        public string title { get; set; }
        [Required]
        public string description { get; set; }
        [Required]
        public double longitude { get; set; }
        [Required]
        public double cubeSide { get; set; }
        public double latitude { get; set; }


    }

    public class Wall
    {
        public int Id { get; set; }
        [Required]
        public string imageURL { get; set; }
        [Required]
        public string title { get; set; }
        [Required]
        public string description { get; set; }
        [Required]
        public int roomType { get; set; }
        [Required]
        public int roomID { get; set; }
        public virtual Room room { get; set; }
    }
}
