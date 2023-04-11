using assignmentxcore_classlibrary.Models.DTOs.Requests;
using assignmentxcore_classlibrary.Models.DTOs.Responses;
using assignmentxcore_classlibrary.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentxcore_classlibrary.Factories
{
    public class ContentTypeFactory
    {
        public static ContentTypeEntity CreateContentTypeEntity()
        {
            return new ContentTypeEntity();
        }
        public static ContentTypeResponse CreateContentTypeResponse()
        {
            return new ContentTypeResponse();
        }
    }
}
