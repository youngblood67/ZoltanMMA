using Microsoft.EntityFrameworkCore;
using ZoltanMMA.Application.Abstractions.Persistence;
using ZoltanMMA.Domain.Entities;
using ZoltanMMA.Domain.Enums;
using ZoltanMMA.Domain.ValueObjects.Identifiers;
using ZoltanMMA.Infrastructure.Internal.Persistence;
using ZoltanMMA.Infrastructure.Internal.Persistence.Models;

namespace ZoltanMMA.Infrastructure.Internal.Repositories
{
    public class FighterRepository : IFighterRepository
    {
        public readonly ZoltanMMAContext _context;

        public FighterRepository(ZoltanMMAContext context)
        {
            _context = context;
        }

        public async Task<Fighter?> GetByIdAsync(FighterId id)
        {
            var ef = await _context.Fighters.FirstOrDefaultAsync(f => f.Id == id.Value);
            if (ef is null)
                return null;

            return new Fighter(
                        new FighterId(ef.Id),
                        ef.FirstName,
                        ef.LastName,
                        ef.DateOfBirth,
                        ef.Nationality,
                        (WeightClasses)ef.WeightClass
                    );
        }

        public async Task AddAsync(Fighter fighter)
        {
            var ef = new FighterEf
            {
                Id = fighter.Id.Value,
                FirstName = fighter.FirstName,
                LastName = fighter.LastName,
                DateOfBirth = fighter.DateOfBirth,
                Nationality = fighter.Nationality,
                WeightClass = (int)fighter.WeightClass,
                Wins = fighter.Wins,
                Losses = fighter.Losses,
                Draws = fighter.Draws
            };

            _context.Fighters.Add(ef);
            await _context.SaveChangesAsync();
        }
    }
}
