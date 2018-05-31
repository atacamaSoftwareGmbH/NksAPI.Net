using Atacama.Apenio.NKS.API;

namespace NksAPI.Atacama.Apenio.NKS.API.Builder.Rest.Get
{
    public class UidBuilder : Executor
    {
        public UidBuilder(string path) : base(Type.GET, path)
        {   
        }
        
        public Executor Tree()
        {
            return new Executor(Type.GET,Path + NksRestAttributes.tree);
        }
    }
}