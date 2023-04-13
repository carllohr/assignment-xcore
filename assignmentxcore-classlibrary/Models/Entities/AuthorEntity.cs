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
    public class AuthorEntity : Author
    {
        public ICollection<ArticleAuthorEntity>? ArticleAuthor { get; set; }

        public static implicit operator AuthorResponse(AuthorEntity entity)
        {
            var res = AuthorFactory.CreateAuthorResponse();
            res.Id = entity.Id;
            res.FirstName = entity.FirstName;
            res.LastName = entity.LastName;
            res.Email = entity.Email;
            return res;
        }
    }
}
