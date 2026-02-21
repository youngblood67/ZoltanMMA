using ZoltanMMA.Domain.Entities;
using ZoltanMMA.Domain.ValueObjects.Identifiers;

namespace ZoltanMMA.Application.Abstractions.Persistence
{
    public interface IFighterRepository
    {
        Task<Fighter?> GetByIdAsync(FighterId id);
        Task AddAsync(Fighter fighter);
    }
}
