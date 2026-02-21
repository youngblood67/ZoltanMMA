namespace ZoltanMMA.Domain.ValueObjects.Identifiers
{
    public readonly struct FighterId
    {
        public int Value { get; }
        public FighterId(int value)
        {
            if (value <= 0)
                throw new ArgumentException("FighterId must be a positive integer.", nameof(value));
            Value = value;
        }

        public override string ToString() => Value.ToString();
    }
}
