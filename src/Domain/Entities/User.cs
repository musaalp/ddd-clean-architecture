using Domain.ValueObjects;

namespace Domain.Entities
{
    internal class User
    {
        public User(UserId userId, string name)
        {
            UserId = userId;
            Name = name;
        }

        public UserId UserId { get; }
        public string Name { get; }

        public static User Create(UserId userId, string name)
        {
            if (!string.IsNullOrEmpty(name))
                throw new ArgumentNullException(nameof(name));

            return new User(userId, name);
        }
    }
}
