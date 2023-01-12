using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Services;
using System.Reflection.Metadata.Ecma335;

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
        [HttpPut]
        [Route("UpdateProject")]
        public IActionResult UpdateProject(
            [FromBody]
            long IdProject,
            string Description)
        {
            return Ok(projectService.UpdateProject(IdProject, Description));  
        }
        [HttpDelete]
        [Route("RemoveProject")]
        public IActionResult RemoveProject(
            [FromBody]
            long IdProject)
        {
            return Ok(projectService.RemoveProject(IdProject));
        }

    }
}
