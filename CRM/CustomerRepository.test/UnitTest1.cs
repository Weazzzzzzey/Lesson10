using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CRMBusinessLogicLayer;

namespace CustomerRepository.test
{
    [TestClass]
    public class UnitTest1
    {

        Customer customer = new Customer(customerID);
        [TestMethod]
        
        public void PateikiamiTvarkingiDuomenysIrTikimasiGautiTvarkingaAts()
        {
            //Arange
            parengimas();
            //act
            string result = cus1.FullName;
            //Asset
            Assert.AreEqual(result, "Bost,Dee");
        }
    }
}
