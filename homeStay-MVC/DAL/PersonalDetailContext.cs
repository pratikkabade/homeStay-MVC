using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Entity;
using homeStay_MVC.Models;

namespace homeStay_MVC.DAL
{
    public class PersonalDetailContext : DbContext
    {
        public PersonalDetailContext() : base("HomeContext")
        { }

        public DbSet<Owner> Owners { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}