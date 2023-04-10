﻿using assignmentxcore_classlibrary.Models.DTOs.Requests;
using assignmentxcore_classlibrary.Models.DTOs.Responses;
using assignmentxcore_classlibrary.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentxcore_classlibrary.Factories
{
    public class ArticleFactory
    {
        public static ArticleEntity CreateArticleEntity()
        {
            return new ArticleEntity();
        }
        public static ArticleRequest CreateArticleRequest()
        {
            return new ArticleRequest();
        }
        public static ArticleResponse CreateArticleResponse()
        {
            return new ArticleResponse();
        }
    }
}
