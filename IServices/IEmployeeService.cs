using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiCORE.Models;

namespace WebApiCORE.IServices
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetEmployee();
        Employee GetEmployeeById(int id);
        Employee AddEmplyee(Employee emp);
        Employee UpdateEmployee(Employee emp);
        Employee DeleteEmployee(int id);


    }
}
