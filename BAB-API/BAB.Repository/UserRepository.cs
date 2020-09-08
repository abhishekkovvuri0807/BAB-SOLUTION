using BAB.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using Models.EFCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BAB.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly BreakABillContext _dbContext;

        public UserRepository(BreakABillContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IEnumerable<Users>> GetAllUsers()
        {
            return await _dbContext.Users.ToListAsync();
        }

    }
}
