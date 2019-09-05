using System.Collections.Generic;
using EmployeeManagementApi.Modal;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace EmployeeManagementApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ApiControllerAttribute
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<Employee> GetAllEmployees()
        {
            return EmployeeDb.employees;
        }
        // GET api/values/5
        [HttpGet("{managerId}")]
        public ActionResult<IEnumerable<Employee>> GetEmployeesByManagerId(int managerId)
        {
            var managerIds = EmployeeDb.employees.Select(employee => employee.ManagerId).ToList().Distinct();
            if (managerIds.Contains(managerId))
                return EmployeeDb.employees.Where(employee => employee.ManagerId == managerId).ToList();
            return NotFound("Manager Id is not valid");
        }
        [HttpPost]
        public void Post([FromBody] Employee employee)
        {
            EmployeeDb.employees.Add(employee);
        }

    }
}
