using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Http.Authentication;

namespace TeamPlanner.Models.Parametrage
{
    public class IndexViewModel
    {
        public bool HasPassword { get; set; }
        public IList<UserLoginInfo> Logins { get; set; }
        public string PhoneNumber { get; set; }
        public bool TwoFactor { get; set; }
        public bool BrowserRemembered { get; set; }
    }

    public class ManageLoginsViewModel
    {
        public IList<UserLoginInfo> CurrentLogins { get; set; }
        public IList<AuthenticationDescription> OtherLogins { get; set; }
    }

    public class FactorViewModel
    {
        public string Purpose { get; set; }
    }

    public class SetPasswordViewModel
    {
        [Required]
        [StringLength(100, ErrorMessageResourceType = typeof(Properties.Resources), ErrorMessageResourceName = "CompPassWd", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "NewPassWd", ResourceType = typeof(Properties.Resources))]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "ConfirmNewPassWd", ResourceType = typeof(Properties.Resources))]
        [Compare("NewPassword", ErrorMessageResourceType = typeof(Properties.Resources), ErrorMessageResourceName = "DiffPassWd")]
        public string ConfirmPassword { get; set; }
    }

    public class ChangePasswordViewModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "ActualPassWd", ResourceType = typeof(Properties.Resources))]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessageResourceType = typeof(Properties.Resources), ErrorMessageResourceName = "CompPassWd", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "NewPassWd", ResourceType = typeof(Properties.Resources))]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "ConfirmNewPassWd", ResourceType = typeof(Properties.Resources))]
        [Compare("NewPassword", ErrorMessageResourceType = typeof(Properties.Resources), ErrorMessageResourceName = "DiffPassWd")]
        public string ConfirmPassword { get; set; }
    }

    public class AddPhoneNumberViewModel
    {
        [Required]
        [Phone]
        [Display(Name = "NumTel", ResourceType = typeof(Properties.Resources))]
        public string Number { get; set; }
    }

    public class VerifyPhoneNumberViewModel
    {
        [Required]
        [Display(Name = "Code", ResourceType = typeof(Properties.Resources))]
        public string Code { get; set; }

        [Required]
        [Phone]
        [Display(Name = "NumTel", ResourceType = typeof(Properties.Resources))]
        public string PhoneNumber { get; set; }
    }

    public class ConfigureTwoFactorViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<SelectListItem> Providers { get; set; }
    }
}
