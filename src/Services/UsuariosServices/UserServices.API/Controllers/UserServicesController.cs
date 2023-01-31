using Microsoft.AspNetCore.Mvc;

namespace UserServices.API.Controllers
{
    public class UserServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
