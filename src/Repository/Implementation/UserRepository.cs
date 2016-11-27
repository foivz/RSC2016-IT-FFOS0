using AutoMapper;
using HackathonVZ.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Models.Models;
using Repository.Interface;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository.Implementation
{
    public class UserRepository : IUserRepository
    {
        #region Fields

        private ApplicationDbContext _context;
        private UserManager<ApplicationUser> _userManager;

        #endregion Fields

        #region Constructor

        public UserRepository(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        #endregion Constructor

        #region Methods

        public async Task<ApplicationUser> GetUserByIdAsync(string userId)
        {
            var user = await _context.Users.Include(ur => ur.Roles).Where(u => u.Id == userId).SingleOrDefaultAsync();

            return Mapper.Map<ApplicationUser>(user);
        }

        public ApplicationUser GetUserById(string userId)
        {
            var user = _context.Users.Include(ur => ur.Roles).Where(u => u.Id == userId).SingleOrDefault();

            return Mapper.Map<ApplicationUser>(user);
        }

        public List<ApplicationUser> GetUsers()
        {
            var users = _context.Users.Include(ur => ur.Roles).ToList();

            return Mapper.Map<List<ApplicationUser>>(users);
        }

        public async Task<List<ApplicationUser>> GetUsersAsync()
        {
            var users = await _context.Users.ToListAsync();

            return Mapper.Map<List<ApplicationUser>>(users);
        }

        public async Task<List<ApplicationUser>> GetAllUsersPagedAsync(int pageSize, int pageNum, string filter)
        {
            string term = !string.IsNullOrEmpty(filter)
                ? filter.ToLower()
                : string.Empty;

            var query = _context.Users.AsQueryable();

            if (!string.IsNullOrWhiteSpace(filter))
            {
                if (filter.Count() == 1)
                {
                    query = query.Where(f => f.Name.ToLower().StartsWith(term));
                }
                else if (filter.Count() > 1)
                {
                    query = query.Where(
                        a =>
                        a.Name.Contains(term)
                    );
                }
            }

            var users = await query
                .OrderBy(o => o.Name)
                .Skip(pageSize * (pageNum - 1))
                .Take(pageSize)
                .ToListAsync();

            return Mapper.Map<List<ApplicationUser>>(users);
        }

        public async Task<bool> UpdateUserAsync(ApplicationUser user)
        {
            var dbUser = await _context.Users.Where(u => u.Id == user.Id).SingleOrDefaultAsync();

            _context.Users.Attach(dbUser);
            dbUser = user;
            _context.Entry(dbUser).State = EntityState.Modified;
            var saveResult = await _context.SaveChangesAsync();
            if (saveResult > 0)
            {
                return true;
            }
            return false;
        }

        public async Task<bool> ArchiveUserAsync(string userId)
        {
            var dbUser = await _context.Users.Where(u => u.Id == userId).SingleOrDefaultAsync();

            _context.Users.Attach(dbUser);
            dbUser.IsArchived = true;
            _context.Entry(dbUser).State = EntityState.Modified;
            var saveResult = await _context.SaveChangesAsync();
            if (saveResult > 0)
            {
                return true;
            }
            return false;
        }

        public async Task<bool> ActivateUserAsync(string userId)
        {
            var dbUser = await _context.Users.Where(u => u.Id == userId).SingleOrDefaultAsync();

            _context.Users.Attach(dbUser);
            dbUser.IsArchived = false;
            _context.Entry(dbUser).State = EntityState.Modified;
            var saveResult = await _context.SaveChangesAsync();
            if (saveResult > 0)
            {
                return true;
            }
            return false;
        }

        public async Task<List<IdentityRole>> GetAllRolesAsync()
        {
            var roles = await _context.Roles.Where(r => r.Name != "Admin").ToListAsync();
            return Mapper.Map<List<IdentityRole>>(roles);
        }

        public List<IdentityRole> GetAllRoles()
        {
            var roles = _context.Roles.Where(r => r.Name != "Admin").ToList();
            return Mapper.Map<List<IdentityRole>>(roles);
        }

        public async Task<IdentityRole> GetRoleByIdAsync(string roleId)
        {
            var role = await _context.Roles.Where(r => r.Id == roleId).SingleOrDefaultAsync();
            return Mapper.Map<IdentityRole>(role);
        }

        public async Task<IdentityRole> GetRoleByNameAsync(string roleName)
        {
            var role = await _context.Roles.Where(r => r.Name == roleName).SingleOrDefaultAsync();
            return Mapper.Map<IdentityRole>(role);
        }

        public IdentityRole GetRoleById(string roleId)
        {
            var role = _context.Roles.Where(r => r.Id == roleId).SingleOrDefault();
            return Mapper.Map<IdentityRole>(role);
        }

        public async Task<IdentityResult> AddUserToRoleAsync(string userId, string roleName)
        {
            var user = await _userManager.FindByIdAsync(userId);
            return await _userManager.AddToRoleAsync(user, roleName);
        }

        public async Task<IdentityResult> RemoveUserFromRoleAsync(string userId, string roleName)
        {
            var user = await _userManager.FindByIdAsync(userId);
            return await _userManager.RemoveFromRoleAsync(user, roleName);
        }

        public async Task<int> GetUserCountAsync()
        {
            return await _context.Users.CountAsync();
        }

        public async Task<Team> FindTeamByNameAsync(string teamName)
        {
            var team = await _context.Team.Where(t => t.Name == teamName).FirstOrDefaultAsync();
            return Mapper.Map<Team>(team);
        }

        public async Task<int> GetTeamMemberCount(long teamId)
        {
            var teamMemberCount = await _context.TeamMember.Where(t => t.Id == teamId).CountAsync();
            return teamMemberCount;
        }

        public async Task<bool> JoinTeamAsync(long teamId, string userId)
        {
            var joinTeam = await _context.TeamMember.AddAsync(new DAL.Models.TeamMember
            {
                TeamId = teamId,
                UserId = userId
            });

            var saveResult = await _context.SaveChangesAsync();
            if (saveResult > 0)
            {
                return true;
            }
            return false;
        }

        public async Task<List<Team>> GetAllTeamsAsync()
        {
            var teams = await _context.Team.ToListAsync();
            return Mapper.Map<List<Team>>(teams);
        }

        public async Task<List<TeamMember>> GetAllTeamMembersAsync(long teamId)
        {
            var teamMembers = await _context.TeamMember.Where(tm => tm.TeamId == teamId).ToListAsync();
            return Mapper.Map<List<TeamMember>>(teamMembers);
        }

        #endregion Methods
    }
}