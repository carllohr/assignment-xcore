using assignmentxcore_classlibrary.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentxcore_classlibrary.Interfaces
{
    public interface IArticleRequest : IArticle
    {
        public List<int> AuthorIds { get; set; }
        public List<int> TagIds { get; set; }
    }
}
