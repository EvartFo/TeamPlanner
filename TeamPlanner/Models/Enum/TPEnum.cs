using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TeamPlanner.Models.Enum
{
    public enum RhGendar
    {
        [Display(Description = "Woman", ResourceType = typeof(Properties.Resources))]
        Female,
        [Display(Description = "Man", ResourceType = typeof(Properties.Resources))]
        Male
    }

    public enum RhMaritalStatus
    {
        [Display(Description = "Single", ResourceType = typeof(Properties.Resources))]
        Célibataire,
        [Display(Description = "Married", ResourceType = typeof(Properties.Resources))]
        Marié,
        [Display(Description = "Divorced", ResourceType = typeof(Properties.Resources))]
        Divorcé,
        [Display(Description = "Widower", ResourceType = typeof(Properties.Resources))]
        Veuve
    }
}
