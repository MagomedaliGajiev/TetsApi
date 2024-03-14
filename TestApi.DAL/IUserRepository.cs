namespace TestApi.DAL
{
    public interface IUserRepository
    {
        List<User> GetAll();

        User Get(int id);
    }
}
