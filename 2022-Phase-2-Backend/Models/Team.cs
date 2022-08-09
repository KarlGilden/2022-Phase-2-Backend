using System.ComponentModel.DataAnnotations;

namespace _2022_Phase_2_Backend.Models
{
    public class Team
    {
        [Key]
        public int Id { get; set; }
        public Pokemon Pokemon1 { get; set; }
        public Pokemon Pokemon2 { get; set; }
        public Pokemon Pokemon3 { get; set; }
        public Pokemon Pokemon4 { get; set; }
        public Pokemon Pokemon5 { get; set; }
        public Pokemon Pokemon6 { get; set; }
    }
}
