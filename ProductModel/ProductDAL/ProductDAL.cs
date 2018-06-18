using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;
using ProductModels;

namespace ProductDAL
{

    public class ProDAL
    {
        productEntity entity = new productEntity();

        public List<Product> GetProducts()
        {
            return entity.Products.ToList();
        }

        public List<Product> Search(string pName, int? Cid)
        {
            return entity.Products.Where(p =>
            (string.IsNullOrEmpty(pName) ? true : p.ProductName.Contains(pName))
            && (Cid == null ? true : p.CategoryID == Cid)
            ).ToList();


        }

        public List<Category> GetCategories()
        {
            return entity.Cats.ToList();
        }

        public Product GetProductByPID(int pid)
        {
            return entity.Products.Find(pid);
        }

        public int Edit(Product pro)
        {
            entity.Entry(pro).State = EntityState.Modified;

            if (entity.SaveChanges() > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }


        }
    }
}
