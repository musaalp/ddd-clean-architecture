namespace Domain.ValueObjects
{
    public readonly struct UserId : EntityId<Guid>
    {
        public UserId(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; }
    }
}
