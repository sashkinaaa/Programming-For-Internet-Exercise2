using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Upr2.Models;

namespace Upr2.DataAccessLayer
{
    public class SalesERPDAL : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().ToTable("TblEmployee");
            base.OnModelCreating(modelBuilder);
        }
        public SalesERPDAL() : base(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\v_hri\documents\visual studio 2015\Projects\Upr2\Upr2\App_Data\SalesERPDB.mdf';Integrated Security=True")
        {

        }
    }
}