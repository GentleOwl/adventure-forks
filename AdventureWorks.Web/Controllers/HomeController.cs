using System.Configuration;
using System.Web.Mvc;

namespace AdventureWorks.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.ApplicationName = ConfigurationManager.AppSettings["ApplicationName"];

            return View();
        }
    }
}