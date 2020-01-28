using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMBusinessLogicLayer
{
    public class CustomerRepository
    {
        
        public Customer Retrieve(int customerID)
        {
            Customer customer = new Customer(customerID);

            if (customerID == 1)
            {
                customer.FirstName = "Dee";
                customer.LastName = "Bost";
                customer.EmailAddresw = "email@adresss.com";
            }
            return customer;
        }


    
    
    }
}
