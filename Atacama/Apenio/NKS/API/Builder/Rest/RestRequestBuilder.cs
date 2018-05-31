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
        
        /// <summary>
        /// Anfrage an den Access-Service
        /// </summary>
        public AccessBuilder Access()
        {
            return new AccessBuilder(this.path);
        }
        
        /// <summary>
        /// Anfrage an den Get-Service
        /// </summary>
        public GetBuilder Get()
        {
            return new GetBuilder(this.path);
        }

        /// <summary>
        /// Anfrage an den Inference-Service
        /// </summary>
        public InferenceBuilder Inference()
        {
            return new InferenceBuilder(this.path);
        }
        
        /// <summary>
        /// Anfrage an den LongTerm-Service
        /// </summary>
        public LongTermBuilder LongTerm()
        {
            return new LongTermBuilder(this.path);
        }
        
        /// <summary>
        /// Anfrage an den Search-Service
        /// </summary>
        public SearchBuilder Search()
        {
            return new SearchBuilder(this.path);
        }
    }
}