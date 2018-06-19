using System;
using System.Threading.Tasks;
using Atacama.Apenio.NKS.API;
using Atacama.Apenio.NKS.API.IO.Net;

namespace NksAPI.Atacama.Apenio.NKS.API.Builder.Rest
{
    public class Executor
    {
        protected Type Type;

        private readonly string _path;

        protected NksQuery Query;

        internal Executor(Type type, string path)
        {
            _path = path;
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

        public String GetPath()
        {
            return _path;
        }

        /// <summary>
        /// Führe Anfrage an den Server durch
        /// </summary>
        public async Task<NksResponse> Execute()
        {    
            switch (Type)
            {
              case Type.GET:
                  return await RestClient.Instance.Get(_path);
                  break;
              case Type.POST:
                  return await RestClient.Instance.Post(Query,_path);
                  break;
              default:
                  //TODO: Throw Exception
                  return null;
                  break;
            }
        }
    }
}