using ZoltanMMA.Domain.Entities;
using ZoltanMMA.Domain.ValueObjects.Identifiers;

namespace ZoltanMMA.Application.Abstractions.External
{
    public interface IFighterProvider
    {
        Task<Fighter> GetByIdAsync(FighterId fighterId);
    }
}
