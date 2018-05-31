using Atacama.Apenio.NKS.API;

namespace NksAPI.Atacama.Apenio.NKS.API.Builder.Rest.Access
{
    public class AccessBuilder
    {
        private readonly string _path;

        internal AccessBuilder(string path)
        {
            _path += path + NksRestAttributes.access;
        }

        /// <summary>
        /// Zugriff auf die Kataloge
        /// </summary>
        public Queries Element()
        {
            return new Queries(Type.POST,_path + NksRestAttributes.element);
        }
    }
}