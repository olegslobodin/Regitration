using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Regitration.ViewModels
{
    [Serializable]
    public class Step1ViewModel : IStepViewModel
    {
        public void Initialize()
        {
            if (Salutations == null)
                Salutations = new List<SalutationViewModel>
                {
                    new SalutationViewModel {Id = 0, Name = "Mr."},
                    new SalutationViewModel {Id = 1, Name = "Mrs."},
                    new SalutationViewModel {Id = 2, Name = "Ms."},
                    new SalutationViewModel {Id = 3, Name = "Dr."}
                };
        }

        private const string STitle = "Contact Info";

        public string StepTitle =>STitle;

        [Display(Name = "Salutation")]
        public int SalutationId { get; set; }

        public List<SalutationViewModel> Salutations { get; private set; }

        [Required(ErrorMessage = "The field 'First Name' is required!")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }

        [Required(ErrorMessage = "The field 'Last Name' is required!")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "The field 'Company' is required!")]
        [Display(Name = "Company")]
        public string Company { get; set; }

        [Required(ErrorMessage = "The field 'Title' is required!")]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "The field 'Email' is required!")]
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Please enter a correct email address!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "The field 'Confirm Email' is required!")]
        [Display(Name = "Confirm Email")]
        [EmailAddress(ErrorMessage = "Please enter a correct email address!")]
        [Compare("Email", ErrorMessage = "Email confirmation does not match email above")]
        public string ConfirmEmail { get; set; }

        [Required(ErrorMessage = "The field 'Phone' is required!")]
        [Display(Name = "Phone")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string Phone { get; set; }

        [Display(Name = "Fax")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Not a valid phone number")]
        public string Fax { get; set; }

        [Display(Name = "Mobile")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Not a valid phone number")]
        public string Moblie { get; set; }
    }
}