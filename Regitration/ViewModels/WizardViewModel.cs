using System;
using System.Collections.Generic;
using System.Linq;

namespace Regitration.ViewModels
{
    [Serializable]
    public class WizardViewModel
    {
        public List<IStepViewModel> Steps;

        public int CurrentStepIndex;

        public void Initialize()
        {
            Steps =
                typeof (IStepViewModel).Assembly.GetTypes()
                    .Where(t => !t.IsAbstract && typeof (IStepViewModel).IsAssignableFrom(t))
                    .Select(t => (IStepViewModel) Activator.CreateInstance(t))
                    .ToList();
        }
    }
}