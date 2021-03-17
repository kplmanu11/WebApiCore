using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiCORE.IServices;
using WebApiCORE.Models;

namespace WebApiCORE.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly EmployeeContext _Db;

        public EmployeeService(EmployeeContext db)
        {
            _Db = db;

        }
        public IEnumerable<Employee> GetEmployee()
        {
            var employeeList = _Db.tbl_Employee.ToList();
            return employeeList;


        }

        public Employee AddEmplyee(Employee emp)
        {
            if (emp != null)
            {
                _Db.tbl_Employee.Add(emp);
                _Db.SaveChanges();
                return emp;
            }
            return null;

        }

        public Employee UpdateEmployee(Employee emp)
        {
            _Db.Entry(emp).State = EntityState.Modified;
            _Db.SaveChanges();
            return emp;
        }

        public Employee DeleteEmployee(int id)
        {
            var employee = _Db.tbl_Employee.FirstOrDefault(x => x.ID == id);
            _Db.Entry(employee).State = EntityState.Deleted;
            _Db.SaveChanges();
            return employee;

        }

        public Employee GetEmployeeById(int id)
        {
            var employee = _Db.tbl_Employee.FirstOrDefault(x => x.ID == id);
            return employee;
        }
    }
    }
