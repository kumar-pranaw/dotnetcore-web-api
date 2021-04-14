using DatingAppRepository.IDatingAppRepository;
using DatingAppServices.IDatingAppServices;

namespace DatingAppServices.DatingAppServices
{
    public class AuthService : IAuthService
    {
        private readonly IAuthenticationRepository _repo;
        public AuthService(IAuthenticationRepository repo)
        {
            _repo = repo;
        }
    }
}
