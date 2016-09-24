using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Regitration.ViewModels
{
    [Serializable]
    public class Step3ViewModel : IStepViewModel
    {
        public void Initialize()
        {
            if (Countries != null) return;
            var countriesNames = new List<string>
            {
                "American Samoa",
                "Bermuda",
                "Canada",
                "Japan",
                "Mexico",
                "Northern Mariana Islands",
                "Philippines",
                "Puerto Rico",
                "United States",
                "United States Minor Outlying Islands",
                "Virgin Islands (US)"
            };
            Countries = new List<CountryViewModel>();
            for (var i = 0; i < countriesNames.Count; i++)
                Countries.Add(new CountryViewModel { Id = i, Name = countriesNames[i] });
        }

        public List<CountryViewModel> Countries { get; private set; }

        [Required(ErrorMessage = "The field 'Country' is required!")]
        [Display(Name = "County")]
        public int CountryId { get; set; }

        [Required(ErrorMessage = "The field 'Office name' is required!")]
        [Display(Name = "Office name")]
        public string OfficeName { get; set; }

        [Required(ErrorMessage = "The field 'Address' is required!")]
        public string Address { get; set; }

        [Required(ErrorMessage = "The field 'Postal code' is required!")]
        [Display(Name = "Postal Code")]
        [DataType(DataType.PostalCode, ErrorMessage = "Not a valid postal code")]
        public string PostalCode { get; set; }

        [Required(ErrorMessage = "The field 'City' is required!")]
        public string City { get; set; }

        public string State { get; set; }
    }
}