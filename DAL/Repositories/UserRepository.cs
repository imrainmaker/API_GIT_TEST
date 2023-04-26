using DAL.Context;
using DAL.Interfaces;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _context;

        public UserRepository(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<User> GetAll()
        {
            return _context.users.ToList();
        }
        public User? GetById(int id)
        {
            try
            {

                return  _context.users.Find(id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        public User? GetByEmail(string email)
        {
            try
            {

                return _context.users.First(u => u.Email == email);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
         public User? Add(User user)
        {
            throw new NotImplementedException();
        }
        public User? UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
        public bool Delete(User user)
        {
            throw new NotImplementedException();
        }
    }
}
