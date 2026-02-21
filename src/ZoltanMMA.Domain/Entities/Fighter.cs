using ZoltanMMA.Domain.Enums;
using ZoltanMMA.Domain.Exceptions;
using ZoltanMMA.Domain.ValueObjects.Identifiers;

namespace ZoltanMMA.Domain.Entities
{
    public class Fighter
    {
        public FighterId Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public DateTime DateOfBirth { get; private set; }
        public string Nationality { get; private set; }
        public WeightClasses WeightClass { get; private set; }
        public int Wins { get; private set; }
        public int Losses { get; private set; }
        public int Draws { get; private set; }

        public Fighter(FighterId id, string firstname, string lastname, DateTime dateOfBirth, string nationality, WeightClasses weightClass)
        {
            if (string.IsNullOrWhiteSpace(firstname))
                throw new DomainException("First name is required.");

            if (string.IsNullOrWhiteSpace(lastname))
                throw new DomainException("Last name is required.");

            if (dateOfBirth > DateTime.UtcNow)
                throw new DomainException("Date of birth cannot be in the future.");

            Id = id;
            FirstName = firstname;
            LastName = lastname;
            DateOfBirth = dateOfBirth;
            Nationality = nationality;
            WeightClass = weightClass;

            Wins = 0;
            Losses = 0;
            Draws = 0;
        }

        public void RegisterWin()
        {
            Wins++;
        }

        public void RegisterLoss()
        {
            Losses++;
        }

        public void RegisterDraw()
        {
            Draws++;
        }

        public void ChangeWeightClass(WeightClasses newWeightClass)
        {
            WeightClass = newWeightClass;
        }
    }
}