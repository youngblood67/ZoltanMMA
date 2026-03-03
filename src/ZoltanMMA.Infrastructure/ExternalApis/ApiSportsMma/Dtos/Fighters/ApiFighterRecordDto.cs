namespace ZoltanMMA.Infrastructure.ExternalApis.ApiSportsMma.Dtos.Fighters
{
    public class ApiFighterRecordDto
    {
        public ApiRecordFighterDto? Fighter { get; set; }
        public ApiRecordTotalDto? Total { get; set; }
        public ApiRecordKoDto? Ko { get; set; }
        public ApiRecordSubDto? Sub { get; set; }
    }
}
