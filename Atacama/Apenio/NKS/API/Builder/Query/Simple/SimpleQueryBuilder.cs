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

        /// <summary>
        /// Füge ein oder mehrere Attribute dem Query hinzu
        /// 
        /// </summary>
        /// <returns>AttributeBuilder in welchem ein oder mehrere Attribute gewählt werden können</returns>
        public AttributeBuilder AddAttributes()
        {
            return new AttributeBuilder(Query,this);
        }

        /// <summary>
        /// Füge ein oder mehrere Elemente der Zielmenge hinzu
        /// 
        /// </summary>
        /// <returns>TargetBuilder in welchem ein oder mehrere Ziele gewählt werden können</returns>
        public SimpleTargetBuilder AddTargets()
        {
            return new SimpleTargetBuilder(Query,this);
        }

        /// <summary>
        /// Füge ein Element mittels seines cName der Konzeptmenge hinzu
        /// 
        /// </summary>
        /// <param name="cName">der cName oder auch Konzeptname</param>
        /// <returns>SimpleEntryBuilder um Strukturelemente etc. diesem Konzept hinzuzufügen</returns>
        public SimpleEntryBuilder<SimpleQueryBuilder> AddConcept(string cName)
        {
            NksEntry entry = new NksEntry(cName);
            Query.AddConcept(entry);
            return new SimpleEntryBuilder<SimpleQueryBuilder>(entry, this);
        }
        
        /// <summary>
        /// Füge ein NksEntry der Konzeptmenge hinzu
        /// 
        /// </summary>
        /// <param name="entry">Nks Entry-Objekt</param>
        /// <returns>Sich selbst für chaining</returns>
        public SimpleQueryBuilder AddConcept(NksEntry entry)
        {
            Query.AddConcept(entry);
            return this;
        }
        
        /// <summary>
        /// Füge ein Element mittels seines cName und einer Domäne der Konzeptmenge hinzu
        /// 
        /// </summary>
        /// <param name="cName">der cName oder auch Konzeptname</param>
        /// <param name="domain">die Domäne des Konzepts</param>
        /// <returns>SimpleEntryBuilder um Strukturelemente etc. diesem Konzept hinzuzufügen</returns>
        public SimpleEntryBuilder<SimpleQueryBuilder> AddConcept(string cName, String domain)
        {
            NksEntry entry = new NksEntry(cName);
            entry.dom = domain;
            Query.AddConcept(entry);
            return new SimpleEntryBuilder<SimpleQueryBuilder>(entry, this);
        }

        /// <summary>
        /// Definiere mit Hilfe eines Builders das Template für die Objekte der Antwort der Anfrage an den Server
        /// 
        /// </summary>
        /// <returns>SimpleTemplateBuilder zur Definition eines Tamplates</returns>
        public SimpleTemplateBuilder DefineTemplate()
        {
            return new SimpleTemplateBuilder(Query,this);
        }

        /// <summary>
        /// Definiere die Sprache der Anfrage
        /// 
        /// </summary>
        /// <param name="language">Sprachcode nach ISO 639-1 norm</param>
        /// <returns>Sich selbst für chaining</returns>
        public SimpleQueryBuilder SetLanguage(string language)
        {
            Query.lang = language;
            return this;
        }
        
        /// <summary>
        /// Definiere den Suchttext der Anfrage
        /// 
        /// </summary>
        /// <param name="text">Suchtext als String</param>
        /// <returns>Sich selbst für chaining</returns>
        public SimpleQueryBuilder SetSearchText(string text)
        {
            Query.text = text;
            return this;
        }
        
        /// <summary>
        /// Definiere den Text-Kontext der Anfrage
        /// 
        /// </summary>
        /// <param name="text">Kontext als String</param>
        /// <returns>Sich selbst für chaining</returns>
        public SimpleQueryBuilder SetTextContext(string text)
        {
            Query.textContext = text;
            return this;
        }

        /// <summary>
        /// Definiere die Tiefe des Antwortobjekts der Anfrage
        /// 
        /// </summary>
        /// <param name="i">Tiefe als Integer</param>
        /// <returns>Sich selbst für chaining</returns>
        public SimpleQueryBuilder SetDepth(int i)
        {
            Query.depth = i;
            return this;
        }
        
        /// <summary>
        /// Definiere den Modus der Anfrage
        /// 
        /// </summary>
        /// <param name="i">Modus als Integer</param>
        /// <returns>Sich selbst für chaining</returns>
        public SimpleQueryBuilder SetMode(int i)
        {
            Query.mode = i;
            return this;
        }

        /// <summary>
        /// Definiere die Ordnung des Antwortobjekts der Anfrage
        /// Default = none
        /// </summary>
        /// <returns>OderBuilder in welchem die Ordnung ausgewählt werden kann</returns>
        public OrderBuilder SetOrder()
        {
            return new OrderBuilder(Query,this);
        }
    }
}