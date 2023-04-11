using assignment_xcore.Services;
using assignmentxcore_classlibrary.Models.DTOs.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace assignment_xcore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContentTypeController : ControllerBase
    {
        private readonly ContentTypeService _contentTypeService;

        public ContentTypeController(ContentTypeService contentTypeService)
        {
            _contentTypeService = contentTypeService;
        }

        [HttpPost]
        public async Task<IActionResult> Create(ContentTypeRequest req)
        {
            if(req != null)
            {
                var res = await _contentTypeService.Create(req);
                return Created("", res);
            }
            return BadRequest();
        }
    }
}
