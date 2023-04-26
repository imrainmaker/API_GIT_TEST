using BLL.Interfaces;
using DAL.Interfaces;
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
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IEnumerable<User> GetAll()
        {

            return  _userRepository.GetAll();

        }
        public User? GetById(int id)
        {
            User? user = _userRepository.GetById(id);
            return user is not null ? user : null;
        }
        public User? GetByEmail(string email)
        {
            User? user = _userRepository.GetByEmail(email);
            return user is not null ? user : null;
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
