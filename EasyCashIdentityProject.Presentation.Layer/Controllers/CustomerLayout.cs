using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentityProject.Presentation.Layer.Controllers
{
    public class CustomerLayout : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
