using assignment_xcore.Contexts;
using assignmentxcore_classlibrary.Models.Entities;

namespace assignment_xcore.Repositories
{
    public class ArticleTagRepository
    {
        private readonly DataContext _context;

        public ArticleTagRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateAsync(ArticleTagEntity entity)
        {
            try
            {
                _context.ArticleTags.Add(entity);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex) { return false; }
        }
    }
}
