using System.Collections.Generic;
using EmployeeManagementApi.Modal;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System;
using System.Threading.Tasks;
using System.Web.Http;

namespace EmployeeManagementApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManagerController : ApiControllerAttribute
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<Employee> GetAllManagers()
        {
            List<Employee> managers = new List<Employee>();
            var managerIds = EmployeeDb.employees.Select(employee => employee.ManagerId).ToList().Distinct();
            foreach (var managerId in managerIds)
            {
                foreach (var employee in EmployeeDb.employees)
                {
                    if (managerId == employee.EmployeeId)
                    {
                        managers.Add(employee);
                    }
                }
            }
            return managers;
        }
        // GET api/values/5
        [HttpGet("{managerId}")]
        public ActionResult<IEnumerable<Employee>> GetManagerById(int managerId)
        {
            var managerIds = EmployeeDb.employees.Select(employee => employee.ManagerId).ToList().Distinct();
            if (managerIds.Contains(managerId))
                return EmployeeDb.employees.Where(employee => employee.EmployeeId == managerId).ToList();
            return NotFound("Manager Id is not valid");
        }
    }
}
