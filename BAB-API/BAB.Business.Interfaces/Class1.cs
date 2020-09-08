using Models.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BAB.Business.Interfaces
{
    public interface IUserBusiness
    {
        Task<IEnumerable<UsersDTO>> GetAllUsers();
    }
}
