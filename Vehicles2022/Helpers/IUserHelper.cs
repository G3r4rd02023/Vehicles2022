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

        Task<IdentityResult> UpdateUserAsync(User user);

        Task<IdentityResult> ChangePasswordAsync(User user, string oldPassword, string newPassword);

        Task<bool> IsUserInRoleAsync(User user, string roleName);

        Task<User> GetUserAsync(Guid id);

        Task<IdentityResult> DeleteUserAsync(User user);

    }
}
