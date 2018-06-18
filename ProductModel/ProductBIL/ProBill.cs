using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using ProductDAL;
using ProductModels;

using System.Data;

namespace ProductBIL
{
    public class ProBill
    {
        ProDAL dal = new ProDAL();


        public List<Product> GetProducts()
        {
            return dal.GetProducts();
        }

        public List<Product> Search(string pName, int? Cid)
        {
            return dal.Search(pName,Cid);


        }

        public List<Category> GetCategories()
        {
            return dal.GetCategories();
        }

        public Product GetProductByPID(int pid)
        {
            return dal.GetProductByPID(pid);
        }

        public int Edit(Product pro)
        {
            return dal.Edit(pro);
        }
    }


}
