using Atacama.Apenio.NKS.API;

namespace NksAPI.Atacama.Apenio.NKS.API.Builder.Rest.Search
{
    public class SearchBuilder
    {
        private string _path;

        public SearchBuilder(string path)
        {
            _path = path;
            _path += NksRestAttributes.Search;
        }

        public QueryBuilder AdHocIntervention()
        {
            return new QueryBuilder(Type.POST,_path+NksRestAttributes.Ahi);
        }
        
        public QueryBuilder Correlation()
        {
            return new QueryBuilder(Type.POST,_path+NksRestAttributes.Correlation);
        }
        
        public QueryBuilder Catalog()
        {
            return new QueryBuilder(Type.POST,_path+NksRestAttributes.Catalog);
        }
        
        public QueryBuilder Chain()
        {
            return new QueryBuilder(Type.POST,_path+NksRestAttributes.Chain);
        }
        
        public QueryBuilder Link()
        {
            return new QueryBuilder(Type.POST,_path+NksRestAttributes.Link);
        }
        
        
        public QueryBuilder Proposal()
        {
            return new QueryBuilder(Type.POST,_path+NksRestAttributes.Prop);
        }
        
        public QueryBuilder WordProposal()
        {
            return new QueryBuilder(Type.POST,_path+NksRestAttributes.WordProp);
        }
    }
}