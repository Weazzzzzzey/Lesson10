using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CRMBusinessLogicLayer;

namespace CRMCustomer.test
{
    [TestClass]
    public class CustomerRepositoryTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arange
            CustomerRepository customerR = new CustomerRepository();
            Customer exoected = new Customer(1);
            exoected.FirstName = "Dee";
            exoected.LastName = "Bost";
            exoected.EmailAddresw = "email@adresss.com";

            //act
            var acual = customerR.Retrieve(1);

            //Assert
            Assert.AreEqual(exoected.EmailAddresw,acual.EmailAddresw);
            Assert.AreEqual(exoected.LastName,acual.LastName);
            Assert.AreEqual(exoected.FirstName,acual.FirstName);
        }
    }
}
