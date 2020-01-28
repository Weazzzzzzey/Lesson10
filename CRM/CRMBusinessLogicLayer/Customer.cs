using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMBusinessLogicLayer
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get 
            {
                if (FirstName == "") { return LastName; } else
                if (LastName == "") { return FirstName; } else
                if (LastName == "" || FirstName == "") { return ""; } else
                return LastName + "," + FirstName;
            }
        }
        public string EmailAddresw { get; set; }
        public string HomeAddresw { get; set; }
        public string WorklAddresw { get; set; }

        public bool Validate()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;

            return isValid;
        }

        public bool Save()
        {
            //code that save the default customers
            return true;
        }

        public Customer Retrive(int CustomerID)
        {
            //code that returns the customer
            return new Customer();
        }

        public List<Customer> Retrive()
        {
            //Code that returns all of the customers
            return new List<Customer>();
        }
    
    
    }
}
