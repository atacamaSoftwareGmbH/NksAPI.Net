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
        /// <summary>
        /// Zugriff auf die Ad Hoc Interventionen
        /// </summary>
        public Queries AdHocIntervention()
        {
            return new Queries(Type.POST,_path+NksRestAttributes.Ahi);
        }
        
        /// <summary>
        /// Zugriff auf die Correlations
        /// </summary>
        public Queries Correlation()
        {
            return new Queries(Type.POST,_path+NksRestAttributes.Correlation);
        }
        
        /// <summary>
        /// Zugriff auf die Katalogsuche
        /// </summary>
        public Queries Catalog()
        {
            return new Queries(Type.POST,_path+NksRestAttributes.Catalog);
        }
        
        /// <summary>
        /// Zugriff auf die Kettensuche
        /// </summary>
        public Queries Chain()
        {
            return new Queries(Type.POST,_path+NksRestAttributes.Chain);
        }
        
        /// <summary>
        /// Zugriff auf die Verlinkte Elemente
        /// </summary>
        public Queries Link()
        {
            return new Queries(Type.POST,_path+NksRestAttributes.Link);
        }
        
        /// <summary>
        /// Zugriff auf Vorschläge
        /// </summary>
        public Queries Proposal()
        {
            return new Queries(Type.POST,_path+NksRestAttributes.Prop);
        }
        
        /// <summary>
        /// Zugriff auf Wortvorschläge
        /// </summary>
        public Queries WordProposal()
        {
            return new Queries(Type.POST,_path+NksRestAttributes.WordProp);
        }
    }
}