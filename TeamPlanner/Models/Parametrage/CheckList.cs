using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TeamPlanner.Models.Parametrage
{
    public class CheckList : BaseCompanyModel
    {
        [Display(Name = "Description", ResourceType = typeof(Properties.Resources))]
        public string Description { get; set; }

        [Display(Name = "Employee", ResourceType = typeof(Properties.Resources))]
        public int TacheID { get; set; }
        [ForeignKey("TacheID")]

        public virtual Tache Tache { get; set; }
    }
}
