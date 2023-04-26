using BLL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class UserService : IUserService
    {
        public IEnumerable<User> GetAll()
        {
            throw new NotImplementedException();
        }
        public User? GetById(int id)
        {
            throw new NotImplementedException();
        }
        public User? GetByEmail(string email)
        {
            throw new NotImplementedException();
        }
        public User? Add(User user)
        {
            throw new NotImplementedException();
        }
        public User? UpdateUser(int id)
        {
            throw new NotImplementedException();
        }
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
