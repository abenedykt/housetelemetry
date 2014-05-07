using System.Web.Mvc;

namespace HouseTelemetry.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}