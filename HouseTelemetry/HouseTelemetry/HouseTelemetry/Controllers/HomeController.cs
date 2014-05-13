using System.Web.Mvc;
using HouseTelemetry.Abstract;

namespace HouseTelemetry.Controllers
{
    public class HomeController : Controller
    {
	    private readonly IHouseTelemetry _telemetry;

	    public HomeController(IHouseTelemetry telemetry)
	    {
		    _telemetry = telemetry;
	    }

	    public ActionResult Index()
        {
			return View(_telemetry.DailyStat());
        }
	}
}