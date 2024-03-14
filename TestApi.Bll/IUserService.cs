using TestApi.DAL;

namespace TestApi.Bll
{
    public interface IUserService
    {
        List<User> GetAll();

        User GetById(int id);
    }
}
