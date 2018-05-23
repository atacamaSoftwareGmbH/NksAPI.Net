using Atacama.Apenio.NKS.API;

namespace NksAPI.Atacama.Apenio.NKS.API.Builder.Rest.Inference
{
    public class InferenceBuilder
    {
        private string path;

        public InferenceBuilder(string path)
        {
            this.path = path;
            this.path += NksRestAttributes.Inference;
        }

        public QueryBuilder Probabilities()
        {
            return new QueryBuilder(Type.POST,path+NksRestAttributes.PInference);
        }
        
        public QueryBuilder Contradictions()
        {
            return new QueryBuilder(Type.POST,path+NksRestAttributes.CInference);
        }
    }
}