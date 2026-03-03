namespace ZoltanMMA.Infrastructure.ExternalApis.ApiSportsMma.Dtos.Common
{
    public class ApiSportsResponse<T>
    {
        public string? Get { get; set; }
        public Dictionary<string, string>? Parameters { get; set; }
        public List<string>? Errors { get; set; }
        public int Results { get; set; }
        public List<T> Response { get; set; } = new();
    }
}
