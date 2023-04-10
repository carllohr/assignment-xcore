using assignmentxcore_classlibrary.Interfaces;
using assignmentxcore_classlibrary.Models.BaseModels;
using assignmentxcore_classlibrary.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentxcore_classlibrary.Models.DTOs.Responses
{
    public class ArticleResponse : Article, IArticleResponse
    {
        public List<AuthorResponse> Authors { get; set; } = null!;
        public List<TagResponse> Tags { get; set; } = null!;
        public ContentTypeEntity ContentType { get; set; } = null!;
    }
}
