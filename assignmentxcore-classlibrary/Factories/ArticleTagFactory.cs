using assignmentxcore_classlibrary.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentxcore_classlibrary.Factories
{
    public class ArticleTagFactory
    {
        public static ArticleTagEntity CreateArticleTagEntity(int articleId, int tagId)
        {
            return new ArticleTagEntity { ArticleId = articleId, TagId = tagId };
        }
    }
}
