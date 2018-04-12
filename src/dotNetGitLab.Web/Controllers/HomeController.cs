using System.Web.Mvc;

namespace dotNetGitLab.Web.Controllers
{
    public class HomeController : dotNetGitLabControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}