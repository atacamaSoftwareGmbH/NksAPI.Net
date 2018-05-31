using System.Runtime.InteropServices;

namespace Atacama.Apenio.NKS.API
{
    public class OrderBuilder
    {
        private NksQuery _query;
        private SimpleQueryBuilder _builder;

        internal OrderBuilder(NksQuery query, SimpleQueryBuilder builder)
        {
            _query = query;
            _builder = builder;
        }

        /// <summary>
        /// Setze die Ordnung des Antwortobjekts als Baum
        /// 
        /// </summary>
        /// <returns>Querybuilder zum Fortsetzen der Bearbeitung des Queries</returns>
        public SimpleQueryBuilder Tree()
        {
            _query.order = "tree";
            return _builder;
        }

        /// <summary>
        /// Setze die Ordnung des Antwortobjekts als Liste
        /// 
        /// </summary>
        /// <returns>Querybuilder zum Fortsetzen der Bearbeitung des Queries</returns>
        public SimpleQueryBuilder List()
        {
            _query.order = "list";
            return _builder;
        }
    }
}