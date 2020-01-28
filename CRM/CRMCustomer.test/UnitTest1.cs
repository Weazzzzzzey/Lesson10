using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CRMBusinessLogicLayer;

namespace CRMCustomer.test
{
    [TestClass]
    public class UnitTest1
    {

        Customer cus1 = new Customer();

        public void parengimas()
        {
            cus1.FirstName = "Dee";
            cus1.LastName = "Bost";
        }

        public void TikVardas()
        {
            cus1.FirstName = "Dee";
            cus1.LastName = "";
        }
        public void TikPavarde()
        {
            cus1.FirstName = "";
            cus1.LastName = "Bost";
        }
        public void Tuscias()
        {
            cus1.FirstName = "";
            cus1.LastName = "";
        }
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

        [TestMethod]
        public void PateikiamiNeTvarkingiDuomenysPavardeIrTikimasiGautiTikPavarde()
        {
            //Arange
            TikPavarde();
            //act
            string result = cus1.FullName;
            //Asset
            Assert.AreEqual(result, "Bost");
        }

        [TestMethod]
        public void PateikiamiNeTvarkingiDuomenysVardasIrTikimasiGautiTikVarda()
        {
            //Arange
            TikVardas();
            //act
            string result = cus1.FullName;
            //Asset
            Assert.AreEqual(result, "Dee");
        }

        [TestMethod]
        public void PateikiamiNeTvarkingiDuomenysNiekoIrTikimasiGautiTusciaString()
        {
            //Arange
            Tuscias();
            //act
            string result = cus1.FullName;
            //Asset
            Assert.AreEqual(result, "");
        }
    }
}
