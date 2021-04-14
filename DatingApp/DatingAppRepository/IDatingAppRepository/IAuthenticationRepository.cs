using DatingAppRepository.DataModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DatingAppRepository.IDatingAppRepository
{
    public interface IAuthenticationRepository
    {
        Task<bool> Login();
        Task<User> Register();
        Task<bool> ChangePassword();
    }
}
