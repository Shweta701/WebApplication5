using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace WebApplication5.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext() : base("Data Source=CHETUIWK1702\\SQLEXPRESS;Initial Catalog=mvctestdb111;Integrated Security=True;Pooling=False") { }


        public DbSet<Category> Categories { get; set; }
        public DbSet<Products> Products { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder){ 
       
        //}

    }
}