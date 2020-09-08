using Models.EFCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BAB.Repository.Interfaces
{
    public interface IUserRepository
    {
        Task<IEnumerable<Users>> GetAllUsers();

    }
}
