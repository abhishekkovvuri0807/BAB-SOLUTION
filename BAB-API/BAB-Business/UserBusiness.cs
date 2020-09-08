using BAB.Business.Interfaces;
using BAB.Repository.Interfaces;
using BAB.Repository.Mappers;
using Models.DTO;
using Models.EFCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BAB_Business
{
    public class UserBusiness : IUserBusiness
    {
        private readonly IUserRepository _userRepository;
        public UserBusiness(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<IEnumerable<UsersDTO>> GetAllUsers()
        {
            IEnumerable<Users> users = await _userRepository.GetAllUsers();
            return users.ToUsersDTOList();
        }
    }
}
