using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FriendOrganizer.Model;

namespace FriendOrganizer.DataAccess
{
    public class FriendOrganizerDbContext : DbContext
    {
        public DbSet<Friend> Friends { get; set; }

        public FriendOrganizerDbContext()
            : base("FriendOrganizerDb")
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            //modelBuilder.Configurations.Add(new FriendConfiguration());
        }
    }

    // Fluent API Implementation
    //public class FriendConfiguration : EntityTypeConfiguration<Friend>
    //{
    //    public FriendConfiguration()
    //    {
    //        Property(f => f.FirstName)
    //            .IsRequired()
    //            .HasMaxLength(50);

    //        Property(f => f.LastName)
    //            .HasMaxLength(50);

    //        Property(f => f.Email)
    //            .HasMaxLength(50);
    //    }
    //}

}
