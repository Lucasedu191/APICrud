using APICrud.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace APICrud.EmployeeData {
    public class SqlEmployeeData : IEmployeeData {

        private EmployeeContext _employeeContext;
        public SqlEmployeeData(EmployeeContext employeeContext) {
            _employeeContext = employeeContext;
        }
        public Employee AddEmployee(Employee employee) {
            
        }

        public void DeleteEmployee(Employee employee) {
            throw new NotImplementedException();
        }

        public Employee EditEmployee(Employee employee) {
            throw new NotImplementedException();
        }

        public Employee GetEmployee(Guid id) {
            var employee = _employeeContext.Employees.Find(id);
            return employee;
        }

        public List<Employee> GetEmployees() {
            return _employeeContext.Employees.ToList();
        }
    }
}
