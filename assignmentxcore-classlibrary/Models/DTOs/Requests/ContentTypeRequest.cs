using assignmentxcore_classlibrary.Factories;
using assignmentxcore_classlibrary.Interfaces;
using assignmentxcore_classlibrary.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentxcore_classlibrary.Models.DTOs.Requests
{
    public class ContentTypeRequest : IContentType
    {
        public string ContentTypeName { get; set; } = null!;

        public static implicit operator ContentTypeEntity(ContentTypeRequest req)
        {
            var entity = ContentTypeFactory.CreateContentTypeEntity();
            entity.ContentTypeName = req.ContentTypeName;
            return entity;
        }
    }
}
