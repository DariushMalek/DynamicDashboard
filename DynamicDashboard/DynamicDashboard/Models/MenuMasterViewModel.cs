using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DynamicDashboard.Models
{
    public class MenuMasterViewModel
    {
        public string MenuName { get; set; }
        public string MenuTitle { get; set; }
        public string UserRole { get; set; }
        public int? ParentMenuId { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public string IconName { get; set; }
        public DateTime CreateDate { get; set; }
        public string UserId { get; set; }
        public short? Priority { get; set; }
        public bool IsHeading { get; set; }
        public string MenuClassContent { get; set; }
        public string HtmlAfterTitle { get; set; }
    }
}
