using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Entity;
using homeStay_MVC.Models;

namespace homeStay_MVC.DAL
{
    public class RoomContext : DbContext
    {
        public RoomContext() : base("HomeContext")
        { }

        //admin to owner 
        public DbSet<Admin> Admins { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}