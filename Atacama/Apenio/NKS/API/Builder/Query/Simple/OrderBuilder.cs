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

        public SimpleQueryBuilder Tree()
        {
            _query.order = "tree";
            return _builder;
        }

        public SimpleQueryBuilder List()
        {
            _query.order = "list";
            return _builder;
        }
    }
}