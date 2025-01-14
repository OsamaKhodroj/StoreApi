using CompanyX.Store.Domains.Entites;

namespace CompanyX.Store.Domains.Interfaces
{
    public interface IUser
    {
        Task<UserStatus> Add(User user);
        Task<UserStatus> Update(User user);
        Task<UserStatus> Delete(int id);
        Task<User> GetById(int id);
        Task<List<User>> GetAll();
    }
}
