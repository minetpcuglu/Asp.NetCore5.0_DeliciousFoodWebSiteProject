using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCore5._0_DeliciousFoodWebSiteProject.Controllers
{
    [AllowAnonymous]
    public class ShowcaseController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CategoryDetail() //ürüne göre category getirme
        {
            return View();
        }
    }
}
