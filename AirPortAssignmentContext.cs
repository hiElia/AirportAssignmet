using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

public class AirPortAssignmentContext : DbContext
{
    // You can add custom code to this file. Changes will not be overwritten.
    // 
    // If you want Entity Framework to drop and regenerate your database
    // automatically whenever you change your model schema, please use data migrations.
    // For more information refer to the documentation:
    // http://msdn.microsoft.com/en-us/data/jj591621.aspx

    public AirPortAssignmentContext() : base("name=AirPortAssignmentContext")
    {
        Database.SetInitializer<AirPortAssignmentContext>(new DropCreateDatabaseIfModelChanges<AirPortAssignmentContext>());

    }

    public System.Data.Entity.DbSet<AirPortAssignment.Models.Airport> Airports { get; set; }

    public System.Data.Entity.DbSet<AirPortAssignment.Models.AirplaneType> AirplaneTypes { get; set; }

    public System.Data.Entity.DbSet<AirPortAssignment.Models.Airplane> Airplanes { get; set; }

    public System.Data.Entity.DbSet<AirPortAssignment.Models.Pilot> Pilots { get; set; }
}
