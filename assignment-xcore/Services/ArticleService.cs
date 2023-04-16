using assignment_xcore.Repositories;
using assignmentxcore_classlibrary.Factories;
using assignmentxcore_classlibrary.Models.DTOs.Requests;
using assignmentxcore_classlibrary.Models.DTOs.Responses;
using assignmentxcore_classlibrary.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Reflection;

namespace assignment_xcore.Services
{
    public class ArticleService
    {
        private readonly ArticleRepository _articleRepo;
        private readonly ArticleAuthorRepository _articleAuthorRepo;
        private readonly ArticleTagRepository _articleTagRepo;
        private readonly ArticleRowService _articleRowService;

        public ArticleService(ArticleRepository articleRepo, ArticleAuthorRepository articleAuthorRepo, ArticleTagRepository articleTagRepo, ArticleRowService articleRowService)
        {
            _articleRepo = articleRepo;
            _articleAuthorRepo = articleAuthorRepo;
            _articleTagRepo = articleTagRepo;
            _articleRowService = articleRowService;
        }

        public async Task<IEnumerable<ArticleResponse>> GetAll()
        {
            var list = await _articleRepo.GetAllAsync();
            var resList = ArticleFactory.CreateArticleResponseList();
            foreach(var item in list)
            {
                resList.Add(item);
            }
            return resList;
        }

        public async Task<IEnumerable<ArticleResponse>> SortByContentType(int id)
        {
            var list = await _articleRepo.GetAllAsync();
            var resList = ArticleFactory.CreateArticleResponseList();
            foreach(var item in list)
            {
                resList.Add(item);
            }
            return resList.Where(x => x.ContentTypeId == id);
        }

        public async Task<IEnumerable<ArticleResponse>> SortByInput(string sortBy)
        {
            var list = await _articleRepo.GetAllAsync();
            var resList = ArticleFactory.CreateArticleResponseList();
            foreach (var item in list)
            {
                resList.Add(item);
            }
            switch(sortBy)
            {
                case "Title":
                    return resList.OrderBy(x => x.Title);
                case "Date":
                    return resList.OrderBy(x => x.DateCreated);
                case "ContentType":
                    return resList.OrderBy(x => x.ContentTypeId);
                default:
                    return resList.OrderBy(x => x.Id);
            }
        }

        public async Task<ArticleResponse> GetByIdAsync(int id)
        {
            var res = await _articleRepo.GetAsync(id);
            return res;
        }
        
        public async Task<bool> DeleteAsync(int id)
        {
            var entity = await _articleRepo.GetAsync(id);
            return await _articleRepo.DeleteAsync(entity);
        }

        public async Task<ArticleResponse> UpdateAsync(int id, ArticleRequest req)
        {
            var entity = await _articleRepo.Update(id, req);
            await _articleRowService.CreateArticleRows(entity, req);
            ArticleResponse res = await _articleRepo.GetAsync(entity.Id);
            return res;

        }

        public async Task<ArticleResponse> CreateArticle(ArticleRequest req)
        {
            try
            {
                ArticleEntity entity = await _articleRepo.Create(req);
                await _articleRowService.CreateArticleRows(entity, req);
                ArticleResponse res = await _articleRepo.GetAsync(entity.Id);
                return res;
            }
            catch (Exception ex)
            {
                return null!;
            }
        }


    }
}

