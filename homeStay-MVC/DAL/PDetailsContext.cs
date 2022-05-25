using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Entity;
using homeStay_MVC.Models;

namespace homeStay_MVC.DAL
{
    public class PDetailsContext : DbContext
    {
        public PDetailsContext() : base("HomeContext")
        { }

        public DbSet<PDetails> PDetail { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}