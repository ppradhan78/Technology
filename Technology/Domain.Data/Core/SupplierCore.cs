using Domain.Data.BusinessObjects;
using Domain.Data.SimpleModels;

namespace Domain.Data.Core
{
    public class SupplierCore : ISupplierCore
    {
        ISupplierBO _supplierBO;

        public SupplierCore(ISupplierBO supplierBO)
        {
            _supplierBO= supplierBO;
        }
        public SupplierSampleModel GetSupplierById(int SupplierId)
        {
            return _supplierBO.GetSupplierById(SupplierId);    
        }

        public List<SupplierSampleModel> GetSupplierList()
        {
            return _supplierBO.GetSupplierList();
        }

        public bool SaveSupplier(SupplierSampleModel Input)
        {
           return _supplierBO.SaveSupplier(Input);
        }

        public bool UpdateSupplier(SupplierSampleModel Input)
        {
            return _supplierBO.UpdateSupplier(Input);
        }
    }
}
