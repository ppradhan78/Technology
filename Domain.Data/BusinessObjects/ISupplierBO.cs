namespace Domain.Data.BusinessObjects
{
    public interface ISupplierBO
    {
        public List<SupplierSampleModel> GetSupplierList();
        public  Task<SupplierSampleModel> GetSupplierByIdAsync(int SupplierId);
        public bool SaveSupplier(SupplierSampleModel Input);
        public bool UpdateSupplier(SupplierSampleModel Input);

    }
}
