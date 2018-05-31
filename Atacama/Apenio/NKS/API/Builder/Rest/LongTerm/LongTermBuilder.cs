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
        /// <summary>
        /// Risikoanalyse
        /// </summary>
        public Queries Risk()
        {
            return new Queries(Type.POST,path+NksRestAttributes.Risk);
        }
        
        /// <summary>
        /// Interventionsvorschläge
        /// </summary>
        public Queries Intervention()
        {
            return new Queries(Type.POST,path+NksRestAttributes.InterventionProposal);
        }
    }
}