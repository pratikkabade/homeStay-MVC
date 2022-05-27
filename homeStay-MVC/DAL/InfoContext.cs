using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Entity;
using homeStay_MVC.Models;

namespace homeStay_MVC.DAL
{
    public class InfoContext : DbContext
    {
        public InfoContext() : base("InfoContext")
        { }

        public DbSet<Info> Infos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}