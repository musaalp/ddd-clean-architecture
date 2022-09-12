using System;

namespace Domain.Entities
{
    internal class User
    {
        public User(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }

        public static User CreateNew(string name)
        {
            if (!string.IsNullOrEmpty(name))
                throw new ArgumentNullException(nameof(name));

            return new User(name);
        }
    }
}
