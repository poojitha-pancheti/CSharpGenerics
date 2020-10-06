using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharp.Biz;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Biz.Tests
{
    [TestClass()]
    public class CompanyRepositoryTests
    {
        [TestMethod()]
        public void RetrieveValueTest()
        {
            var repository = new CompanyRepository();
            var expected = 42;

            var actual = repository.RetrieveValue<int>("Select...", 42);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void RetrieveValueStringTest()
        {
            var repository = new CompanyRepository();
            var expected = "test";

            var actual = repository.RetrieveValue<string>("Select...", "test");

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void RetrieveValueObjectTest()
        {
            var repository = new CompanyRepository();
            var vendor = new Company();
            var expected = vendor;

            var actual = repository.RetrieveValue<Company>("Select...", vendor);

            Assert.AreEqual(expected, actual);
        }
    }
}


