using HackathonVZ.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Models.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repository.Interface
{
    public interface IUserRepository
    {
        #region Methods

        Task<ApplicationUser> GetUserByIdAsync(string userId);

        ApplicationUser GetUserById(string userId);

        List<ApplicationUser> GetUsers();

        Task<List<ApplicationUser>> GetUsersAsync();

        Task<List<ApplicationUser>> GetAllUsersPagedAsync(int pageSize, int pageNum, string filter);

        Task<bool> UpdateUserAsync(ApplicationUser user);

        Task<bool> ArchiveUserAsync(string userId);

        Task<bool> ActivateUserAsync(string userId);

        Task<List<IdentityRole>> GetAllRolesAsync();

        List<IdentityRole> GetAllRoles();

        Task<IdentityRole> GetRoleByIdAsync(string roleId);

        Task<IdentityRole> GetRoleByNameAsync(string roleName);

        IdentityRole GetRoleById(string roleId);

        Task<IdentityResult> AddUserToRoleAsync(string userId, string roleName);

        Task<IdentityResult> RemoveUserFromRoleAsync(string userId, string roleName);

        Task<int> GetUserCountAsync();

        Task<Team> FindTeamByNameAsync(string teamName);

        Task<int> GetTeamMemberCount(long teamId);

        Task<bool> JoinTeamAsync(long teamId, string userId);

        Task<List<Team>> GetAllTeamsAsync();

        Task<List<TeamMember>> GetAllTeamMembersAsync(long teamId);

        #endregion Methods
    }
}