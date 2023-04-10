using assignment_xcore.Repositories;
using assignmentxcore_classlibrary.Models.DTOs.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace assignment_xcore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagController : ControllerBase
    {
        private readonly TagRepository _tagRepo;

        public TagController(TagRepository tagRepo)
        {
            _tagRepo = tagRepo;
        }

        [HttpPost]
        public async Task<IActionResult> Create(TagRequest req)
        {
            if(req != null)
            {
                var result = await _tagRepo.CreateAsync(req);
                if (result)
                {
                    return new OkResult();
                }
                return new BadRequestResult();
            }
            return new BadRequestResult();
        }
    }
}
