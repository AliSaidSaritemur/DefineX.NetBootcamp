using AjaxOdev.Data;
using AjaxOdev.Models;
using AjaxOdev.Services;
using Microsoft.EntityFrameworkCore;
using System.Net.Http;

namespace AjaxOdev.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;
        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
           
        }

        public void Add(User user)
        {
            Console.WriteLine("Add'e girdi / UserRepository");
            Console.WriteLine($"Ad:{user.Name}    Soyad :{user.Surname} ");
            _context.Users.Add(user);
            Save();
        }

        public void Delete(int id)
        {
            var product = _context.Users.Find(id);
            if (product != null)
            {
                _context.Users.Remove(product);
                Save();
            }
        }

        public IEnumerable<User> GetAll()
        {
         //   return _context.Users.ToList();
            return null;
        }

        public User GetById(int id)
        {
            return _context.Users.Find(id);
        }

        public List<User> GetByNamewithKey(string key)
        {
            var users = _context.Users
                .Where(u => u.Name.ToLower().Contains(key.ToLower()) ||
                            u.Surname.ToLower().Contains(key.ToLower()))
                .ToList();

            return users.Any() ? users : null;

        }


        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
