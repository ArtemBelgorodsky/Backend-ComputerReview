using Computer_Backend.Interfaces;
using Computer_Backend.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Computer_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private IArticleService _articleService;

        public ArticleController(IArticleService articleService)
        {
            this._articleService = articleService;
        }


        // GET: api/<ArticleController>
        [HttpGet]
        public IEnumerable<Article> Get()
        {
            return _articleService.GetArticles();
        }

        // GET api/<ArticleController>/5
        [HttpGet("{id}")]
        public Article Get(int id)
        {
            return _articleService.GetArticleById(id);
        }

        // POST api/<ArticleController>
        [HttpPost]
        public Article Post([FromBody] Article article)
        {
            return _articleService.AddArticle(article);
        }

        // PUT api/<ArticleController>/5
        [HttpPut("{id}")]
        public Article Put(int id, [FromBody] Article value)
        {
            return _articleService.UpdateArticle(id, value);
        }

        // DELETE api/<ArticleController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _articleService.DeleteArticle(id);
        }
    }
}
