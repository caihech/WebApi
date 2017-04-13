using System;
using System.Data.Entity;

namespace DataBase.Models
{
    public partial class EFContext : DbContext
    {
        public DbSet<Users> Users { get; set; }
    }
}
