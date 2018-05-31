using Atacama.Apenio.NKS.API;

namespace NksAPI.Atacama.Apenio.NKS.API.Builder.Rest.Get
{
    public class UidBuilder : Executor
    {
        public UidBuilder(string path) : base(Type.GET, path)
        {   
        }
        
        /// <summary>
        /// Erhalte Antwort als Baum
        /// </summary>
        public Executor Tree()
        {
            return new Executor(Type.GET,Path + NksRestAttributes.tree);
        }
        
        /// <summary>
        /// Erhalte Antwort als Liste
        /// </summary>
        public Executor List()
        {
            return new Executor(Type.GET,Path + NksRestAttributes.list);
        }
    }
}