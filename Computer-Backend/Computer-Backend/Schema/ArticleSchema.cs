using Computer_Backend.Mutation;
using Computer_Backend.Query;

namespace Computer_Backend.Schema
{
    public class ArticleSchema : GraphQL.Types.Schema
    {
        public ArticleSchema(ArticleQuery query, ArticleMutation mutation)
        {
            Query = query;
            Mutation = mutation;
        }
    }
}
