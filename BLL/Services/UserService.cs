using BLL.Interfaces;
using DAL.Interfaces;
using DAL.Models;
using DAL.Models.DTO;
using DAL.Models.Mapper;
using DAL.Models.ViewModel;
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

        public IEnumerable<UserVM> GetAll()
        {

            return  _userRepository.GetAll().ToUserVMList();

        }
        public UserVM? GetById(int id)
        {
            User? user = _userRepository.GetById(id);
            return user is not null ? user.ToUserVM() : null;
        }
        public UserVM? GetByEmail(string email)
        {
            User? user = _userRepository.GetByEmail(email);
            return user is not null ? user.ToUserVM() : null;
        }
        public UserVM? Add(AddUserDTO user)
        {
            User? userAdd = _userRepository.Add(user.ToUser());
            return userAdd is not null ? userAdd.ToUserVM() : null;
        }
        public UserVM? UpdateUser(UpdateUserDTO user,int id)
        {
            User? userUpdate = _userRepository.GetById(id);
            if(userUpdate is not null)
            {
                userUpdate.Email = user.Email;
                userUpdate.FirstName = user.FirstName;
                userUpdate.LastName = user.LastName;
                userUpdate.Password = user.Password;

                _userRepository.UpdateUser(userUpdate);
            }
            return userUpdate is not null ? userUpdate.ToUserVM() : null;
        }
        public bool Delete(int id)
        {
            User? user = _userRepository.GetById(id);
            return user is not null ? _userRepository.Delete(user) : false;
        }
    }
}
