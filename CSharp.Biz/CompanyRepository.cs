using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Biz
{
    public class CompanyRepository
    {
        public Company Retrieve(int vendorId)
        {
            
            Company vendor = new Company();

           
            if (vendorId == 1)
            {
                vendor.VendorId = 1;
                vendor.CompanyName = "ABC Corp";
                vendor.Email = "abc@abc.com";
            }
            return vendor;
        }
        public T RetrieveValue<T>(string sql, T defaultValue)
        {
            T value = defaultValue;
            return value;
        }
    }
}
