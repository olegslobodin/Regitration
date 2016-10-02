using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Security;

namespace Regitration.ViewModels
{
    [Serializable]
    public class Step4ViewModel : IStepViewModel
    {
        private const string STitle = "Password";

        public string StepTitle => STitle;

        [Required(ErrorMessage = "The field 'Password' is required!")]
        [DataType(DataType.Password)]
        [MembershipPassword(
            MinRequiredPasswordLength = 8,
            MinRequiredNonAlphanumericCharacters = 0,
            PasswordStrengthRegularExpression = "(?=(.*[A-Z]+.*))(?=(.*\\d+.*))",
            PasswordStrengthError = "Password must be at least 8 characters in length and include both upper and lower case letters as well as at least one number.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "The field 'Confirm password' is required!")]
        [Display(Name = "Confirm new password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password confirmation does not match password above")]
        public string ConfirmPassword { get; set; }

        [Range(typeof(bool), "true", "true", ErrorMessage = "Please indicate that you have read and accepter terms of use.")]
        [Display(Name = "I have read and accept the terms of use")]
        public bool TermsIsAccepted { get; set; }
    }
}