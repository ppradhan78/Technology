using Domain.Data.Data;
using Domain.Data.SimpleModels;

namespace Domain.Data.BusinessObjects
{
    public class SupplierBO : ISupplierBO
    {

        private readonly DomainDbContext _ctx;

        public SupplierBO(DomainDbContext ctx)
        {
            _ctx = ctx;
        }


        public SupplierSampleModel GetSupplierById(int SupplierId)
        {
            var result = new SupplierSampleModel { };
            var output = _ctx.Suppliers.FirstOrDefault(x => x.SupplierID == SupplierId);
            if (output != null)
            {
                result.SupplierID = output.SupplierID;
                result.CompanyName = output.CompanyName;
                result.ContactName = output.ContactName;
                result.ContactTitle = output.ContactTitle;
                result.Address = output.Address;
                result.City = output.City;
                result.Region = output.Region;
                result.PostalCode = output.PostalCode;
                result.Country = output.Country;
                result.Phone = output.Phone;
                result.Fax = output.Fax;
                result.HomePage = output.HomePage;
            }
            return result;
        }

        public List<SupplierSampleModel> GetSupplierList()
        {

            var results = new List<SupplierSampleModel>(); ;
            var output = _ctx.Suppliers;

            foreach (var item in output)
            {
                results.Add(new SupplierSampleModel
                {

                    SupplierID = item.SupplierID,
                    CompanyName = item.CompanyName,
                    ContactName = item.ContactName,
                    ContactTitle = item.ContactTitle,
                    Address = item.Address,
                    City = item.City,
                    Region = item.Region,
                    PostalCode = item.PostalCode,
                    Country = item.Country,
                    Phone = item.Phone,
                    Fax = item.Fax,
                    HomePage = item.HomePage
                });
            }
            return results;


        }

        public bool SaveSupplier(SupplierSampleModel Input)
        {
            return true;
        }

        public bool UpdateSupplier(SupplierSampleModel Input)
        {
            return true;
        }
    }
}
