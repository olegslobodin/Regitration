using System.Web.Mvc;
using Microsoft.Web.Mvc;
using Regitration.CustomAttributes;
using Regitration.ViewModels;

namespace Regitration.Controllers
{
    public class WizardController : Controller
    {
        public ActionResult Index()
        {
            var wizard = new WizardViewModel();
            wizard.Initialize();
            return View(wizard);
        }
        
        [HttpPost]
        public ActionResult Index([Deserialize]WizardViewModel wizard, IStepViewModel step)
        {
            wizard.Steps[wizard.CurrentStepIndex] = step;
            if (ModelState.IsValid)
            {
                if (!string.IsNullOrEmpty(Request["next"]))
                {
                    wizard.CurrentStepIndex++;
                }
                else if (!string.IsNullOrEmpty(Request["prev"]))
                {
                    wizard.CurrentStepIndex--;
                }
                else return View("RegistrationCompleted");
            }
            else if (!string.IsNullOrEmpty(Request["prev"]))
            {
                wizard.CurrentStepIndex--;
            }
            return View(wizard);
        }
    }
}