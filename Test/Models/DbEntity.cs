using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Test.Models;

namespace demo.Models
{
    public class DbEntity:DbContext
    {
        //public DbEntity() : base("DbEntity")
        //{
        //}
        //public DbSet<test> tests { get; set; }
        public DbSet<Demo> Demos { get; set; }
        public DbSet<complaints> Complaints { get; set; }

        //   public DbSet<Main> Mains { get; set; }

        public DbSet<masters> Masters { get; set; }

    }
}