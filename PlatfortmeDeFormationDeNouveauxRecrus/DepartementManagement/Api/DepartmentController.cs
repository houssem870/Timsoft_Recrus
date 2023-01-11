using Microsoft.AspNetCore.Mvc;
using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Entities;
using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Services;

namespace PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentService _departmentService;
        public DepartmentController(IDepartmentService departementService)
        {

            _departmentService = departementService;

        }

        [HttpPost]
        [Route("AddDepartement")]
        public IActionResult AddDepartement(string DepartementName)
        {
            return Ok(_departmentService.AddDepartement(DepartementName));
        }

        [HttpPut]
        [Route("UpdateDepartmentById")]

        public IActionResult UpdateDepartementById([FromBody] Departement department, int id)
        {
            return Ok(_departmentService.updateDepartmentById(department, id));
        }
        [HttpDelete]
        [Route("DeleteById")]

        public IActionResult RemoveDepartment(int id)
        {
            return Ok(_departmentService.RemoveDepartement(id));


        }
    }
}

