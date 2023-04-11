using assignmentxcore_classlibrary.Factories;
using assignmentxcore_classlibrary.Models.BaseModels;
using assignmentxcore_classlibrary.Models.DTOs.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentxcore_classlibrary.Models.Entities
{
    public class ContentTypeEntity : ContentType
    {
        public static implicit operator ContentTypeResponse(ContentTypeEntity entity)
        {
            var res = ContentTypeFactory.CreateContentTypeResponse();
            res.Id = entity.Id;
            res.ContentTypeName = entity.ContentTypeName;
            return res;
        }
    }
}
