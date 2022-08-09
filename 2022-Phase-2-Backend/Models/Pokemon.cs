using System.ComponentModel.DataAnnotations;

namespace _2022_Phase_2_Backend.Models
{
    public class Pokemon
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public int Attack { get; set; }
        [Required]
        public int Defense { get; set; }
        [Required]
        public int Speed { get; set; }
        [Required]
        public int Health { get;set; }  

    }
}
