using Microsoft.AspNetCore.Mvc;

namespace myPortfolio.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
