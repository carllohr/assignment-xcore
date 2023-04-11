using assignment_xcore.Repositories;
using assignmentxcore_classlibrary.Models.DTOs.Requests;
using assignmentxcore_classlibrary.Models.DTOs.Responses;

namespace assignment_xcore.Services
{
    public class ContentTypeService
    {
        private readonly ContentTypeRepository _contentTypeRepo;

        public ContentTypeService(ContentTypeRepository contentTypeRepo)
        {
            _contentTypeRepo = contentTypeRepo;
        }

        public async Task<ContentTypeResponse> Create(ContentTypeRequest req)
        {
            var entity = await _contentTypeRepo.Create(req);
            await _contentTypeRepo.LoadContentType(entity);
            ContentTypeResponse res = entity;
            return res;
            
        }
    }
}
