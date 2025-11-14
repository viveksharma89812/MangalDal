using Microsoft.AspNetCore.Mvc;

namespace MangalDal.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
