﻿using APICrud.Models;
using APICrud.EmployeeData;
using Microsoft.AspNetCore.Mvc;
using System;

namespace APICrud.Controllers
{
    
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private IEmployeeData _employeeData;
        public EmployeesController(IEmployeeData employeeData)
        {
            _employeeData = employeeData;
        }

        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetEmployees() {
            return Ok(_employeeData.GetEmployees());
        }

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult GetEmployees(Guid id) {
            var employee = _employeeData.GetEmployee(id);
            if(employee != null) {
                return Ok(employee);
            }
            return NotFound($"Employee with is: {id} was not found ");
        }

        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult GetEmployee(Employee employee) {
            _employeeData.AddEmployee(employee);
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" + employee.Id,
                employee);
        }
    }
}
