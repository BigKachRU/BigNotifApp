using BigNotifApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BigNotifApp
{
    public class UserService
    {
        private readonly UserRepository _userRepository;
        public UserService()
        {
            _userRepository = new UserRepository();
        }

        public async Task<List<User>> GetUsers()
        {
            return await _userRepository.GetUsers();
        }
    }
}