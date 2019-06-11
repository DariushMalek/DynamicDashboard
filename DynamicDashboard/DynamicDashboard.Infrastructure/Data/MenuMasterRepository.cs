using System;
using System.Collections.Generic;
using System.Text;
using DynamicDashboard.Core.Entities;
using DynamicDashboard.Core.Interfaces;

namespace DynamicDashboard.Infrastructure.Data
{
    public class MenuMasterRepository:EfRepository<MenuMaster>, IMenuMasterRepository
    {
        public MenuMasterRepository(ApplicationDbContext dbContext):base(dbContext)
        {
            
        }
    }
}
