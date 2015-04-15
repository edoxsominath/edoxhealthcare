using MCMD.EntityModel.Administration;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCMD.EntityModel
{

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, int, ApplicationUserLogin, ApplicationUserRole, ApplicationUserClaim>
    {
        public ApplicationDbContext()
            : base("IdentityConnection")
        {
        }

        //static ApplicationDbContext()
        //{
        //    Database.SetInitializer<ApplicationDbContext>(null);
        //}

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Map Entities to their tables.
            modelBuilder.Entity<ApplicationUser>().ToTable(" MCMDUsers");
            modelBuilder.Entity<ApplicationRole>().ToTable(" MCMDRoles");
            modelBuilder.Entity<ApplicationUserClaim>().ToTable(" MCMDUserClaims");
            modelBuilder.Entity<ApplicationUserLogin>().ToTable(" MCMDUserLogins");
            modelBuilder.Entity<ApplicationUserRole>().ToTable("MCHUserRoles");
            modelBuilder.Entity<ApplicationCreateUser>().ToTable("MCMDCreateUser");
            // Set AutoIncrement-Properties
            modelBuilder.Entity<ApplicationUser>().Property(r => r.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<ApplicationUserClaim>().Property(r => r.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<ApplicationRole>().Property(r => r.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            
            // Override some column mappings that do not match our default
            //modelBuilder.Entity<MyUser>().Property(r => r.UserName).HasColumnName("Login");
            //modelBuilder.Entity<MyUser>().Property(r => r.PasswordHash).HasColumnName("Password");
        }

    }
}
