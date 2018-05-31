using System;
using System.Linq;
using Atacama.Apenio.NKS.API.Model;
using NksAPI.Atacama.Apenio.NKS.API.Builder.Rest;
using Type = NksAPI.Atacama.Apenio.NKS.API.Builder.Rest.Type;

namespace Atacama.Apenio.NKS.API
{
    public class SimpleQueryBuilder : Executor
    {
        public SimpleQueryBuilder(Type type, string path) : base(type, path)
        {
            Query = new NksQuery();
            Query.lang = Language.Deutsch;
        }

        public AttributeBuilder AddAttributes()
        {
            return new AttributeBuilder(Query,this);
        }

        public SimpleTargetBuilder AddTargets()
        {
            return new SimpleTargetBuilder(Query,this);
        }

        public SimpleEntryBuilder<SimpleQueryBuilder> AddConcept(string cName)
        {
            NksEntry entry = new NksEntry(cName);
            Query.AddConcept(entry);
            return new SimpleEntryBuilder<SimpleQueryBuilder>(entry, this);
        }
        
        public SimpleQueryBuilder AddConcept(NksEntry entry)
        {
            Query.AddConcept(entry);
            return this;
        }
        
        public SimpleEntryBuilder<SimpleQueryBuilder> AddConcept(string cName, String domain)
        {
            NksEntry entry = new NksEntry(cName);
            entry.dom = domain;
            Query.AddConcept(entry);
            return new SimpleEntryBuilder<SimpleQueryBuilder>(entry, this);
        }

        public SimpleTemplateBuilder DefineTemplate()
        {
            return new SimpleTemplateBuilder(Query,this);
        }

        public SimpleQueryBuilder SetLanguage(string str)
        {
            Query.lang = str;
            return this;
        }
        
        public SimpleQueryBuilder SetSearchText(string text)
        {
            Query.text = text;
            return this;
        }
        
        public SimpleQueryBuilder SetTextContext(string text)
        {
            Query.textContext = text;
            return this;
        }

        public SimpleQueryBuilder SetDepth(int i)
        {
            Query.depth = i;
            return this;
        }
        
        public SimpleQueryBuilder SetMode(int i)
        {
            Query.mode = i;
            return this;
        }

        public OrderBuilder SetOrder()
        {
            return new OrderBuilder(Query,this);
        }
    }
}