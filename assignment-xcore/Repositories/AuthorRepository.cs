using assignment_xcore.Contexts;
using assignmentxcore_classlibrary.Models.DTOs.Requests;
using assignmentxcore_classlibrary.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace assignment_xcore.Repositories
{
    public class AuthorRepository
    {
        private readonly DataContext _context;

        public AuthorRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<AuthorEntity> CreateAsync(AuthorRequest req)
        {
            var authorEntity = req;
            if (authorEntity != null) 
            {
                _context.Authors.Add(authorEntity);
                await _context.SaveChangesAsync();
                return authorEntity;
            }

            return null!;
        }

        public async Task<IEnumerable<AuthorEntity>> GetAll()
        {
            try
            {
                return await _context.Authors.ToListAsync();
            }
            catch { return null!; }
        }
    }
}
