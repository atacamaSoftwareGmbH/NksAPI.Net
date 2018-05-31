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

        /// <summary>
        /// Zugriff auf die Probabilities
        /// </summary>
        public Queries Probabilities()
        {
            return new Queries(Type.POST,path+NksRestAttributes.PInference);
        }
        
        /// <summary>
        /// Zugriff auf die Contradictions
        /// </summary>
        public Queries Contradictions()
        {
            return new Queries(Type.POST,path+NksRestAttributes.CInference);
        }
    }
}