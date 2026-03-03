using System.Text.Json;
using ZoltanMMA.Infrastructure.ExternalApis.ApiSportsMma.Dtos.Common;
using ZoltanMMA.Infrastructure.ExternalApis.ApiSportsMma.Dtos.Fighters;
using ZoltanMMA.Infrastructure.ExternalApis.ApiSportsMma.Dtos.Fights;
using ZoltanMMA.Infrastructure.ExternalApis.ApiSportsMma.Dtos.Results;
using ZoltanMMA.Infrastructure.ExternalApis.ApiSportsMma.Dtos.Statistics;
using ZoltanMMA.Infrastructure.ExternalApis.ApiSportsMma.Dtos.Teams;

namespace ZoltanMMA.Infrastructure.ExternalApis.ApiSportsMma
{
    public class ApiSportsClient : IApiSportsClient
    {
        private readonly HttpClient _httpClient;
        private readonly JsonSerializerOptions _jsonSerializerOptions;

        public ApiSportsClient(HttpClient httpClient)
        {
            _httpClient = httpClient;

            _jsonSerializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                PropertyNameCaseInsensitive = true
            };

        }

        private async Task<List<T>> GetAsync<T>(string endpoint)
        {
            var response = await _httpClient.GetAsync(endpoint);
            
            response.EnsureSuccessStatusCode();
            
            var json = await response.Content.ReadAsStringAsync();
            
            var apiResponse = JsonSerializer.Deserialize<ApiSportsResponse<T>>(json, _jsonSerializerOptions);
            
            if(apiResponse == null)
                return new List<T>();

            if (apiResponse.Errors != null && apiResponse.Errors.Count > 0)
                throw new Exception(string.Join(", ", apiResponse.Errors));

            return apiResponse.Response;

        }

        public Task<List<ApiFighterRecordDto>> GetFighterRecordAsync(int fighterId)
        {
            return GetAsync<ApiFighterRecordDto>($"fighters/record?id={fighterId}");
        }

        public Task<List<ApiFightResultDto>> GetFightResultsAsync(string ids)
        {
            return GetAsync<ApiFightResultDto>($"fights/results?ids={ids}");
        }

        public Task<List<ApiFightDto>> GetFightsByDateAsync(DateTime date)
        {
            return GetAsync<ApiFightDto>($"fights?date={date:yyyy-MM-dd}");
        }

        public Task<List<ApiFightStatisticsDto>> GetFightStatisticsAsync(int fightId)
        {
            return GetAsync<ApiFightStatisticsDto>($"fights/statistics/fighters?id={fightId}");
        }

        public Task<List<ApiTeamDto>> GetTeamsAsync()
        {
            return GetAsync<ApiTeamDto>("teams");
        }
    }
}
