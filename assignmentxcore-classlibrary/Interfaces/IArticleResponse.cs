using assignmentxcore_classlibrary.Models.DTOs.Responses;
using assignmentxcore_classlibrary.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentxcore_classlibrary.Interfaces
{
    internal interface IArticleResponse : IArticle
    {
        public List<AuthorResponse> Authors { get; set; }
        public List<TagResponse> Tags { get; set; }
        public ContentTypeEntity ContentType { get; set; }
    }
}
