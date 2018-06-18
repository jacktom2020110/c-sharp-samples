using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
