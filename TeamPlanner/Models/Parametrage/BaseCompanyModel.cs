using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TeamPlanner.Models.Parametrage
{
    public class BaseCompanyModel : BaseModel
    {
        [Display(Name = "Company", ResourceType = typeof(Properties.Resources))]
        public int companyID { get; set; }
    }
}
