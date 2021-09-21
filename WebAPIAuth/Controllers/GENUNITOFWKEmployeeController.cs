using Microsoft.AspNetCore.Mvc;
using WebAPIAuth.GenericRepositories;
using WebAPIAuth.Model;

namespace WebAPIAuth.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GENUNITOFWKEmployeeController : ControllerBase
    {
        private readonly IGenericUnitOfWork iemployeeRepo;
        public GENUNITOFWKEmployeeController(IGenericUnitOfWork iemployeeRepo)
        {
            this.iemployeeRepo = iemployeeRepo;
        }
        [HttpGet]
        public ActionResult Get()
        {
            var employee = iemployeeRepo.GetInstance<Employee>().GetAllEmployee();
            return Ok(employee);
        }

        Employee GetAllEmployee()
        {
            return null;
        }
    }
}
