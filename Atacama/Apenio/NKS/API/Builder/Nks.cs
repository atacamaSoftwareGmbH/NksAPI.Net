using NksAPI.Atacama.Apenio.NKS.API.Builder.Rest;

namespace Atacama.Apenio.NKS.API
{
    public class Nks
    {
        private string path;

        private Nks()
        {
            this.path += NksRestAttributes.publicServer;
            //TODO Ping Server
            this.path += NksRestAttributes.servicePath;
        }

        private Nks(string serverAddress)
        {
            this.path += serverAddress;
            //TODO Ping Server
            this.path += NksRestAttributes.servicePath;
        }

        public static Nks NewConnection()
        {
            return new Nks();
        }

        public static Nks NewConnection(string serverAddress)
        {
            return new Nks(serverAddress);
        }


        public RestRequestBuilder PrepareRequest()
        {
            return new RestRequestBuilder(this.path);
        }

        
    }
}