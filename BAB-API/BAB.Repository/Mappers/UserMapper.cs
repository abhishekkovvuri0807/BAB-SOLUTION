using Models.EFCore;
using Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BAB.Repository.Mappers
{
    public static class UserMapper
    {
        public static UsersDTO ToUsersDTO(this Users user)
        {
            UsersDTO usersDTO = new UsersDTO();
            usersDTO.Id = user.Id;
            usersDTO.FirstName = user.FirstName;
            usersDTO.FirstName = user.FirstName;
            usersDTO.FirstName = user.FirstName;
            usersDTO.FirstName = user.FirstName;
            usersDTO.FirstName = user.FirstName;
            usersDTO.FirstName = user.FirstName;
            return usersDTO;
        }

        public static List<UsersDTO> ToUsersDTOList(this IEnumerable<Users> users)
        {
            List<UsersDTO> usersDTO = new List<UsersDTO>();
            foreach (Users user in users)
            {
                usersDTO.Add(user.ToUsersDTO());
            }
            return usersDTO;
        }
    }
}
