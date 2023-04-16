using assignment_xcore.Repositories;
using assignmentxcore_classlibrary.Factories;
using assignmentxcore_classlibrary.Models.DTOs.Requests;
using assignmentxcore_classlibrary.Models.DTOs.Responses;
using assignmentxcore_classlibrary.Models.Entities;

namespace assignment_xcore.Services;

public class ArticleRowService
{
    private readonly ArticleAuthorRepository _articleAuthorRepo;
    private readonly ArticleTagRepository _articleTagRepo;
    private readonly ArticleRepository _articleRepo;

    public ArticleRowService(ArticleAuthorRepository articleAuthorRepo, ArticleTagRepository articleTagRepo, ArticleRepository articleRepo)
    {
        _articleAuthorRepo = articleAuthorRepo;
        _articleTagRepo = articleTagRepo;
        _articleRepo = articleRepo;
    }

    public async Task<bool> CreateArticleRows(ArticleEntity entity, ArticleRequest req)
    {
        try
        {
            
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

            return true;
           

        }
        catch (Exception ex)
        {
            return false!;
        }
    }

}
