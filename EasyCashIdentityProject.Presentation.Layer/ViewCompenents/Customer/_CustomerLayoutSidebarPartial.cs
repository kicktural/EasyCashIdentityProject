using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentityProject.Presentation.Layer.ViewCompenents.Customer
{
    public class _CustomerLayoutSidebarPartial : ViewComponent 
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
