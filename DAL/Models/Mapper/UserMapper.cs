using DAL.Models.DTO;
using DAL.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models.Mapper
{
    public static class UserMapper
    {
        public static User ToUser(this AddUserDTO addUser)
        {
            return new User
            {
                Email = addUser.Email,
                Password = addUser.Password,
                FirstName = addUser.FirstName,
                LastName = addUser.LastName

            };
        }

        public static UserVM ToUserVM(this User user)
        {
            if (user is not null)
            {
                return new UserVM
                {
                    Id = user.Id,
                    Email = user.Email,
                    LastName = user.LastName,
                    FirstName = user.FirstName,

                };
            }
            return null;

        }

        public static List<UserVM> ToUserVMList(this IEnumerable<User> user)
        {
            List<UserVM> UserVMList = new List<UserVM>();

            foreach (User u in user)
            {
                UserVMList.Add(u.ToUserVM());
            }

            return UserVMList;
        }
    }
}
