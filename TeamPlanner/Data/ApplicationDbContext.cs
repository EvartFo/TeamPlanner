using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamPlanner.Models.Parametrage;

namespace TeamPlanner.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string, IdentityUserClaim<string>,
  ApplicationUserRole, IdentityUserLogin<string>,
  IdentityRoleClaim<string>, IdentityUserToken<string>>

    {
        private readonly IHttpContextAccessor _contextAccessor;
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IHttpContextAccessor contextAccessor)
            : base(options)
        {
            _contextAccessor = contextAccessor;
        }



        public override int SaveChanges()
        {

            foreach (var entry in this.ChangeTracker.Entries())
            {
                int cond1 = entry.Entity.GetType().GetProperties().Where(u => u.Name == "companyID").Count();
                int cond2 = entry.Entity.GetType().GetProperties().Where(u => u.Name == "DateCreat").Count();
                if (cond1 > 0)
                {
                    if (entry.State == EntityState.Added)
                    {
                        ((BaseModel)entry.Entity).DateCreat = System.DateTime.Now.Date;
                        ((BaseModel)entry.Entity).UserCreat = _contextAccessor.HttpContext.User.Identity.Name;
                    }
                    else if (entry.State == EntityState.Modified)
                    {
                        ((BaseModel)entry.Entity).DateModif = System.DateTime.Now.Date;
                        ((BaseModel)entry.Entity).UserModif = _contextAccessor.HttpContext.User.Identity.Name;
                    }
                }
                else if (cond2 > 0)
                {
                    if (entry.State == EntityState.Added)
                    {
                        ((BaseModel)entry.Entity).DateCreat = System.DateTime.Now.Date;
                        ((BaseModel)entry.Entity).UserCreat = _contextAccessor.HttpContext.User.Identity.Name;
                    }
                    else if (entry.State == EntityState.Modified)
                    {
                        ((BaseModel)entry.Entity).DateModif = System.DateTime.Now.Date;
                        ((BaseModel)entry.Entity).UserModif = _contextAccessor.HttpContext.User.Identity.Name;
                    }
                }

            }
            return base.SaveChanges();
        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ApplicationUser>(entity =>
            {
                entity.ToTable(name: "Inn4Users");
                entity.HasKey(t => new { t.UserName });
                entity.Property(e => e.Id).HasColumnName("UserId");

            });

            modelBuilder.Entity<ApplicationUserRole>(userRole =>
            {
                userRole.HasKey(ur => new { ur.UserId, ur.RoleId });

                userRole.HasOne(ur => ur.Role)
                    .WithMany(r => r.UserRoles)
                    .HasForeignKey(ur => ur.RoleId)
                    .IsRequired();

                userRole.HasOne(ur => ur.User)
                    .WithMany(r => r.UserRoles)
                    .HasForeignKey(ur => ur.UserId)
                    .IsRequired();
            });

            modelBuilder.Entity<ApplicationUserRoleCompanies>(entity =>
            {
                entity.ToTable(name: "Inn4UserRoleCompanies");
                entity.HasKey(t => new { t.UserId, t.RoleId, t.companyId });
                entity.Property(p => p.UserId).HasColumnName("UserId");

            });

            modelBuilder.Entity<ApplicationRole>().ToTable("Inn4Roles").Property(p => p.Id).HasColumnName("RoleId");

            modelBuilder.Entity<RolesPrivileges>().ToTable("Inn4RolesPrivileges").HasKey(t => new { t.IdRole, t.Privilege });

            modelBuilder.Entity<Tache>().HasMany(s => s.CheckList).WithOne(a => a.Tache).IsRequired().OnDelete(DeleteBehavior.Restrict);


        }


        public string UserSession
        {
            get
            {
                _contextAccessor.HttpContext.Session.SetString("UserName", "Jarvik");
                return _contextAccessor.HttpContext.Session.GetString("UserName");
            }

        }
        public new DbSet<ApplicationRole> Roles { get; set; }
        public DbSet<ApplicationUserRole> UserRole { get; set; }
        public DbSet<RolesPrivileges> RolesPrivileges { get; set; }
        public DbSet<ApplicationUserRoleCompanies> UserRoleCompanies { get; set; }
        public DbSet<Company> Companies { get; set; }
        
        public DbSet<Employee> Employee { get; set; }

        public DbSet<CheckList> CheckList { get; set; }
        public DbSet<Tache> Tache { get; set; }


    }
}
