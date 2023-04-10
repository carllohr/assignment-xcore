using assignment_xcore.Repositories;
using assignmentxcore_classlibrary.Models.DTOs.Requests;
using assignmentxcore_classlibrary.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace assignment_xcore.Services
{
    public class AuthorService
    {
        private readonly AuthorRepository _authorRepo;

        public AuthorService(AuthorRepository authorRepo)
        {
            _authorRepo = authorRepo;
        }

        public async Task<IActionResult> CreateAsync(AuthorRequest req)
        {
            if(req != null)
            {
                var author = await _authorRepo.CreateAsync(req);
                if(author != null)
                {
                    return new OkResult();
                }
            }

            return new BadRequestResult();
        }

        public async Task<IEnumerable<AuthorResponse>> GetAll()
        {
            var list = await _authorRepo.GetAll();
        }
    }
}
