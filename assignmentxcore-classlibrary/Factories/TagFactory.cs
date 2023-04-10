using assignmentxcore_classlibrary.Models.DTOs.Responses;
using assignmentxcore_classlibrary.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentxcore_classlibrary.Factories
{
    public class TagFactory
    {

        public static TagEntity CreateTagEntity()
        {
            return new TagEntity();
        }

        public static TagResponse CreateTagResponse()
        {
            return new TagResponse();
        }
    }
}
