using System;
using System.ComponentModel.DataAnnotations;

namespace TeamPlanner.Models.Parametrage
{
    public class BaseModel
    {
        [Key, Required]
        public int ID { get; set; }
        [Display(Name = "UserCreat", ResourceType = typeof(Properties.Resources))]
        public string UserCreat { get; set; }
        [Display(Name = "UserModif", ResourceType = typeof(Properties.Resources))]
        public string UserModif { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "DateCreat", ResourceType = typeof(Properties.Resources))]
        public DateTime DateCreat { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "DateModif", ResourceType = typeof(Properties.Resources))]
        public DateTime? DateModif { get; set; }
        public string Display { get { return ToString(); } }
    }
}