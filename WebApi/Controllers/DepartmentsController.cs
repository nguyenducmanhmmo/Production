using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DepartmentsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(DepartmentStatic.GetAllDepartments());
        }
        [HttpGet("{code}")]
        public IActionResult GetA(string code)
        {
            return Ok(DepartmentStatic.GetDepartment(code));
        }

        [HttpPost()]
        public IActionResult Insert()
        {
            return Ok();
        }

        [HttpPut()]
        public IActionResult Update()
        {
            return Ok();
        }

        [HttpDelete()]
        public IActionResult Delete()
        {
            return Ok();
        }
    }

    public static class DepartmentStatic
    {
        public static List<Department> AllDepartments { get; set; } = new List<Department>();

        public static List<Department> GetAllDepartments()
        {
            return AllDepartments;
        }

        public static Department GetDepartment(string code)
        {
            return AllDepartments.Where(x => x.Code == code).FirstOrDefault();
        }
    }
}

