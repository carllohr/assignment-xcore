using assignmentxcore_classlibrary.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentxcore_classlibrary.Factories
{
    public class ArticleAuthorFactory
    {
        public static ArticleAuthorEntity Create(int articleId, int authorId)
        {
            return new ArticleAuthorEntity { ArticleId = articleId, AuthorId = authorId };
        }
    }
}
