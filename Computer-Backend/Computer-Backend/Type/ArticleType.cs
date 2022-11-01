using Computer_Backend.Models;
using GraphQL.Types;
using System.Xml.Xsl;

namespace Computer_Backend.Type
{
    public class ArticleType : ObjectGraphType<Article>

    {
        public ArticleType()
        {
            Field(a => a.Id);
            Field(a => a.Name);
            Field(a => a.Description);
            Field(a => a.UpdatedAt);
            Field(a => a.CreatedAt);
        }    
    }
}
