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
    public class TagEntity : Tag
    {
        public static implicit operator TagResponse(TagEntity entity)
        {
            var res = TagFactory.CreateTagResponse();
            res.Id = entity.Id;
            res.TagName = entity.TagName;
            return res;
        }
    }
}
