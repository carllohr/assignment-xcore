using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentxcore_classlibrary.Models.Entities
{
    public class ArticleAuthorEntity
    {
        public int ArticleId { get; set; }
        public ArticleEntity Article { get; set; } = null!;
        public int AuthorId { get; set; }
        public AuthorEntity Author { get; set; } = null!;
    }
}
