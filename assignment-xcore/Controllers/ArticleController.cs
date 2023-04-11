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
        [HttpGet("sorted")]
        public async Task<IEnumerable<ArticleResponse>> ReadSorted()
        {
            return await _articleService.SortByContentType();
        }

        [HttpGet("{id}")]
        public async Task<ArticleResponse> Read(int id)
        {
            if (id != 0)
            {
                return await _articleService.GetByIdAsync(id);
            }
            return null!;
                
        }
        [HttpPut("{id}")]
        public async Task<ArticleResponse> Update(int id, ArticleRequest req)
        {
            if (req != null) 
            {
                return await _articleService.UpdateAsync(id, req);
            }
            return null!;
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (id != 0)
            {
                var result = await _articleService.DeleteAsync(id);
                if (result)
                {
                    return Ok();
                }
                return BadRequest();
            }
            return BadRequest();
        }
    }
}
