using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DynamicDashboard.Core.Entities;

namespace DynamicDashboard.Core.Interfaces
{
    public interface IMenuMasterService
    {
        Task<IEnumerable<MenuMaster>> GetMenuMaster();
        Task<IEnumerable<MenuMaster>> GetUserMenuMaster();
    }
}
