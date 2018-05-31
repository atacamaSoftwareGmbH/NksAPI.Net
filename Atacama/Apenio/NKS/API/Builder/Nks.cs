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

       
        /// <summary>
        /// Nksverbindung zum öffentlichen Server
        /// </summary>
        public static Nks NewConnection()
        {
            return new Nks();
        }

        /// <summary>
        /// Nksverbindung zu einem bestimmten Server
        /// </summary>
        public static Nks NewConnection(string serverAddress)
        {
            return new Nks(serverAddress);
        }

        /// <summary>
        /// Bereitet Anfrage an den NKS vor
        /// </summary>
        public RestRequestBuilder PrepareRequest()
        {
            return new RestRequestBuilder(this.path);
        }

        
    }
}