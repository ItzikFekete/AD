using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AD.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace AD.DAL
{
    public class ProjectContext : DbContext
    {
        public ProjectContext(): base("ProjectContext")
        {

        }
        public DbSet<People> Peoples { get; set; }
        public DbSet<Colours> Colours { get; set; }
        public DbSet<FavouriteColours> FavouriteColours { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}