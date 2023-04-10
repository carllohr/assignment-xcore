using assignment_xcore.Contexts;
using assignmentxcore_classlibrary.Models.DTOs.Requests;
using assignmentxcore_classlibrary.Models.Entities;

namespace assignment_xcore.Repositories
{
    public class TagRepository
    {
        private readonly DataContext _context;

        public TagRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateAsync(TagRequest req)
        {
            try
            {
                var tagEntity = req;
                _context.Tags.Add(tagEntity);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
