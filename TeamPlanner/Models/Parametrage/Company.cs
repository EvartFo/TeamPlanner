using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TeamPlanner.Models.Parametrage
{
    public class Company : BaseModel
    {
        [Required(ErrorMessageResourceType = typeof(Properties.Resources), ErrorMessageResourceName = "FieldRequired")]
        [Display(Name = "Name", ResourceType = typeof(Properties.Resources))]
        public string Name { get; set; }
        [Display(Name = "Description", ResourceType = typeof(Properties.Resources))]
        public string Description { get; set; }
        [Display(Name = "Adress", ResourceType = typeof(Properties.Resources))]
        public string Adress { get; set; }
        [Display(Name = "NumTel", ResourceType = typeof(Properties.Resources))]
        public string Telephone { get; set; }
        [Display(Name = "LegalStatus", ResourceType = typeof(Properties.Resources))]
        public string LegalStatus { get; set; }
        [Display(Name = "FiscalNumber", ResourceType = typeof(Properties.Resources))]
        public string FiscalNumber { get; set; }
        [Display(Name = "TradeRegister", ResourceType = typeof(Properties.Resources))]
        public string TradeRegister { get; set; }

        [Display(Name = "Numero")]
        public string Numero { get; set; }

        [Display(Name = "Voie")]
        public string Voie { get; set; }

        [Display(Name = "CodePostal")]
        public string CodePostal { get; set; }

        [Display(Name = "Ville")]
        public string Ville { get; set; }

        [Display(Name = "ComplementAdresse")]
        public string ComplementAdresse { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
