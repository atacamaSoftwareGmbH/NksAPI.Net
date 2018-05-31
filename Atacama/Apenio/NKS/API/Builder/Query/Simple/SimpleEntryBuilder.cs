using Atacama.Apenio.NKS.API.Model;

namespace Atacama.Apenio.NKS.API
{
    public class SimpleEntryBuilder<T>
    {
        private readonly NksEntry _entry;

        private readonly T _builder;
        
        internal SimpleEntryBuilder(NksEntry entry, T builder)
        {
            _entry = entry;
            _builder = builder;
        }

        /// <summary>
        /// Setze die Domäne des Konzepts
        /// 
        /// </summary>
        /// <param name="domain">Name der Domäne</param>
        /// <returns>Sich selbst für chaining</returns>
        public SimpleEntryBuilder<T> SetDomain(string domain)
        {
            _entry.dom = domain;
            return this;
        }

        /// <summary>
        /// Füge ein Strukturelement dem Konzept hinzu
        /// 
        /// </summary>
        /// <param name="str">Name der Struktur</param>
        /// <returns>Sich selbst für chaining</returns>
        public SimpleEntryBuilder<T> AddStructure(string str)
        {
            _entry.AddStructure(str);
            return this;
        }

        /// <summary>
        /// Beende Bearbeitung des Konzepts
        /// 
        /// </summary>
        /// <returns>Sich selbst für chaining</returns>
        public T Done()
        {
            return _builder;
        }
    }
}