using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharp.Biz;
using System;
using System.Collections.Generic;
using System.Text;
using CSharp.Common;

namespace CSharp.Biz.Tests
{
    [TestClass()]
    public class CollectionTests
    {
        [TestMethod()]
        public void CalculateSuggestedPriceTest()
        {
            var currentProduct = new Collections(1, "Saw", "");
            currentProduct.Cost = 50m;
            var expected = new OperationResult<decimal>(55m, "");

           
            var actual = currentProduct.CalculateSuggestedPrice(10m);

            
            Assert.AreEqual(expected.Result, actual.Result);
            Assert.AreEqual(expected.Message, actual.Message);
        }
    }
}


