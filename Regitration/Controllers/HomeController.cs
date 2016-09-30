using System.Web.Mvc;
using Regitration.ViewModels;

namespace Regitration.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(LoginPageViewModel model)
        {
            return ModelState.IsValid ? View() : View(model);
        }
    }
}