using Computer_Backend.Data;
using Computer_Backend.Interfaces;
using Computer_Backend.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Computer_Backend.Services
{
    public class ArticleService : IArticleService
    {
        private static ShopDBContext _dbContext;

        public ArticleService(ShopDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Article AddArticle(Article article)
        {
            _dbContext.Articles.Add(article);
            _dbContext.SaveChanges();
            return article;
        }

        public void DeleteArticle(int id)
        {
            _dbContext.Articles.Remove(_dbContext.Articles.Find(id));
            _dbContext.SaveChanges();
        }

        public Article GetArticleById(int id)
        {
            return _dbContext.Articles.SingleOrDefault(x => x.Id == id);
        }

        public List<Article> GetArticles()
        {
            return _dbContext.Articles.AsNoTracking().ToList();
        }

        public Article UpdateArticle(int articleId, Article article)
        {
            _dbContext.Articles.Update(article);
            _dbContext.SaveChanges();
            return article;
        }
    }
}
