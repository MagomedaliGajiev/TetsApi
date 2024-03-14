using TestApi.DAL;

namespace TestApi.Bll
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public List<User> GetAll()
        {
            return _userRepository.GetAll();
        }

        public User GetById(int id)
        {
            var user = _userRepository.Get(id);
            user.Id++;
            return user;
        }
    }
}
