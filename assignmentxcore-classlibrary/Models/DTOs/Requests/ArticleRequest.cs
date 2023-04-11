using assignmentxcore_classlibrary.Factories;
using assignmentxcore_classlibrary.Interfaces;
using assignmentxcore_classlibrary.Models.BaseModels;
using assignmentxcore_classlibrary.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentxcore_classlibrary.Models.DTOs.Requests
{
    public class ArticleRequest : IArticleRequest
    {
        public List<int> AuthorIds { get; set; } = null!;
        public List<int> TagIds { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int ContentTypeId { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public DateTime? DateUpdated { get; set; } 

        public static implicit operator ArticleEntity(ArticleRequest req)
        {
            var entity = ArticleFactory.CreateArticleEntity();

            entity.Title = req.Title;
            entity.Description = req.Description;
            entity.ContentTypeId = req.ContentTypeId;
            entity.DateCreated = req.DateCreated = DateTime.Now;
            entity.DateUpdated = req.DateUpdated;
            return entity;
        }

    }
}
