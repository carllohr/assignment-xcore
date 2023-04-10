using assignmentxcore_classlibrary.Factories;
using assignmentxcore_classlibrary.Interfaces;
using assignmentxcore_classlibrary.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentxcore_classlibrary.Models.DTOs.Requests
{
    public class AuthorRequest : IAuthorRequest
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set;} = null!;
        public string Email { get; set; } = null!;

        public static implicit operator AuthorEntity(AuthorRequest req)
        {
            var entity = AuthorFactory.CreateAuthorEntity();
            entity.FirstName = req.FirstName;
            entity.LastName = req.LastName;
            entity.Email = req.Email;
            return entity;
        }
    }
}
