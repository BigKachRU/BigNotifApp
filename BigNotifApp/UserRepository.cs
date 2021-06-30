using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BigNotifApp.Models;

namespace BigNotifApp
{
    public class UserRepository
    {
        private static List<User> _users;

        public UserRepository()
        {
            _users = new List<User>() { new User { ID = 1, Email = "misterBIG.mail.com", FirstName = "Aleksey", LastName = "Kachurin" } };
        }

        public async Task<List<User>> GetUsers()
        {
            return await Task.Run(() => _users);
        }

        public async Task<User> GetUser(int ID)
        {
            return await Task.Run(() => _users.FirstOrDefault(f => f.ID == ID));
        }
/*
        public async Task<User> AddUser(User user)
        {
            _users.Add(user);

            return;
        }
*/

    }
}