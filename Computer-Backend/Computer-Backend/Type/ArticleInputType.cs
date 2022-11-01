using Computer_Backend.Models;
using GraphQL.Types;

namespace Computer_Backend.Type
{
    public class ArticleInputType : InputObjectGraphType
    {
        public ArticleInputType()
        {
            Field<IntGraphType>("id");
            Field<StringGraphType>("name");
            Field<StringGraphType>("text");
            Field<StringGraphType>("description");
            Field<DateTimeGraphType>("createdAt");
            Field<DateTimeGraphType>("updatedAt");
        }
    }
}
