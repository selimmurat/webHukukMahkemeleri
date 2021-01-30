using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HukukMahkemeleriWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeUnitRolesController : ControllerBase
    {
        IEmployeeUnitRoleService _employeeUnitRoleService;

        public EmployeeUnitRolesController(IEmployeeUnitRoleService employeeUnitRoleService)
        {
            _employeeUnitRoleService = employeeUnitRoleService;
        }

        [HttpGet("getAll")]
        public IActionResult getAll()
        {
            return Ok(_employeeUnitRoleService.GetAll());
        }

        [HttpGet("getUnitRoleDetailDTO/{employeeId}")]
        public IActionResult GetByEmployeeId(int employeeId)
        {
            return Ok(_employeeUnitRoleService.getUnitRoleDetailDTO(employeeId));
        }
    }
}
