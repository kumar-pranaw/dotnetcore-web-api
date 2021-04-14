using DatingAppServices.Models;
using System.Threading.Tasks;

namespace DatingAppServices.IDatingAppServices
{
    public interface IAuthService
    {
        Task<UserModel> Register(UserModel user);
    }
}
