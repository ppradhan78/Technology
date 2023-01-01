using Domain.Data.BusinessObjects;
using Domain.Data.Core;
using Domain.Test.MockData;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Test.Data.Core
{
    public  class SupplierCoreUnitTest
    {
        private SupplierCore _supplierCore;
        private Mock<ISupplierBO> _supplierBOMock;

        public SupplierCoreUnitTest()
        {
            _supplierBOMock = new Mock<ISupplierBO>();
            _supplierCore = new SupplierCore(_supplierBOMock.Object);

        }

        [Fact]
        public void Get_Should_Return_All_Supplyer()
        {
            _supplierBOMock.Setup(s => s.GetSupplierList()).Returns(new SupplierMock().AllSupplier());
            var output = _supplierCore.GetSupplierList();
            Assert.True(output .Count>0);
        }
        [Fact]
        public void GetById_Should_Return_All_Supplyer()
        {
            _supplierBOMock.Setup(s => s.GetSupplierByIdAsync(1)).Returns(Task.FromResult(new SupplierMock().AllSupplier()[0]));
            var output = _supplierCore.GetSupplierByIdAsync(1);
            Assert.NotNull(output);
        }
    }
}
