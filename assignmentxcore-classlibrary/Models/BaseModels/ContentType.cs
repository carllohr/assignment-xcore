using assignmentxcore_classlibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentxcore_classlibrary.Models.BaseModels
{
    public abstract class ContentType : IContentType
    {
        public int Id { get; set; }
        public string ContentTypeName { get; set; } = null!;
    }
}
