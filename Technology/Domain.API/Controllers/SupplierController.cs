using Domain.Data.Core;
using Domain.Data.SimpleModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Domain.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        ISupplierCore _supplierCore;

        public SupplierController(ISupplierCore supplierCore)
        {
            _supplierCore= supplierCore;
        }
        // GET: api/<SupplierController>
        [HttpGet]
        public List<SupplierSampleModel> Get()
        {
            return _supplierCore.GetSupplierList();
        }

        // GET api/<SupplierController>/5
        [HttpGet("{id}")]
        public SupplierSampleModel Get(int id)
        {
            return _supplierCore.GetSupplierById(id);
        }

        // POST api/<SupplierController>
        [HttpPost]
        public void Post([FromBody] SupplierSampleModel input)
        {
             _supplierCore.SaveSupplier(input);
        }

        // PUT api/<SupplierController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] SupplierSampleModel input)
        {
            _supplierCore.UpdateSupplier(input);
        }
    }
}
