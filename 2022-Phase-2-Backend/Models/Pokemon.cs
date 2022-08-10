using System.ComponentModel.DataAnnotations;

namespace _2022_Phase_2_Backend.Models
{
    public class Pokemon
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Speed { get; set; }
        public int Health { get;set; }  

    }
}
