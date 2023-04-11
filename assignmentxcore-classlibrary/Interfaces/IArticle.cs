using assignmentxcore_classlibrary.Models.BaseModels;
using Azure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentxcore_classlibrary.Interfaces
{
    public interface IArticle
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int ContentTypeId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }

    }
}
