using Microsoft.AspNetCore.Mvc;
using WebAPIAuth.GenericRepositories;
using WebAPIAuth.Model;

namespace WebAPIAuth.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class GENEmployeeController : ControllerBase
    {
        //private readonly GenericUnitOfWork iemployeeRepo;
        //private readonly IGenericUnitOfWork iemployeeRepo;
        private readonly IGenericEmployee<Employee> iemployeeRepo;

        // GENEmployeeController(GenericUnitOfWork iemployeeRepo)
        //public GENEmployeeController(IGenericUnitOfWork iemployeeRepo)

        public GENEmployeeController(IGenericEmployee<Employee> iemployeeRepo)
        {
            this.iemployeeRepo = iemployeeRepo;
        }

        [HttpGet]
        public ActionResult Get()
        {
            var employee = iemployeeRepo.GetAllEmployee();
            //var employee = iemployeeRepo.GetInstance<Employee>().GetAllEmployee();
            return Ok(employee);
        }

        Employee GetAllEmployee()
        {
            return null;
        }
    }
}
