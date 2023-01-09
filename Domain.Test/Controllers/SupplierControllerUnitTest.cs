using Domain.API.Controllers;
using Domain.Data.Core;
using Domain.Data.SimpleModels;
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
            //OR
            //_supplierCoreMock.Setup(s => s.GetSupplierByIdAsync(1)).ReturnsAsync(new SupplierSampleModel { });

            //OR error
            //_supplierCoreMock.Setup(s => s.GetSupplierByIdAsync(1)).Returns(Task.CompletedTask);

            //_supplierCoreMock.SetupSequence(s => s.GetSupplierByIdAsync(1)).Returns(Task.FromResult(new SupplierMock().AllSupplier()[0]))
            //    //.Returns(Task.FromResult(new SupplierMock().AllSupplier()[1]))
            //    .Returns(Task.FromResult(new SupplierSampleModel { }));

            var output = _controller.Get(1);
            Assert.NotNull(output);
        }
        [Fact]
        public void GetById_InvalidId_Should_Validate_Error()
        {
            _supplierCoreMock.Setup(s => s.GetSupplierByIdAsync(1)).Throws<ArgumentException>();
            //_supplierCoreMock.Setup(s => s.GetSupplierByIdAsync(1)).Throws(new Exception("Invalid SupplierId"));
            var output = _controller.Get(1);
            Assert.NotEmpty(output?.Exception?.InnerException?.Message);
        }
    }
}