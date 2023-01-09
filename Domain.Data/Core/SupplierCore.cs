

namespace Domain.Data.Core
{
    public class SupplierCore : ISupplierCore
    {
        ISupplierBO _supplierBO;

        public SupplierCore(ISupplierBO supplierBO)
        {
            _supplierBO= supplierBO;
        }
        public async Task<SupplierSampleModel> GetSupplierByIdAsync(int SupplierId)
        {
            if (SupplierId<=0)
            {
                throw new ArgumentException("Invalid SupplierId");
            }
            return await _supplierBO.GetSupplierByIdAsync(SupplierId);    
        }

        public List<SupplierSampleModel> GetSupplierList()
        {
            return _supplierBO.GetSupplierList();
        }

        public bool SaveSupplier(SupplierSampleModel Input)
        {
            ArgumentNullException.ThrowIfNull(Input);

           return _supplierBO.SaveSupplier(Input);
        }

        public bool UpdateSupplier(SupplierSampleModel Input)
        {
            ArgumentNullException.ThrowIfNull(Input);
            return _supplierBO.UpdateSupplier(Input);
        }
    }
}
