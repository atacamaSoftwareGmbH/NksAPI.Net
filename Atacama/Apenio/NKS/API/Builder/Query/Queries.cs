﻿using NksAPI.Atacama.Apenio.NKS.API.Builder.Rest;

namespace Atacama.Apenio.NKS.API
{
    public class Queries
    {
        private readonly Type _type;

        private readonly string _path;
        
        public Queries(Type type, string path)
        {
            _type = type;
            _path = path;
        }

        /// <summary>
        /// Erstellen eines komplexen Query-Objekts mittels builder
        /// </summary>
        public QueryBuilder CreateQuery()
        {
            return new QueryBuilder(_type,_path);
        }
        /// <summary>
        /// Erstellen eines komplexen Query-Objekts mittels vereinfachten Builders
        /// </summary>
        public SimpleQueryBuilder CreateSimpleQuery()
        {
            return new SimpleQueryBuilder(_type,_path);
        }
    }
}