
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
        public ActionResult<IEnumerable< SupplierSampleModel>> Get()
        {
            var result= _supplierCore.GetSupplierList();
            return Ok(result);
        }

        // GET api/<SupplierController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SupplierSampleModel>> Get(int id)
        {
            var result = await _supplierCore.GetSupplierByIdAsync(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
        //[HttpGet("{id}")]
        //public ActionResult<SupplierSampleModel> GetFile(int id)
        //{
        //    var filePath = @"F:\JobSearch\LinkedIn\SQL\1668263482372.pdf";
        //    if (!System.IO.File.Exists(filePath))
        //    {
        //        return NotFound();
        //    }
        //    var bytes= System.IO.File.ReadAllBytes(filePath);

        //    return File(bytes,"text/plain",Path.GetFileName(filePath));
        //}
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
