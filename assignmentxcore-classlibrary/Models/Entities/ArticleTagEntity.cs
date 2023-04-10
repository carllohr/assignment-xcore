using Microsoft.Extensions.Logging.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentxcore_classlibrary.Models.Entities
{
    public class ArticleTagEntity
    {
        public int ArticleId { get; set; }
        public ArticleEntity Article { get; set; } = null!;
        public int TagId { get; set; }
        public TagEntity Tag { get; set; } = null!;
    }
}
