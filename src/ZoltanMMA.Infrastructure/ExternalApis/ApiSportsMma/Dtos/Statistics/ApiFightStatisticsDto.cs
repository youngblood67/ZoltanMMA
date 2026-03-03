using ZoltanMMA.Infrastructure.ExternalApis.ApiSportsMma.Dtos.Common;
using ZoltanMMA.Infrastructure.ExternalApis.ApiSportsMma.Dtos.Results;

namespace ZoltanMMA.Infrastructure.ExternalApis.ApiSportsMma.Dtos.Statistics
{
    public class ApiFightStatisticsDto
    {
        public ApiEntityReferenceDto? Fight { get; set; }
        public ApiEntityReferenceDto? Fighter { get; set; }
        public ApiStrikesDto? Strikes { get; set; }
    }
}
