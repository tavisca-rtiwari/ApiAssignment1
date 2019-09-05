using EmployeeManagementApi.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementApi
{
    public class EmployeeDb
    {
       public static List<Employee> employees = new List<Employee>()
        {
            new Employee(){EmployeeId=1,Name="Rahul",Salary=600000,Age=21,ManagerId=2},
            new Employee(){EmployeeId=2,Name="Vikram",Salary=600000,Age=23},
            new Employee(){EmployeeId=3,Name="Raunak",Salary=300000,Age=20,ManagerId=1},
            new Employee(){EmployeeId=4,Name="Deepak",Salary=300000,Age=20,ManagerId=2},
            new Employee(){EmployeeId=5,Name="Rohit",Salary=300000,Age=20,ManagerId=2}
        };
    }
}
