using assignment_xcore.Services;
using assignmentxcore_classlibrary.Models.DTOs.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace assignment_xcore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private readonly ArticleService _articleService;

        public ArticleController(ArticleService articleService)
        {
            _articleService = articleService;
        }
        [HttpPost]
        public async Task<IActionResult> Create(ArticleRequest req)
        {
            await _articleService.CreateArticle(req);
            return Ok();
        }
    }
}
