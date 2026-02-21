namespace ZoltanMMA.Application.ReadModels.Fighters
{
    public record FighterDetailsReadModel(   
        int Id,
        string FirstName,
        string LastName,
        string Nationality,
        string WeightClass,
        int Wins,
        int Losses,
        int draws,
        double WinRate
    );
}
