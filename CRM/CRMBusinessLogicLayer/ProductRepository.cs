using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMBusinessLogicLayer
{
    class ProductRepository
    {
        public Product Retrieve(int PorductID)
        {
            Product p = new Product();

            if (PorductID == 1)
            {
                p.ProductName = "Product";
                p.Description = "";
                p.CurrentPrice = 22.22d;
            }
            return p;
        }

        public bool Save()
        {
            //code that save the default Order
            return true;
        }
    }
}
