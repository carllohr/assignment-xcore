using assignment_xcore.Contexts;
using assignmentxcore_classlibrary.Models.Entities;
using System.Diagnostics;

namespace assignment_xcore.Repositories
{
    public class ArticleAuthorRepository
    {
        private readonly DataContext _context;

        public ArticleAuthorRepository(DataContext context)
        {
            _context = context;
        }

        public async Task <bool> CreateAsync(ArticleAuthorEntity entity)
        {
            try
            {
                _context.ArticleAuthors.Add(entity);
                await _context.SaveChangesAsync();
                return true;
                
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);    
                return false;
            }
        }
    }
}
