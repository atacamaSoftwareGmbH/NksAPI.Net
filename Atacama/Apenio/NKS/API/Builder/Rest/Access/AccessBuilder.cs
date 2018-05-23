using Atacama.Apenio.NKS.API;

namespace NksAPI.Atacama.Apenio.NKS.API.Builder.Rest.Access
{
    public class AccessBuilder
    {
        private string path;

        internal AccessBuilder(string path)
        {
            this.path = this.path;
            this.path += NksRestAttributes.access;
        }

        public QueryBuilder Element()
        {
            return new QueryBuilder(Type.POST,path + NksRestAttributes.element);
        }
    }
}