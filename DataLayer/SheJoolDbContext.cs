using Data.Entities;
using InnovezOne.Library.Entities;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    /// <summary>
    /// This is the dbContext of SheJool database.
    /// </summary>
    internal class ApplicationDbContext : IdentityDbContext<User, Role, long, UserLogin, UserRole, UserClaim>
    {
        /// <summary>
        /// In Ctr we can specify wich connectionString can be used for creating/ connectingTo databse.
        /// </summary>
        public ApplicationDbContext() : base("name=DbConenctionString")
        {
            Database.Log = sql => Debug.Write(sql);
        }

       

        public DbSet<Bike> Bikes { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Log> Logs { get; set; }
        
       

        /// <summary>
        /// This method is for changing all configuration of ORM. 
        /// </summary>
        /// <param name="builder"></param>
        protected override void OnModelCreating(DbModelBuilder builder)
        {
            // for disable pluralization
            builder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(builder);

            //Identity tables
            builder.Entity<User>().ToTable("User");
            builder.Entity<Role>().ToTable("Role");
            builder.Entity<UserRole>().ToTable("UserRole");
            builder.Entity<UserLogin>().ToTable("UserLogin");
            builder.Entity<UserClaim>().ToTable("UserClaim");
        }


  
        ///// <summary>
        ///// To Add log errors happends from saving cahnges into db.
        ///// </summary>
        ///// <returns></returns>
        //public override int SaveChanges()
        //{
        //    try
        //    {
        //        return base.SaveChanges();
        //    }
        //    catch (Exception ex)
        //    {
                
        //        var exceptionType = "ExceptionType: "+ex.GetType().ToString();
        //        var exceptionMessage = "ExceptionMessage: " + ex.Message + "innerException: " + ex.InnerException.Message;
        //        var logTypeId = cont
        //        // Retrieve the error messages as a list of strings.
        //        var errorMessages = ex.EntityValidationErrors
        //                .SelectMany(x => x.ValidationErrors)
        //                .Select(x => x.ErrorMessage);

        //        // Join the list to a single string.
        //        var fullErrorMessage = string.Join("; ", errorMessages);

        //        // Combine the original exception message with the new one.
        //        var exceptionMessage = string.Concat(ex.Message, " The validation errors are: ", fullErrorMessage);

        //        // Throw a new DbEntityValidationException with the improved exception message.
        //        throw new DbEntityValidationException(exceptionMessage, ex.EntityValidationErrors);
        //    }
            
      //  }

    }
}
