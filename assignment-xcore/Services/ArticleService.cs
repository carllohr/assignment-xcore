using assignment_xcore.Repositories;
using assignmentxcore_classlibrary.Factories;
using assignmentxcore_classlibrary.Models.DTOs.Requests;
using assignmentxcore_classlibrary.Models.DTOs.Responses;
using assignmentxcore_classlibrary.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace assignment_xcore.Services
{
    public class ArticleService
    {
        private readonly ArticleRepository _articleRepo;
        private readonly ArticleAuthorRepository _articleAuthorRepo;
        private readonly ArticleTagRepository _articleTagRepo;

        public ArticleService(ArticleRepository articleRepo, ArticleAuthorRepository articleAuthorRepo, ArticleTagRepository articleTagRepo)
        {
            _articleRepo = articleRepo;
            _articleAuthorRepo = articleAuthorRepo;
            _articleTagRepo = articleTagRepo;
        }

        public async Task<IEnumerable<ArticleResponse>> GetAll()
        {
            var list = await _articleRepo.GetAll();
            var resList = new List<ArticleResponse>();
            foreach(var item in list)
            {
                resList.Add(item);
            }
            return resList;
        }

        public async Task<ArticleResponse> CreateArticle(ArticleRequest req)
        {
            try
            {

                ArticleEntity entity = await _articleRepo.Create(req);

                foreach (var id in req.AuthorIds)
                {
                    var articleRow = ArticleAuthorFactory.Create(entity.Id, id);
                    await _articleAuthorRepo.CreateAsync(articleRow);
                }

                foreach (var tagId in req.TagIds)
                {
                    var tagRow = ArticleTagFactory.CreateArticleTagEntity(entity.Id, tagId);
                    await _articleTagRepo.CreateAsync(tagRow);
                }
                await _articleRepo.LoadAuthors(entity);
                await _articleRepo.LoadTags(entity);
                ArticleResponse res = await _articleRepo.Get(entity.Id);
                return res;

            }
            catch (Exception ex)
            {
                return null!;
            }
        }


    }
}

