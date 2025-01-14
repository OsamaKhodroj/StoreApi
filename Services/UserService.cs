using CompanyX.Store.Domains.Entites;
using CompanyX.Store.Domains.Interfaces;
using Microsoft.EntityFrameworkCore;
using Services;

namespace CompanyX.Store.Services
{
    public class UserService : IUser
    {
        private readonly StoreDbContext _dbContext;

        public UserService(StoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        /// <summary>
        /// This method to add new user info and check if already exists
        /// </summary>
        /// <param name="user">Set user object</param>
        /// <returns>return exist if the user already exists otherwisw return active</returns>
        public async Task<UserStatus> Add(User user)
        {
            try
            {
                var checkIfUserExists = await _dbContext.Users
                        .AnyAsync(q => q.EmailAddress == user.EmailAddress ||
                                        q.PhoneNumber == user.PhoneNumber &&
                                        q.UserStatus == UserStatus.Active);

                if (checkIfUserExists)
                {
                    return UserStatus.Exists;
                }
                else
                {
                    _dbContext.Users.Add(user);
                    await _dbContext.SaveChangesAsync();
                    return UserStatus.Active;
                }
            }
            catch (Exception)
            {
                return UserStatus.Error;
            }
        }

        /// <summary>
        /// To delete register user
        /// </summary>
        /// <param name="id">Set user id </param>
        /// <returns></returns> 
        public async Task<UserStatus> Delete(int id)
        {
            try
            {
                var user = await _dbContext.Users.Where(q => q.Id == id).FirstOrDefaultAsync();
                if (user != null)
                {
                    _dbContext.Users.Remove(user);
                    await _dbContext.SaveChangesAsync();
                    return UserStatus.Sucess;
                }
                return UserStatus.Error;
            }
            catch (Exception)
            {
                return UserStatus.Error;
            }
        }

        /// <summary>
        /// To return all users
        /// </summary>
        /// <returns>return List of users</returns>
        public async Task<List<User>> GetAll()
        {
            try
            {
                var result = await _dbContext.Users.ToListAsync();
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Return User info by user Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<User> GetById(int id)
        {
            try
            {
                var user = await _dbContext.Users.FirstOrDefaultAsync(q => q.Id == id);
                return user;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// To Update Existing user
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task<UserStatus> Update(User user)
        {
            try
            {
                _dbContext.Users.Update(user);
                await _dbContext.SaveChangesAsync();
                return UserStatus.Sucess;
            }
            catch (Exception)
            {
                return UserStatus.Error;
            }
        }
    }
}
