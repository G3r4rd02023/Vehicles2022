using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vehicles2022.Data.Entities;
using Vehicles2022.Enums;
using Vehicles2022.Models;

namespace Vehicles2022.Helpers
{
    public interface IUserHelper
    {
        Task<SignInResult> LoginAsync(LoginViewModel model);

        Task LogoutAsync();

        Task<User> GetUserAsync(string email);

        Task<IdentityResult> AddUserAsync(User user, string password);

        Task AddUserToRoleAsync(User user, string roleName);

        Task CheckRoleAsync(string roleName);

        Task<User> AddUserAsync(AddUserViewModel model, string imageUrl, UserType userType);
    }
}
