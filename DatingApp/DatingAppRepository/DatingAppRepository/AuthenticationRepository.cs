using DatingAppRepository.DataModels;
using DatingAppRepository.IDatingAppRepository;
using System.Threading.Tasks;

namespace DatingAppRepository.DatingAppRepository
{
    public class AuthenticationRepository : IAuthenticationRepository
    {
        private readonly DatingAppDbContext _dbContext;
        public AuthenticationRepository(DatingAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Task<bool> ChangePassword()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Task<bool> Login()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<User> Register(User userData)
        {
            await _dbContext.AddAsync(userData);
            await _dbContext.SaveChangesAsync();

            return userData;
        }
    }
}
