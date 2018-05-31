using System;
using System.Threading.Tasks;
using Atacama.Apenio.NKS.API;
using Atacama.Apenio.NKS.API.IO.Net;

namespace NksAPI.Atacama.Apenio.NKS.API.Builder.Rest
{
    public class Executor
    {
        protected Type Type;

        protected string Path;

        protected NksQuery Query;

        internal Executor(Type type, string path)
        {
            Path = path;
            Type = type;
        }

        internal Executor()
        {
            
        }

        /// <summary>
        /// Gebe das gebaute Queryobjekt zurück
        /// </summary>
        public NksQuery GetQuery()
        {
            return Query;
        }

        /// <summary>
        /// Führe Anfrage an den Server durch
        /// </summary>
        public async Task<NksResponse> Execute()
        {    
            switch (Type)
            {
              case Type.GET:
                  return await RestClient.Instance.Get(Path);
                  break;
              case Type.POST:
                  return await RestClient.Instance.Post(Query,Path);
                  break;
              default:
                  //TODO: Throw Exception
                  return null;
                  break;
            }
        }
    }
}