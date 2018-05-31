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

        public SimpleEntryBuilder<T> SetDomain(string domain)
        {
            _entry.dom = domain;
            return this;
        }

        public SimpleEntryBuilder<T> AddStructure(string str)
        {
            _entry.AddStructure(str);
            return this;
        }

        public T Done()
        {
            return _builder;
        }
    }
}