using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TeamPlanner.Models.Parametrage
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "UserName", ResourceType = typeof(Properties.Resources))]
        public string UserName { get; set; }
        [Display(Name = "Email", ResourceType = typeof(Properties.Resources))]
        public string Email { get; set; }
    }
    public class ExternalLoginListViewModel
    {
        public string ReturnUrl { get; set; }
    }

    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }

    public class VerifyCodeViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "Code", ResourceType = typeof(Properties.Resources))]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "RememberBrowser", ResourceType = typeof(Properties.Resources))]
        public bool RememberBrowser { get; set; }
        [Display(Name = "RememberMe", ResourceType = typeof(Properties.Resources))]
        public bool RememberMe { get; set; }
    }

    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "UserName", ResourceType = typeof(Properties.Resources))]
        public string UserName { get; set; }
        [Display(Name = "Email", ResourceType = typeof(Properties.Resources))]
        public string Email { get; set; }
    }

    public class LoginViewModel
    {
        [Required]
        [Display(Name = "UserName", ResourceType = typeof(Properties.Resources))]
        public string UserName { get; set; }
        [Display(Name = "Email", ResourceType = typeof(Properties.Resources))]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "PassWd", ResourceType = typeof(Properties.Resources))]
        public string Password { get; set; }

        [Display(Name = "Role", ResourceType = typeof(Properties.Resources))]
        [EmailAddress]
        public List<string> Role { get; set; }

        [Display(Name = "Company", ResourceType = typeof(Properties.Resources))]
        [EmailAddress]
        public string Company { get; set; }


        [Display(Name = "RememberMe", ResourceType = typeof(Properties.Resources))]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "UserName", ResourceType = typeof(Properties.Resources))]
        public string UserName { get; set; }
        [EmailAddress]
        [Display(Name = "Email", ResourceType = typeof(Properties.Resources))]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessageResourceType = typeof(Properties.Resources), ErrorMessageResourceName = "CompPassWd", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "PassWd", ResourceType = typeof(Properties.Resources))]
        public string Password { get; set; }


        [Compare("Password", ErrorMessageResourceType = typeof(Properties.Resources), ErrorMessageResourceName = "DiffPassWd")]
        [DataType(DataType.Password)]
        [Display(Name = "ConfirmPassWd", ResourceType = typeof(Properties.Resources))]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Language", ResourceType = typeof(Properties.Resources))]
        public string Language { get; set; }
    }


    public class ResetPasswordViewModel
    {
        [Required]
        [Display(Name = "UserName", ResourceType = typeof(Properties.Resources))]
        public string UserName { get; set; }
        [EmailAddress]
        [Display(Name = "Email", ResourceType = typeof(Properties.Resources))]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessageResourceType = typeof(Properties.Resources), ErrorMessageResourceName = "CompPassWd", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "PassWd", ResourceType = typeof(Properties.Resources))]
        public string Password { get; set; }


        [Compare("Password", ErrorMessageResourceType = typeof(Properties.Resources), ErrorMessageResourceName = "DiffPassWd")]
        [DataType(DataType.Password)]
        [Display(Name = "ConfirmPassWd", ResourceType = typeof(Properties.Resources))]
        public string ConfirmPassword { get; set; }
        [Display(Name = "Code", ResourceType = typeof(Properties.Resources))]
        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required]
        [Display(Name = "UserName", ResourceType = typeof(Properties.Resources))]
        public string UserName { get; set; }
        [EmailAddress]
        [Display(Name = "Email", ResourceType = typeof(Properties.Resources))]
        public string Email { get; set; }
    }
}
