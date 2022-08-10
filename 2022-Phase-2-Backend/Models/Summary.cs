namespace _2022_Phase_2_Backend.Models
{
    public class Summary
    {
        public int TotalAttack { get; set; }
        public int TotalDefense { get; set; }
        public int TotalSpeed { get; set; }
        public string TypesStrongAgainst { get; set; } = string.Empty;
        public string TypesWeakAgainst { get; set; } = string.Empty;
        public int StrengthScore { get; set; }




    }
}
