using Microsoft.AspNetCore.Mvc; 

namespace Mobile_Redirection_Subfolder.Controllers
{
    public class HomeController : Controller
    {
        [MobileRedirect]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult OnlyDesktop()
        {
            return View();
        }

    }
}
