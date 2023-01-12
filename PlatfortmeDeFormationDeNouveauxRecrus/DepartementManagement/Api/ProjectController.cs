using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Entities;
using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Services;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly IProjectService projectService;
        
       public ProjectController(IProjectService projectService)
        {
            this.projectService = projectService;   
        }

        [HttpPost]
        [Route("AddProject")]
        public IActionResult AddProject([FromBody] string Description)
        {
            return Ok(projectService.AddProject(Description));
        }
      

    }
}
