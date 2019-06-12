using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DynamicDashboard.Controllers
{
    [Authorize] 
    [Route("[controller]/[action]")]
    public class MenuMasterController : Controller
    {

    }
}
