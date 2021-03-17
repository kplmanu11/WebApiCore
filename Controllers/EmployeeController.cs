using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiCORE.IServices;
using WebApiCORE.Models;

namespace WebApiCORE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService empService;
        public EmployeeController(IEmployeeService empServ)
        {
            empService = empServ;

        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/Employee/GetEmployee")]
        public IEnumerable<Employee> GetEmployee()
        {
            return empService.GetEmployee();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/Employee/AddEmployee")]
        public Employee AddEmployee(Employee emp)
        {
            return empService.AddEmplyee(emp);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/Employee/EditEmployee")]
        public Employee EditEmployee(Employee emp)
        {
            return empService.UpdateEmployee(emp);
        }
         

        [HttpDelete]
        [Route("[action]")]
        [Route("api/Employee/DeleteEmployee")]
        public Employee DeleteEmployee(int id)
        {
            return empService.DeleteEmployee(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/Employee/GetEmployeeID")]
        public Employee GetEmployeeID(int id)
        {
            return empService.GetEmployeeById(id);
        }

    }
}