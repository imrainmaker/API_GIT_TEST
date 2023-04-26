using DAL.Models;
using DAL.Models.DTO;
using DAL.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IUserService
    {
        public IEnumerable<UserVM> GetAll();

        public UserVM? GetById(int id);

        public UserVM? GetByEmail(string email);

        public UserVM? Add(AddUserDTO user);

        public UserVM? UpdateUser(UpdateUserDTO user, int id);

        public bool Delete(int id);
    }
}
