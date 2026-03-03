namespace ZoltanMMA.Infrastructure.ExternalApis.ApiSportsMma.Dtos.Fights
{
    public class ApiFightDto
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string? Time { get; set; }
        public long Timestamp { get; set; }
        public string? Timezone { get; set; }
        public string? Slug { get; set; }
        public bool Is_Main { get; set; }
        public string? Category { get; set; }
        public ApiFightStatusDto? Status { get; set; }
        public ApiFightFightersDto? Fighters { get; set; }
    }
}
