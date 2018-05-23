using System.Linq;
using NksAPI.Atacama.Apenio.NKS.API.Builder.Rest;

namespace Atacama.Apenio.NKS.API
{
    public class SimpleQueryBuilder : Executor
    {
        public SimpleQueryBuilder(Type type, string path) : base(type,path)
        {}

        public AttributeBuilder AddAttributes()
        {
            return new AttributeBuilder(Query,this);
        }
    }
}