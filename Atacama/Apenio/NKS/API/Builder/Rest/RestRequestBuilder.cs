using Atacama.Apenio.NKS.API;
using NksAPI.Atacama.Apenio.NKS.API.Builder.Rest.Access;
using NksAPI.Atacama.Apenio.NKS.API.Builder.Rest.Get;
using NksAPI.Atacama.Apenio.NKS.API.Builder.Rest.Inference;
using NksAPI.Atacama.Apenio.NKS.API.Builder.Rest.LongTerm;
using NksAPI.Atacama.Apenio.NKS.API.Builder.Rest.Search;

namespace NksAPI.Atacama.Apenio.NKS.API.Builder.Rest
{
    public class RestRequestBuilder
    {
        private string path;

        internal RestRequestBuilder(string path)
        {
            this.path = path;
            this.path += NksRestAttributes.v2;
        }

        public AccessBuilder Access()
        {
            return new AccessBuilder(this.path);
        }

        public GetBuilder Get()
        {
            return new GetBuilder(this.path);
        }

        public InferenceBuilder Inference()
        {
            return new InferenceBuilder(this.path);
        }
        
        public LongTermBuilder LongTerm()
        {
            return new LongTermBuilder(this.path);
        }
        
        public SearchBuilder Search()
        {
            return new SearchBuilder(this.path);
        }
    }
}