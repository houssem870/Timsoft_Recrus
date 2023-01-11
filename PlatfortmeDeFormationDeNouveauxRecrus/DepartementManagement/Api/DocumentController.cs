using Microsoft.AspNetCore.Mvc;
using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Entities.DTO;
using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Services;

namespace PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Api
{

    [Route("api/[controller]")]
    [ApiController]
    public class DocumentController : ControllerBase
    {
        private readonly IDocumentService _documentService;
        public DocumentController(IDocumentService documentService)
        {

            _documentService = documentService;

        }

        [HttpPost]
        [Route("AddDocument")]
        public IActionResult AddDepartement(DocumentDTO document)
        {



            return Ok(_documentService.AddDocument(document));

        }



    }
}