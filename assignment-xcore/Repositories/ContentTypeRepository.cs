using assignment_xcore.Contexts;
using assignmentxcore_classlibrary.Models.DTOs.Requests;
using assignmentxcore_classlibrary.Models.Entities;

namespace assignment_xcore.Repositories
{
    public class ContentTypeRepository
    {
        private readonly DataContext _context;

        public ContentTypeRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<ContentTypeEntity> Create(ContentTypeRequest req)
        {
            try
            {
                ContentTypeEntity entity = req;
                _context.ContentTypes.Add(entity);
                await _context.SaveChangesAsync();
                return entity;
            }
            catch (Exception ex)
            {
                return null!;
            }
        }
        public async Task<bool> LoadContentType(ContentTypeEntity entity)
        {
            try
            {
                await _context.Entry(entity)
                    .GetDatabaseValuesAsync();
                return true;
            }
            catch (Exception ex) { return false; }
        }
    }
}
