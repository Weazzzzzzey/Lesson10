using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMBusinessLogicLayer
{
    public class Address
    {
        public string StreetLine { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }

        public bool Validate()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(StreetLine)) isValid = false;
            if (string.IsNullOrWhiteSpace(City)) isValid = false;
            if (string.IsNullOrWhiteSpace(State)) isValid = false;
            if (string.IsNullOrWhiteSpace(PostalCode)) isValid = false;
            if (string.IsNullOrWhiteSpace(Country)) isValid = false;

            return isValid;
        }
    }
}
