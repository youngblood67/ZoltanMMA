namespace ZoltanMMA.Infrastructure.ExternalApis.ApiSportsMma.Dtos.Statistics
{
    public class ApiStrikesDto
    {
        public ApiStrikeTotalDto? Total { get; set; }
        public ApiStrikePowerDto? Power { get; set; }
        public ApiTakedownDto? Takedowns { get; set; }
        public int Submissions { get; set; }
        public string? Control_Time { get; set; }
        public int Knockdowns { get; set; }
    }
}