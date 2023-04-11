using assignment_xcore.Services;
using assignmentxcore_classlibrary.Models.DTOs.Requests;
using assignmentxcore_classlibrary.Models.DTOs.Responses;
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
            ArticleResponse res = await _articleService.CreateArticle(req);
            return Created("", res);
        }
        [HttpGet]
        public async Task<IEnumerable<ArticleResponse>> ReadAll()
        {
            return await _articleService.GetAll();
        }
    }
}
