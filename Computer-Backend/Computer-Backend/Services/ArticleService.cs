using Computer_Backend.Interfaces;
using Computer_Backend.Models;
using System.Collections.Generic;

namespace Computer_Backend.Services
{
    public class ArticleService : IArticleService
    {
        private static List<Article> _articles = new List<Article>()
        {
            new Article() { Id = 0, Name = "Entity", Description = "None" },
            new Article() { Id = 1, Name = "JS", Description = "None" },
            new Article() { Id = 2, Name = "TS", Description = "None" },
            new Article() { Id = 3, Name = "C#" },
        };
        public Article AddArticle(Article article)
        {
            _articles.Add(article);
            return article;
        }

        public void DeleteArticle(int id)
        {
            _articles.RemoveAll(x => x.Id == id);
        }

        public Article GetArticleById(int id)
        {
            return _articles.Find(x => x.Id == id);
        }

        public List<Article> GetArticles()
        {
            return _articles;
        }

        public Article UpdateArticle(int articleId, Article article)
        {
            int ind = _articles.FindIndex(x => x.Id == articleId);
            if (ind == -1)
            {
                return article;
            }
            var prev = _articles[ind];
            _articles[ind] = article;
            return prev;
        }
    }
}
