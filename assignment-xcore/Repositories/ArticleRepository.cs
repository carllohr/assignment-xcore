using assignment_xcore.Contexts;
using assignmentxcore_classlibrary.Factories;
using assignmentxcore_classlibrary.Models.DTOs.Requests;
using assignmentxcore_classlibrary.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace assignment_xcore.Repositories
{
    public class ArticleRepository
    {
        private readonly DataContext _context;

        public ArticleRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<ArticleEntity> Create(ArticleRequest req)
        {
            try
            {
                ArticleEntity entity = req;
                _context.Articles.Add(entity);
                await _context.SaveChangesAsync();
                return entity;
            }
            catch (Exception ex) { return null!;}
            
        }

        public async Task<IEnumerable<ArticleEntity>> GetAll()
        {
            try
            {
                return await _context.Articles.ToListAsync();
            }
            catch (Exception ex) { return null!;}
        }
    }
}
