using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TeamPlanner.Models.Enum;

namespace TeamPlanner.Models.Parametrage
{
    public class Employee : BaseCompanyModel
    {
        [Required(ErrorMessageResourceType = typeof(Properties.Resources), ErrorMessageResourceName = "FieldRequired")]
        [Display(Name = "RegistrationNumber", ResourceType = typeof(Properties.Resources))]
        public string NumeroPersonne { get; set; }

        [Display(Name = "Name", ResourceType = typeof(Properties.Resources))]
        public string Nom { get; set; }


        [Display(Name = "Forname", ResourceType = typeof(Properties.Resources))]
        public string Prenom { get; set; }


        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Birthday", ResourceType = typeof(Properties.Resources))]

        public DateTime? DateNaissance { get; set; } = DateTime.Today;


        [StringLength(8, ErrorMessage = "The {0} must has at least {2} caracters.", MinimumLength = 8)]
        [Display(Name = "CIN", ResourceType = typeof(Properties.Resources))]
        public string CIN { get; set; }

        [Display(Name = "Gender", ResourceType = typeof(Properties.Resources))]
        public RhGendar Gender { get; set; }


        [Display(Name = "MaritalStatus", ResourceType = typeof(Properties.Resources))]
        public RhMaritalStatus MaritalStatus { get; set; }


        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        //[DataType(DataType.Date)]
        //[Display(Name = "DeliveryDateCin", ResourceType = typeof(Properties.Resources))]
        public DateTime? DeliveryDateCin { get; set; } = DateTime.Today;


        [Display(Name = "PlaceCin", ResourceType = typeof(Properties.Resources))]
        public string PlaceCin { get; set; }


        [Display(Name = "PassportNumber", ResourceType = typeof(Properties.Resources))]
        public string PassportNumber { get; set; }


        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "ValidityDateRP", ResourceType = typeof(Properties.Resources))]
        public DateTime? ValidityDateRP { get; set; } = DateTime.Today;


        [Required(ErrorMessageResourceType = typeof(Properties.Resources), ErrorMessageResourceName = "FieldRequired")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "RecruitementDate", ResourceType = typeof(Properties.Resources))]
        public DateTime RecruitementDate { get; set; } = DateTime.Today;


        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "TitularizationDate", ResourceType = typeof(Properties.Resources))]
        public DateTime? TitularizationDate { get; set; } = DateTime.Today;


        [Phone]
        [Display(Name = "NumTel", ResourceType = typeof(Properties.Resources))]
        public string Tel { get; set; }


        [Phone]
        [Display(Name = "TelGSM", ResourceType = typeof(Properties.Resources))]
        public string TelGSM { get; set; }


        [EmailAddress]
        [Display(Name = "Email", ResourceType = typeof(Properties.Resources))]
        public string Mail { get; set; }


        [Display(Name = "Language", ResourceType = typeof(Properties.Resources))]
        public string Langue { get; set; }


        [Display(Name = "Photo", ResourceType = typeof(Properties.Resources))]
        public byte[] Photo { get; set; }


        [Display(Name = "User", ResourceType = typeof(Properties.Resources))]
        public string User { get; set; }

        public override string ToString()
        {
            return NumeroPersonne + "-" + Nom + " " + Prenom;
        }
    }
}
