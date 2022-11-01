using Computer_Backend.Models;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace Computer_Backend.Interfaces
{
    public interface IArticleService
    {
        List<Article> GetArticles();

        Article AddArticle(Article article);

        Article UpdateArticle(int articleId, Article article);

        void DeleteArticle(int id);

        Article GetArticleById(int id);

    }
}
