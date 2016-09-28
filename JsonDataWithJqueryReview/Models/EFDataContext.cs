using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace JsonDataWithJqueryReview.Models
{
    public class EFDataContext:DbContext
    {
        public EFDataContext()
            : base("name=DbConnectionstring") 
        {
        
        }

        public DbSet<Blog> Bolgs { get; set; }

        public DbSet<BlogCategory> BlogCategories { get; set; }
    }
}