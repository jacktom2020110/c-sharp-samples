using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;


namespace ProductModels
{
    public class productEntity : DbContext
    {
        public productEntity() : base("ConnectString")
        { }

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Cats { get; set; }

    }
}
