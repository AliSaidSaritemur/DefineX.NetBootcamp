using AjaxOdev.Models;

namespace AjaxOdev.Repository
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAll();
        User GetById(int id);
        void Add(User user);
        void Delete(int id);
        void Save();
        public List<User> GetByNamewithKey(string key);
    }
}
