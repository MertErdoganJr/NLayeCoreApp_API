using Microsoft.AspNetCore.Mvc;

namespace NLayer.Web.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
