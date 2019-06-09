using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DynamicDashboard.Data;
using DynamicDashboard.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace DynamicDashboard.Services
{
    public class MenuMasterService:IMenuMasterService
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public MenuMasterService(ApplicationDbContext dbContext, IHttpContextAccessor httpContextAccessor)
        {
            _dbContext = dbContext;
            _httpContextAccessor = httpContextAccessor;
        }

        public IEnumerable<MenuMaster> GetMenuMaster()
        {
            return _dbContext.MenuMaster.AsEnumerable();

        }

        public IEnumerable<MenuMaster> GetUserMenuMaster()
        {
            
           var result = _dbContext.MenuMaster.Where(m => _httpContextAccessor.HttpContext.User.IsInRole(m.UserRole)).ToList();
            return result;
        }
    }
}
