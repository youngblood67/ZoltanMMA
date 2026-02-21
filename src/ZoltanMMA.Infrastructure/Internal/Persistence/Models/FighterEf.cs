namespace ZoltanMMA.Infrastructure.Internal.Persistence.Models
{
    public class FighterEf
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public DateTime DateOfBirth { get; set; }
        public string Nationality { get; set; } = null!;
        public int WeightClass { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int Draws { get; set; }
    }
}
