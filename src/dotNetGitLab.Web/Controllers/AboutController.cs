using System.Web.Mvc;

namespace dotNetGitLab.Web.Controllers
{
    public class AboutController : dotNetGitLabControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}