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

        public async Task<ArticleEntity> GetAsync(int id)
        {
            try
            {
                
                var entity = await _context.Articles
                    .Include(x => x.ContentType)
                    .Include(x => x.ArticleAuthors)
                    .ThenInclude(x => x.Author)
                    .Include(x => x.ArticleTags)
                    .ThenInclude(x => x.Tag)
                    .FirstOrDefaultAsync(x => x.Id == id);
                
                return entity!;
            }
            catch (Exception ex) { return null!;}
        }

        public async Task<IEnumerable<ArticleEntity>> GetAllAsync()
        {
            try
            {
                return await _context.Articles
                    .Include(x => x.ArticleAuthors).
                    ThenInclude(xx => xx.Author)
                    .Include(x => x.ArticleTags)
                    .ThenInclude(xx => xx.Tag).ToListAsync();
            }
            catch (Exception ex) { return null!;}
        }
        public async Task<ArticleEntity> Update(int id, ArticleRequest req)
        {
            try
            {
                var entity = await _context.Articles.Include(x => x.ContentType)
                    .Include(x => x.ArticleAuthors).ThenInclude(xx => xx.Author)
                    .Include(x => x.ArticleTags).ThenInclude(xx => xx.Tag)
                    .FirstOrDefaultAsync(x => x.Id == id);
                entity!.ArticleAuthors.Clear();
                entity!.ArticleTags.Clear();
                entity!.Title = req.Title;
                entity!.DateUpdated= req.DateUpdated = DateTime.Now;
                entity!.Description = req.Description;
                entity!.ContentTypeId = req.ContentTypeId;
                _context.Articles.Update(entity);
                await _context.SaveChangesAsync();
                return entity;
            } 
            catch(Exception ex) 
            { return null!; }
            
             

        }
        public async Task<bool> LoadAuthors(ArticleEntity entity)
        {
            try
            {
                await _context.Entry(entity)
                    .Collection(ae => ae.ArticleAuthors)
                    .Query()
                    .Include(aa => aa.Author)
                    .LoadAsync();
                return true;
            }
            catch (Exception ex) { return false; }
        }

        public async Task<bool> LoadTags(ArticleEntity entity)
        {
            try
            {
                await _context.Entry(entity)
                    .Collection(ae => ae.ArticleTags)
                    .Query()
                    .Include(at => at.Tag)
                    .LoadAsync();
                return true;
            }
            catch (Exception ex) { return false; }
        }
    }
}
