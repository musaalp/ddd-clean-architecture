namespace Domain.ValueObjects
{
    public interface EntityId<T>
    {
        T Id { get; }
    }
}
