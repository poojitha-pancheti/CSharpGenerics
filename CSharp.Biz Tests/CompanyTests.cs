using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharp.Biz;
using System;
using System.Collections.Generic;
using System.Text;
using CSharp.Common;

namespace CSharp.Biz.Tests
{
    [TestClass()]
    public class CompanyTests
    {
        [TestMethod()]
        public void PlaceOrderTest()
        {
            var vendor = new Company();
            var collections = new Collections(1, "Saw", "");
            var expected = new OperationResult<bool>(true,
                "Order from Acme, Inc\r\nProduct: Saw\r\nQuantity: 12" +
                                     "\r\nInstructions: standard delivery");


            var actual = vendor.PlaceOrder(collections, 12);


            Assert.AreEqual(expected.Result, actual.Result);
            Assert.AreEqual(expected.Message, actual.Message);
        }

        [TestMethod()]
        public void ToStringTest()
        {
            var vendor = new Company();
            vendor.VendorId = 1;
            vendor.CompanyName = "ABC Corp";
            var expected = "Vendor: ABC Corp (1)";

            
            var actual = vendor.ToString();

            
            Assert.AreEqual(expected, actual);
        }
    }
}


