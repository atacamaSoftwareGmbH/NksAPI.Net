using Atacama.Apenio.NKS.API;

namespace NksAPI.Atacama.Apenio.NKS.API.Builder.Rest.Search
{
    public class SearchBuilder
    {
        private readonly string _path;

        public SearchBuilder(string path)
        {
            _path = path;
            _path += NksRestAttributes.Search;
        }

        public Queries AdHocIntervention()
        {
            return new Queries(Type.POST,_path+NksRestAttributes.Ahi);
        }
        
        public Queries Correlation()
        {
            return new Queries(Type.POST,_path+NksRestAttributes.Correlation);
        }
        
        public Queries Catalog()
        {
            return new Queries(Type.POST,_path+NksRestAttributes.Catalog);
        }
        
        public Queries Chain()
        {
            return new Queries(Type.POST,_path+NksRestAttributes.Chain);
        }
        
        public Queries Link()
        {
            return new Queries(Type.POST,_path+NksRestAttributes.Link);
        }
        
        
        public Queries Proposal()
        {
            return new Queries(Type.POST,_path+NksRestAttributes.Prop);
        }
        
        public Queries WordProposal()
        {
            return new Queries(Type.POST,_path+NksRestAttributes.WordProp);
        }
    }
}