using Domain.Data.SimpleModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Test.MockData
{
    public  class SupplierMock
    {
       private   List<SupplierSampleModel> Suppliers =new List<SupplierSampleModel>();
        public SupplierMock()
        {
            Suppliers.Add(
                new SupplierSampleModel 
                {
                    Address= "Address",
                    City= "City",
                    CompanyName= "CompanyName",
                    ContactName= "ContactName",
                    ContactTitle= "ContactTitle",
                    Country= "Country",
                    Fax= "Fax",
                    HomePage= "HomePage",
                    Phone= "Phone",
                    PostalCode= "PostalCode",
                    Region= "Region",
                    SupplierID=1
                }
                );
        }
        public   List<SupplierSampleModel> AllSupplier()
        {
            return Suppliers;
        }
    }
}
