using Domain.Data.SimpleModels;

namespace Domain.Data.Core
{
    public interface ISupplierCore
    {
        public List<SupplierSampleModel> GetSupplierList();
        public SupplierSampleModel GetSupplierById(int SupplierId);
        public bool SaveSupplier(SupplierSampleModel Input);
        public bool UpdateSupplier(SupplierSampleModel Input);
    }
}
