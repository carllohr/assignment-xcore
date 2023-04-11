using assignmentxcore_classlibrary.Interfaces;
using assignmentxcore_classlibrary.Models.BaseModels;
using assignmentxcore_classlibrary.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentxcore_classlibrary.Models.DTOs.Responses
{
    public class AuthorResponse : Author
    {
        public ICollection<string> Articles { get; set; } = null!;
    }
}
