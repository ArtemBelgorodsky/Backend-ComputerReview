using Computer_Backend.Interfaces;
using Computer_Backend.Models;
using Computer_Backend.Services;
using Computer_Backend.Type;
using GraphQL;
using GraphQL.Types;

namespace Computer_Backend.Mutation
{
    public class ArticleMutation : ObjectGraphType
    {
        public ArticleMutation(IArticleService articleService)
        {
            Field<ArticleType>("createArticle", arguments: new QueryArguments(new QueryArgument<ArticleInputType> { Name = "article" }),
                resolve: context => articleService.AddArticle(context.GetArgument<Article>("article")));
            Field<ArticleType>("updateArticle", arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "id" }, new QueryArgument<ArticleInputType> { Name = "article" }),
                resolve: context => articleService.UpdateArticle(context.GetArgument<int>("id"), context.GetArgument<Article>("article")));
            Field<ArticleType>("deleteArticle", arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "id" }),
                resolve: context => {
                    articleService.DeleteArticle(context.GetArgument<int>("id"));
                    return "Article deleted";
                });
        }
    }
}
