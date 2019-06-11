using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DynamicDashboard.Core.Entities;
using DynamicDashboard.Core.Interfaces;
using Microsoft.AspNetCore.Http;

namespace DynamicDashboard.Core.Services
{
    public class MenuMasterService : IMenuMasterService
    {
        private readonly IAsyncRepository<MenuMaster> _menuMasterRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public MenuMasterService(IAsyncRepository<MenuMaster> menuMasterRepository,
            IHttpContextAccessor httpContextAccessor)
        {
            _menuMasterRepository = menuMasterRepository;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<IEnumerable<MenuMaster>> GetMenuMaster()
        {
            return (await _menuMasterRepository.ListAllAsync()).ToList();
        }

        public async Task<IEnumerable<MenuMaster>> GetUserMenuMaster()
        {
            var result = await _menuMasterRepository.ListAllAsync();
            return result.Where(m => _httpContextAccessor.HttpContext.User.IsInRole(m.UserRole)).ToList();
        }
    }
}
