using AdamTemplate.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace AdamTemplate.DAL
{
    public class PageContext:DbContext
    {
        public PageContext():base("AdamConnection")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        public DbSet<AmazingFeatures> AmazingFeatures { get; set; }
        public DbSet<CardBody> CardBodies { get; set; }

        public DbSet<HeaderContent> HeaderContents { get; set; }

        public DbSet<IconArea> GetIconAreas { get; set; }
        public DbSet<MainContent> MainContents { get; set; }
        public DbSet<PhotoArea>PhotoAreas { get; set; }
        public DbSet<User> Users { get; set; }
    }
}