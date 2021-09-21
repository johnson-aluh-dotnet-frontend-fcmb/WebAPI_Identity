using Microsoft.AspNetCore.Mvc;
using WebAPIAuth.Model;
using WebAPIAuth.Repositories;

namespace WebAPIAuth.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepo iemployeeRepo;
        public EmployeeController(IEmployeeRepo iemployeeRepo)
        {
            this.iemployeeRepo = iemployeeRepo;
        }
        [HttpGet]
        public ActionResult Get()
        {
            var employee = iemployeeRepo.GetAllEmployee();
            return Ok(employee);
        }

        Employee GetAllEmployee()
        {
            return null;
        }
    }
}
