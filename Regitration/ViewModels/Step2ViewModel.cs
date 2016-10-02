using System;
using System.Collections.Generic;
using Regitration.CustomAttributes;

namespace Regitration.ViewModels
{
    [Serializable]
    public class Step2ViewModel : IStepViewModel
    {
        public void Initialize()
        {
            if (BusinessAreas != null) return;
            var areasNames = new List<string>
            {
                "IT",
                "Administrative",
                "Customer service",
                "Sales",
                "Programming",
                "Research",
                "Human resources",
                "Ad Sales",
                "Operations / Engineer",
                "Legal",
                "Finance",
                "Public Affairs",
                "Marketing"
            };
            BusinessAreas = new List<BusinessArea>();
            for (var i = 0; i < areasNames.Count; i++)
                BusinessAreas.Add(new BusinessArea { Id = i, Name = areasNames[i], IsChecked = false });
        }

        private const string STitle = "Business Area";

        public string StepTitle => STitle;

        [AtLeastOneAreaSelected(ErrorMessage = "Please select your personal business area.")]
        public List<BusinessArea> BusinessAreas { get; set; }
    }
}