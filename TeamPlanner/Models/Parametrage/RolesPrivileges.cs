using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TeamPlanner.Models.Parametrage
{
    public class RolesPrivileges
    {
        [Key]
        [Required]
        public string IdRole { get; set; }
        [Key]
        [Required(ErrorMessageResourceType = typeof(Properties.Resources), ErrorMessageResourceName = "FieldRequired")]
        [Display(Name = "Privilege", ResourceType = typeof(Properties.Resources))]
        public string Privilege { get; set; }
    }
}
