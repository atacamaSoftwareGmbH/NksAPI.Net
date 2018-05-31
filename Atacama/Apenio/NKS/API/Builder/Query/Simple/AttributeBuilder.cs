using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using Atacama.Apenio.NKS.API.Model;

namespace Atacama.Apenio.NKS.API
{
    public class AttributeBuilder
    {
        private NksQuery _query;

        private SimpleQueryBuilder _builder;
        
        public const string NewbornAttr = "NeugeboreneAlter_";
        public const string InfantAttr = "SäuglingAlter_";
        public const string ChildAttr = "KindAlter_";
        public const string JuvenileAttr = "JugendlicheAlter_";
        public const string AdultAttr = "ErwachseneAlter_";
        public const string AgedAttr = "ÄltereAlter_";
        public const string HighAgedAttr = "HochaltrigeAlter_";
        public const string MaleAttr = "MännlichGeschlecht_";
        public const string FemaleAttr = "WeiblichGeschlecht_";

        internal AttributeBuilder(NksQuery query, SimpleQueryBuilder builder)
        {
            _query = query;
            _builder = builder;
        }

        /// <summary>
        /// Füge ein frei wählbares Attribut hinzu
        /// 
        /// </summary>
        /// <param name="attr">Name des Attribut als String</param>
        /// <returns>Sich selbst für chaining</returns>
        private void AddAttribute(string attr)
        {
            _query.AddAttribute(new NksEntry(attr));
        }
        
        /// <summary>
        /// Füge das Attribut Neuggeboren hinzu
        /// 
        /// </summary>
        /// <returns>Sich selbst für chaining</returns>
        public AttributeBuilder Newborn()
        {
            AddAttribute(NewbornAttr);
            return this;
        }
        
        /// <summary>
        /// Füge das Attribut Säugling hinzu
        /// 
        /// </summary>
        /// <returns>Sich selbst für chaining</returns>
        public AttributeBuilder Infant()
        {
            AddAttribute(InfantAttr);
            return this;
        }
        
        /// <summary>
        /// Füge das Attribut Kind hinzu
        /// 
        /// </summary>
        /// <returns>Sich selbst für chaining</returns>
        public AttributeBuilder Child()
        {
            AddAttribute(ChildAttr);
            return this;
        }
        
        /// <summary>
        /// Füge das Attribut Jugendlich hinzu
        /// 
        /// </summary>
        /// <returns>Sich selbst für chaining</returns>
        public AttributeBuilder Juvenile()
        {
            AddAttribute(JuvenileAttr);
            return this;
        }
        
        /// <summary>
        /// Füge das Attribut Erwachsen hinzu
        /// 
        /// </summary>
        /// <returns>Sich selbst für chaining</returns>
        public AttributeBuilder Adult()
        {
            AddAttribute(AdultAttr);
            return this;
        }
        
        /// <summary>
        /// Füge das Attribut Älter hinzu
        /// 
        /// </summary>
        /// <returns>Sich selbst für chaining</returns>
        public AttributeBuilder Aged()
        {
            AddAttribute(AgedAttr);
            return this;
        }
        
        /// <summary>
        /// Füge das Attribut Hochaltrig hinzu
        /// 
        /// </summary>
        /// <returns>Sich selbst für chaining</returns>
        public AttributeBuilder HighAged()
        {
            AddAttribute(HighAgedAttr);
            return this;
        }
        
        /// <summary>
        /// Füge das Attribut Männlich hinzu
        /// 
        /// </summary>
        /// <returns>Sich selbst für chaining</returns>
        public AttributeBuilder Male()
        {
            AddAttribute(MaleAttr);
            return this;
        }
        
        /// <summary>
        /// Füge das Attribut Weiblich hinzu
        /// 
        /// </summary>
        /// <returns>Sich selbst für chaining</returns>
        public AttributeBuilder Female()
        {
            AddAttribute(FemaleAttr);
            return this;
        }

        /// <summary>
        /// Beende das hinzufügen von Attributen
        /// 
        /// </summary>
        /// <returns>Querybuilder zum weiteren Bearbeitung des Queries</returns>
        public SimpleQueryBuilder Done()
        {
            return _builder;
        }
    }
}