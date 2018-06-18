using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using ProductDAL;
using ProductModels;

namespace ProductBIL
{
    public class ProBill
    {
        ProDAL dal = new ProDAL();


        public List<Product> GetProducts()
        {
            return dal.GetProducts();
        }
    }


}
