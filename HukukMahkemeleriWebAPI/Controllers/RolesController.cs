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
    public class RolesController : ControllerBase
    {
        IRoleService _roleService;

        public RolesController(IRoleService roleService)
        {
            _roleService = roleService;
        }
        [HttpGet("getAll")]
        public IActionResult getAll()
        {
            return Ok(_roleService.GetAll());
        }
        [HttpGet("GetByRolId/{rolId}")]
        public IActionResult GetByRolId(int rolId)
        {
            return Ok(_roleService.GetByRolId(rolId));
        }
        [HttpGet("GetByRolName/{roleName}")]
        public IActionResult GetByRolName(string roleName)
        {
            return Ok(_roleService.GetByRolName(roleName));
        }
    }
}
