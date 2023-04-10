using assignmentxcore_classlibrary.Factories;
using assignmentxcore_classlibrary.Interfaces;
using assignmentxcore_classlibrary.Models.Entities;
using Azure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentxcore_classlibrary.Models.DTOs.Requests
{
    public class TagRequest : ITag
    {
        public string TagName { get; set; } = null!;

        public static implicit operator TagEntity(TagRequest req)
        {
            var entity = TagFactory.CreateTagEntity();
            entity.TagName = req.TagName;
            return entity;
        }
    }
}
