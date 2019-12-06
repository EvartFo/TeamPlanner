using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TeamPlanner.Data;

namespace TeamPlanner.Models.Parametrage
{
    // Vous pouvez ajouter des données de profil pour l'utilisateur en ajoutant d'autres propriétés à votre classe ApplicationUser. Pour en savoir plus, consultez https://go.microsoft.com/fwlink/?LinkID=317594.
    public class ApplicationUser : IdentityUser
    {
        private readonly ApplicationDbContext Context;

        public ICollection<ApplicationUserRole> UserRoles { get; set; }
        [Display(Name = "PassWd", ResourceType = typeof(Properties.Resources))]
        public string Password { get; set; }
        [Display(Name = "Language", ResourceType = typeof(Properties.Resources))]
        public string Language { get; set; }
        [Display(Name = "IsActif", ResourceType = typeof(Properties.Resources))]
        public bool IsActif { get; set; }
        [Display(Name = "Company", ResourceType = typeof(Properties.Resources))]
        public int CompanyID { get; set; }
        [NotMapped]
        public string employe { get; set; }        
    }
    public class ApplicationRole : IdentityRole
    {
        //public string Name { get; set; }
        [Display(Name = "Description", ResourceType = typeof(Properties.Resources))]
        public string Description { get; set; }
        public ICollection<ApplicationUserRole> UserRoles { get; set; }
    }
    public class ApplicationUserRole : IdentityUserRole<string>
    {
        public virtual ApplicationUser User { get; set; }
        public virtual ApplicationRole Role { get; set; }
    }
    public class ApplicationUserRoleCompanies
    {
        [Display(Name = "Company", ResourceType = typeof(Properties.Resources))]
        public int companyId { get; set; }
        [Display(Name = "Role", ResourceType = typeof(Properties.Resources))]
        public string RoleId { get; set; }
        [Display(Name = "User", ResourceType = typeof(Properties.Resources))]
        public string UserId { get; set; }
    }
}
