using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMBusinessLogicLayer
{
    public class Customer
    {
        public string CustomerID { get; set; }
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

    }
}
