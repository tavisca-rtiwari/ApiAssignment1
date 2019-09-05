using EmployeeManagementApi.Controllers;
using EmployeeManagementApi.Modal;
using System.Collections.Generic;
using Xunit;

namespace TestControllerFixture
{
    public class TestApi
    {
        [Fact]
        public void GetAllManager_ShouldReturnAllManagers()
        {

            var managerController = new ManagerController();

            IEnumerable<Employee> managers = managerController.GetAllManagers();
        }
    }
}
