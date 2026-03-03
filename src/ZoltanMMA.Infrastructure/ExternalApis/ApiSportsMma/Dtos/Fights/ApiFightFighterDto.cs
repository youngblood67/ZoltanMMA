namespace ZoltanMMA.Infrastructure.ExternalApis.ApiSportsMma.Dtos.Fights
{
    public class ApiFightFighterDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Logo { get; set; }
        public bool Winner { get; set; }
    }
}