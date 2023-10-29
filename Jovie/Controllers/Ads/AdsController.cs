using Microsoft.AspNetCore.Mvc;

namespace Jovie.Controllers.Ads
{
    public class AdsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
