using Microsoft.AspNetCore.Mvc;

namespace middleware_edit.Areas.Member.Controllers
{
    [Area("Member")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
