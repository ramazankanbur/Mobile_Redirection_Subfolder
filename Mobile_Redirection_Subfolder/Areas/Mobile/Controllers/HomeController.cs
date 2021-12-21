using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mobile_Redirection_Subfolder.Areas.Mobile.Controllers
{
    [Area("Mobile")]
    [DesktopRedirect]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

      
    }
}
