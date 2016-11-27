using HackathonVZ.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Models.Models;
using Repository.Interface;
using Service.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Service.Implementation
{
    public class UserService : IUserService
    {
        #region Fields

        private IUserRepository _userRepository;
        private IEmailSender _emailService;
        private ISmsSender _smsService;

        #endregion Fields

        #region Constructor

        public UserService(IUserRepository userRepository, IEmailSender emailService, ISmsSender smsService)
        {
            _userRepository = userRepository;
            _emailService = emailService;
            _smsService = smsService;
        }

        #endregion Constructor

        #region Methods

        public async Task<ApplicationUser> GetUserByIdAsync(string userId)
        {
            return await _userRepository.GetUserByIdAsync(userId);
        }

        public ApplicationUser GetUserById(string userId)
        {
            return _userRepository.GetUserById(userId);
        }

        public List<ApplicationUser> GetUsers()
        {
            return _userRepository.GetUsers();
        }

        public async Task<List<ApplicationUser>> GetUsersAsync()
        {
            return await _userRepository.GetUsersAsync();
        }

        public async Task<List<ApplicationUser>> GetAllUsersPagedAsync(int pageSize, int pageNum, string filter)
        {
            return await _userRepository.GetAllUsersPagedAsync(pageSize, pageNum, filter);
        }

        public async Task<bool> UpdateUserAsync(ApplicationUser user)
        {
            return await _userRepository.UpdateUserAsync(user);
        }

        public async Task<bool> ArchiveUserAsync(string userId)
        {
            return await _userRepository.ArchiveUserAsync(userId);
        }

        public async Task<bool> ActivateUserAsync(string userId)
        {
            return await _userRepository.ActivateUserAsync(userId);
        }

        public async Task<List<IdentityRole>> GetAllRolesAsync()
        {
            return await _userRepository.GetAllRolesAsync();
        }

        public List<IdentityRole> GetAllRoles()
        {
            return _userRepository.GetAllRoles();
        }

        public async Task<IdentityRole> GetRoleByIdAsync(string roleId)
        {
            return await _userRepository.GetRoleByIdAsync(roleId);
        }

        public async Task<IdentityRole> GetRoleByNameAsync(string roleName)
        {
            return await _userRepository.GetRoleByNameAsync(roleName);
        }

        public IdentityRole GetRoleById(string roleId)
        {
            return _userRepository.GetRoleById(roleId);
        }

        public async Task<IdentityResult> AddUserToRoleAsync(string userId, string roleName)
        {
            return await _userRepository.AddUserToRoleAsync(userId, roleName);
        }

        public async Task<IdentityResult> RemoveUserFromRoleAsync(string userId, string roleName)
        {
            return await _userRepository.RemoveUserFromRoleAsync(userId, roleName);
        }

        public async Task<int> GetUserCountAsync()
        {
            return await _userRepository.GetUserCountAsync();
        }

        public async Task<Team> FindTeamByNameAsync(string teamName)
        {
            return await _userRepository.FindTeamByNameAsync(teamName);
        }

        public async Task<int> GetTeamMemberCount(long teamId)
        {
            return await _userRepository.GetTeamMemberCount(teamId);
        }

        public async Task<bool> JoinTeamAsync(long teamId, string userId)
        {
            return await _userRepository.JoinTeamAsync(teamId, userId);
        }

        public async Task<List<Team>> GetAllTeamsAsync()
        {
            return await _userRepository.GetAllTeamsAsync();
        }

        public async Task<List<TeamMember>> GetAllTeamMembersAsync(long teamId)
        {
            return await _userRepository.GetAllTeamMembersAsync(teamId);
        }

        #endregion Methods
    }
}