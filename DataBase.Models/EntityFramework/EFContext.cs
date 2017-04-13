using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DataBase.Models
{

    public partial class EFContext : DbContext
    {
        public EFContext():base("name=TestDataBase") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            //
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
