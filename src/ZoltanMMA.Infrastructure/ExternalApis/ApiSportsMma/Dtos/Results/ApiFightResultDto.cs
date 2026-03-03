using ZoltanMMA.Infrastructure.ExternalApis.ApiSportsMma.Dtos.Common;

namespace ZoltanMMA.Infrastructure.ExternalApis.ApiSportsMma.Dtos.Results
{
    public class ApiFightResultDto
    {
        public ApiEntityReferenceDto? Fight { get; set; }
        public string? Won_Type { get; set; }
        public int Round { get; set; }
        public string? Minute { get; set; }
        public string? Ko_Type { get; set; }
        public string? Target { get; set; }
        public string? Sub_Type { get; set; }
        public List<string>? Score { get; set; }
    }
}
