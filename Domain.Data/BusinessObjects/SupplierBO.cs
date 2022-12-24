
using AutoMapper;

namespace Domain.Data.BusinessObjects
{
    public class SupplierBO : ISupplierBO
    {

        private readonly DomainDbContext _ctx;
        private IMapper _mappr;

        public SupplierBO(DomainDbContext ctx, IMapper mappr)
        {
            _ctx = ctx;
            _mappr = mappr;
        }


        public async Task<SupplierSampleModel> GetSupplierByIdAsync(int SupplierId)
        {
            var output =  _ctx.Suppliers.FirstOrDefault(x => x.SupplierID == SupplierId);
            return  _mappr.Map<SupplierSampleModel>(output);
        }

        public List<SupplierSampleModel> GetSupplierList()
        {
            var output = _ctx.Suppliers;
            return _mappr.Map<List<SupplierSampleModel>>(output);
        }

        public bool SaveSupplier(SupplierSampleModel Input)
        {
            return true;
        }

        public bool UpdateSupplier(SupplierSampleModel Input)
        {
            return true;
        }


        #region Private Method
        string InterpolatedString(SupplierSampleModel input)
        {
            return $" {input.ContactTitle} {input.ContactName}";
        }
        TimeOnly GetTime()
        {
            return new TimeOnly(10, 0);
        }
        DateOnly GetDate()
        {
            return new DateOnly(2000, 12, 21);
        }
        void MaxMin()
        {
            List<SupplierSampleModel> lst = new List<SupplierSampleModel>();
            lst.MaxBy(x => x.SupplierID);
            lst.MinBy(x => x.SupplierID);
        }

        #endregion
    }
}
