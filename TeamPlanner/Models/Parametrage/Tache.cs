using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TeamPlanner.Models.Parametrage
{
    public class Tache : BaseCompanyModel
    {
        [Required(ErrorMessageResourceType = typeof(Properties.Resources), ErrorMessageResourceName = "FieldRequired")]
        [Display(Name = "Titre", ResourceType = typeof(Properties.Resources))]
        public string Titre { get; set; }
        [Display(Name = "Description", ResourceType = typeof(Properties.Resources))]
        public string Description { get; set; }

        [Required(ErrorMessageResourceType = typeof(Properties.Resources), ErrorMessageResourceName = "FieldRequired")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "DateDebutTache", ResourceType = typeof(Properties.Resources))]
        public DateTime DateDebutTache { get; set; } = DateTime.Today;
        [Required(ErrorMessageResourceType = typeof(Properties.Resources), ErrorMessageResourceName = "FieldRequired")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "DateFinTache", ResourceType = typeof(Properties.Resources))]
        public DateTime DateFinTache { get; set; } = DateTime.Today;

        public virtual ICollection<CheckList> CheckList { get; set; }
    }
}
