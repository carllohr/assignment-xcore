using assignmentxcore_classlibrary.Factories;
using assignmentxcore_classlibrary.Models.BaseModels;
using assignmentxcore_classlibrary.Models.DTOs.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace assignmentxcore_classlibrary.Models.Entities
{
    public class ArticleEntity : Article
    {
        public ICollection<ArticleAuthorEntity> ArticleAuthors { get; set; } = null!;
        public ICollection<ArticleTagEntity> ArticleTags { get; set; } = null!;
        
        public static implicit operator ArticleResponse(ArticleEntity entity)
        {
            var res = ArticleFactory.CreateArticleResponse();
            res.Id = entity.Id;
            res.Title = entity.Title;
            res.Description= entity.Description;
            res.DateCreated = entity.DateCreated;
            res.DateUpdated = entity.DateUpdated;
            return res;
        }
    }
}
