using ZoltanMMA.Infrastructure.ExternalApis.ApiSportsMma.Dtos.Fighters;
using ZoltanMMA.Infrastructure.ExternalApis.ApiSportsMma.Dtos.Fights;
using ZoltanMMA.Infrastructure.ExternalApis.ApiSportsMma.Dtos.Results;
using ZoltanMMA.Infrastructure.ExternalApis.ApiSportsMma.Dtos.Statistics;
using ZoltanMMA.Infrastructure.ExternalApis.ApiSportsMma.Dtos.Teams;

namespace ZoltanMMA.Infrastructure.ExternalApis.ApiSportsMma
{
    public interface IApiSportsClient
    {
        Task<List<ApiFightDto>> GetFightsByDateAsync(DateTime date);

        Task<List<ApiFighterRecordDto>> GetFighterRecordAsync(int fighterId);

        Task<List<ApiFightResultDto>> GetFightResultsAsync(string ids);

        Task<List<ApiFightStatisticsDto>> GetFightStatisticsAsync(int fightId);

        Task<List<ApiTeamDto>> GetTeamsAsync();
    }
}
