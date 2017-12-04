namespace Data.Migrations
{
    using Entities;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    /// <summary>
    /// This class is used for creating/updateing db, all configuration for creating/updating db comes here, including seeding all basic data we need for SheJool applications.
    /// </summary>
    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        /// <summary>
        /// This is a method for showing how the db can be created/updated.
        /// </summary>
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        /// <summary>
        /// This is the method for seeding all data we have in SheJool db as basic data. 
        /// Basic data is going to seed with default language(English).
        /// </summary>
        /// <param name="context"></param>
        protected override void Seed(ApplicationDbContext context)
        {
            // if you need to debug seed method during update-database command, uncomment two lines below.
            //if (System.Diagnostics.Debugger.IsAttached == false)
            //    System.Diagnostics.Debugger.Launch();

            //SheJoolSeedData.SeedDefaultTimeSlotLabel(context);

            //SheJoolSeedData.SeedApplicationAndEmailType(context);
            //SheJoolSeedData.SeedBookingStatus(context);
            //SheJoolSeedData.SeedFacilityStatus(context);
            //SheJoolSeedData.SeedFacilityType(context);

            //SheJoolSeedData.SeedSheJoolObject(context);

            //SheJoolSeedData.SeedProblem(context);
            //SheJoolSeedData.SeedSuitabilityRequirementType(context);
            //SheJoolSeedData.SeedUserDefinedFieldType(context);
            //SheJoolSeedData.SeedUserDefineDisplayType(context);

            //SheJoolSeedData.SeedSecurityBasicData(context);




        }

    }
}
