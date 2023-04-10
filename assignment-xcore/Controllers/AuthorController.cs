using assignment_xcore.Repositories;
using assignment_xcore.Services;
using assignmentxcore_classlibrary.Models.DTOs.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace assignment_xcore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly AuthorService _authorService;

        public AuthorController(AuthorService authorService)
        {
            _authorService = authorService;
        }

        [HttpPost]
        public async Task<IActionResult> Create(AuthorRequest req)
        {
            if(req != null)
            {
                await _authorService.CreateAsync(req);
                return new OkResult();
            }
            return new BadRequestResult();
        }
    }
}
