using Atacama.Apenio.NKS.API;

namespace NksAPI.Atacama.Apenio.NKS.API.Builder.Rest.LongTerm
{
    public class LongTermBuilder
    {
        private string path;

        public LongTermBuilder(string path)
        {
            this.path = path;
            this.path += NksRestAttributes.LongTerm;
        }

        public QueryBuilder Risk()
        {
            return new QueryBuilder(Type.POST,path+NksRestAttributes.Risk);
        }
        
        public QueryBuilder Intervention()
        {
            return new QueryBuilder(Type.POST,path+NksRestAttributes.InterventionProposal);
        }
    }
}