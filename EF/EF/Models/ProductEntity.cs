using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;



namespace EF.Models
{
    /// <summary>
    /// 数据库下下文类
    /// </summary>
    public class ProductEntity : DbContext
    {
        public ProductEntity() : base("ConnectString")
        { }
        public DbSet<Product> Products { get; set; }
    }
}