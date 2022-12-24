
namespace Domain.Data.Core
{
    public interface ISupplierCore
    {
        public List<SupplierSampleModel> GetSupplierList();
        public  Task< SupplierSampleModel> GetSupplierByIdAsync(int SupplierId);
        public bool SaveSupplier(SupplierSampleModel Input);
        public bool UpdateSupplier(SupplierSampleModel Input);
    }
}
