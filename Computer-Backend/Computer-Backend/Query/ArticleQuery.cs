using Computer_Backend.Interfaces;
using Computer_Backend.Type;
using GraphQL;
using GraphQL.Types;
using System;

namespace Computer_Backend.Query
{
    public class ArticleQuery: ObjectGraphType
    {
        public ArticleQuery(IArticleService articleService)
        {
            Field<ListGraphType<ArticleType>>("products", resolve: context => articleService.GetArticles());
            Field<ArticleType>("product", arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "id" }),
                resolve: context => articleService.GetArticleById(context.GetArgument<int>("id")));
        }
    }
}
