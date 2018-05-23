using System.Runtime.InteropServices;
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

        private void AddAttribute(string attr)
        {
            _query.AddAttribute(new NksEntry(attr));
        }
        
        public AttributeBuilder Newborn()
        {
            AddAttribute(NewbornAttr);
            return this;
        }
        
        public AttributeBuilder Infant()
        {
            AddAttribute(InfantAttr);
            return this;
        }
        
        public AttributeBuilder Child()
        {
            AddAttribute(ChildAttr);
            return this;
        }
        
        public AttributeBuilder Juvenile()
        {
            AddAttribute(JuvenileAttr);
            return this;
        }
        
        public AttributeBuilder Adult()
        {
            AddAttribute(AdultAttr);
            return this;
        }
        
        public AttributeBuilder Aged()
        {
            AddAttribute(AgedAttr);
            return this;
        }
        
        public AttributeBuilder HighAged()
        {
            AddAttribute(HighAgedAttr);
            return this;
        }
        
        public AttributeBuilder Male()
        {
            AddAttribute(MaleAttr);
            return this;
        }
        
        public AttributeBuilder Female()
        {
            AddAttribute(FemaleAttr);
            return this;
        }

        public SimpleQueryBuilder Done()
        {
            return _builder;
        }
    }
}