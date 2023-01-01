using Domain.API.Controllers;
using Domain.Data.Core;
using Domain.Test.MockData;
using Moq;

namespace Domain.Test.Controllers
{
    public class SupplierControllerUnitTest
    {
        private SupplierController _controller;
        private Mock<ISupplierCore> _supplierCoreMock;

        public SupplierControllerUnitTest()
        {
            _supplierCoreMock = new Mock<ISupplierCore>();
            _controller = new SupplierController(_supplierCoreMock.Object);

        }

        [Fact]
        public void Get_Should_Return_All_Supplyer()
        {
            _supplierCoreMock.Setup(s => s.GetSupplierList()).Returns(new SupplierMock().AllSupplier());
            var output = _controller.Get();
            Assert.True(((Microsoft.AspNetCore.Mvc.ObjectResult)output?.Result)?.StatusCode == 200);
        }
        [Fact]
        public void GetById_Should_Return_All_Supplyer()
        {
            _supplierCoreMock.Setup(s => s.GetSupplierByIdAsync(1)).Returns(Task.FromResult(new SupplierMock().AllSupplier()[0]));
            var output = _controller.Get(1);
            Assert.NotNull(output);
        }
    }
}