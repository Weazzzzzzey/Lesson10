using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMBusinessLogicLayer
{
    class OrderItem
    {
        public string Product { get; set; }
        public int Count { get; set; }
        public double PurchaseP { get; set; }

        public bool Validate()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(Product)) isValid = false;
            if (string.IsNullOrWhiteSpace(Convert.ToString(Count))) isValid = false;
            if (string.IsNullOrWhiteSpace(Convert.ToString(PurchaseP))) isValid = false;

            return isValid;
        }
    }
}
