﻿using Domain.Entities;
using Domain.ValueObjects;

namespace Infrastructure.DataAccess.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IMSSqlConnectionFactory _connectionFactory;

        public UserRepository(IMSSqlConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public Task<UserId> Add(User user)
        {
            throw new NotImplementedException();
        }

        public Task Delete(UserId userId)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUser(UserId userId)
        {
            throw new NotImplementedException();
        }

        public Task Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}
