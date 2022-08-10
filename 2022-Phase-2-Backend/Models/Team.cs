using System.ComponentModel.DataAnnotations;

namespace _2022_Phase_2_Backend.Models
{
    public class Team
    {
        [Key]
        public int Id { get; set; }
        public string Pokemon1 { get; set; } = string.Empty;
        public string Pokemon2 { get; set; } = string.Empty;
        public string Pokemon3 { get; set; } = string.Empty;
        public string Pokemon4 { get; set; } = string.Empty;
        public string Pokemon5 { get; set; } = string.Empty;
        public string Pokemon6 { get; set; } = string.Empty;


    }
}
