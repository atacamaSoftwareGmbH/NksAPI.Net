using System.Runtime.InteropServices;
using Atacama.Apenio.NKS.API.Model;

namespace Atacama.Apenio.NKS.API
{
    public partial class SimpleTargetBuilder
    {
        private readonly SimpleQueryBuilder _builder;

        private readonly NksQuery _query;

        internal SimpleTargetBuilder(NksQuery query, SimpleQueryBuilder builder)
        {
            _query = query;
            _builder = builder;
        }
        
        /// <summary>
        /// Füge Root der Zielmenge hinzu
        /// 
        /// </summary>
        /// <returns>EntryBuilder um gegebenenfalls Strukturelemente dem Ziel hinzuzufügen</returns>
        public SimpleEntryBuilder<SimpleTargetBuilder> Root()
        {
            NksEntry entry = new NksEntry(BasicEntries.Root);
            _query.AddTarget(entry);
            return new SimpleEntryBuilder<SimpleTargetBuilder>(entry,this);
        }
        
        /// <summary>
        /// Füge den Expertenstandard der Zielmenge hinzu
        /// 
        /// </summary>
        /// <returns>EntryBuilder um gegebenenfalls Strukturelemente dem Ziel hinzuzufügen</returns>
        public SimpleEntryBuilder<SimpleTargetBuilder> ExpertStandard()
        {
            NksEntry entry = new NksEntry(BasicEntries.ExpertStandard);
            _query.AddTarget(entry);
            return new SimpleEntryBuilder<SimpleTargetBuilder>(entry,this);
        }
        
        /// <summary>
        /// Füge Interventionen der Zielmenge hinzu
        /// 
        /// </summary>
        /// <returns>EntryBuilder um gegebenenfalls Strukturelemente dem Ziel hinzuzufügen</returns>
        public SimpleEntryBuilder<SimpleTargetBuilder> Interventions()
        {
            NksEntry entry = new NksEntry(BasicEntries.Interventions);
            _query.AddTarget(entry);
            return new SimpleEntryBuilder<SimpleTargetBuilder>(entry,this);
        }
        
        /// <summary>
        /// Füge Ordnungsstuktur der Interventionen der Zielmenge hinzu
        /// 
        /// </summary>
        /// <returns>EntryBuilder um gegebenenfalls Strukturelemente dem Ziel hinzuzufügen</returns>
        public SimpleEntryBuilder<SimpleTargetBuilder> InterventionsStructure()
        {
            NksEntry entry = new NksEntry(BasicEntries.InterventionsStructure);
            _query.AddTarget(entry);
            return new SimpleEntryBuilder<SimpleTargetBuilder>(entry,this);
        }
        
        /// <summary>
        /// Füge Ordnungsstuktur der Interventionen der Zielmenge hinzu
        /// 
        /// </summary>
        /// <returns>EntryBuilder um gegebenenfalls Strukturelemente dem Ziel hinzuzufügen</returns>
        public SimpleEntryBuilder<SimpleTargetBuilder> InterventionsBundle()
        {
            NksEntry entry = new NksEntry(BasicEntries.InterventionsBundle);
            _query.AddTarget(entry);
            return new SimpleEntryBuilder<SimpleTargetBuilder>(entry,this);
        }
        
        /// <summary>
        /// Füge Ausprägungen der Zielmenge hinzu
        /// 
        /// </summary>
        /// <returns>EntryBuilder um gegebenenfalls Strukturelemente dem Ziel hinzuzufügen</returns>
        public SimpleEntryBuilder<SimpleTargetBuilder> Shapes()
        {
            NksEntry entry = new NksEntry(BasicEntries.Shapes);
            _query.AddTarget(entry);
            return new SimpleEntryBuilder<SimpleTargetBuilder>(entry,this);
        }
        
        /// <summary>
        /// Füge Phänomene der Zielmenge hinzu
        /// 
        /// </summary>
        /// <returns>EntryBuilder um gegebenenfalls Strukturelemente dem Ziel hinzuzufügen</returns>
        public SimpleEntryBuilder<SimpleTargetBuilder> Phenomenons()
        {
            NksEntry entry = new NksEntry(BasicEntries.Phaenomenoms);
            _query.AddTarget(entry);
            return new SimpleEntryBuilder<SimpleTargetBuilder>(entry,this);
        }
        
        /// <summary>
        /// Füge Körperorte der Zielmenge hinzu
        /// 
        /// </summary>
        /// <returns>EntryBuilder um gegebenenfalls Strukturelemente dem Ziel hinzuzufügen</returns>
        public SimpleEntryBuilder<SimpleTargetBuilder> BodyLocations()
        {
            NksEntry entry = new NksEntry(BasicEntries.BodyLocations);
            _query.AddTarget(entry);
            return new SimpleEntryBuilder<SimpleTargetBuilder>(entry,this);
        }
        
        /// <summary>
        /// Füge Ordnungsstuktur der Körperorte der Zielmenge hinzu
        /// 
        /// </summary>
        /// <returns>EntryBuilder um gegebenenfalls Strukturelemente dem Ziel hinzuzufügen</returns>
        public SimpleEntryBuilder<SimpleTargetBuilder> BodyLocationsStructure()
        {
            NksEntry entry = new NksEntry(BasicEntries.BodyLocationsStructure);
            _query.AddTarget(entry);
            return new SimpleEntryBuilder<SimpleTargetBuilder>(entry,this);
        }
        
        /// <summary>
        /// Füge Hilfsmittel der Zielmenge hinzu
        /// 
        /// </summary>
        /// <returns>EntryBuilder um gegebenenfalls Strukturelemente dem Ziel hinzuzufügen</returns>
        public SimpleEntryBuilder<SimpleTargetBuilder> Appliances()
        {
            NksEntry entry = new NksEntry(BasicEntries.Appliances);
            _query.AddTarget(entry);
            return new SimpleEntryBuilder<SimpleTargetBuilder>(entry,this);
        }
        
        /// <summary>
        /// Füge Ordnungsstuktur der Hilfsmittel der Zielmenge hinzu
        /// 
        /// </summary>
        /// <returns>EntryBuilder um gegebenenfalls Strukturelemente dem Ziel hinzuzufügen</returns>
        public SimpleEntryBuilder<SimpleTargetBuilder> AppliancesStructure()
        {
            NksEntry entry = new NksEntry(BasicEntries.AppliancesStructure);
            _query.AddTarget(entry);
            return new SimpleEntryBuilder<SimpleTargetBuilder>(entry,this);
        }
        
        /// <summary>
        /// Füge Ursachen der Zielmenge hinzu
        /// 
        /// </summary>
        /// <returns>EntryBuilder um gegebenenfalls Strukturelemente dem Ziel hinzuzufügen</returns>
        public SimpleEntryBuilder<SimpleTargetBuilder> Causes()
        {
            NksEntry entry = new NksEntry(BasicEntries.Causes);
            _query.AddTarget(entry);
            return new SimpleEntryBuilder<SimpleTargetBuilder>(entry,this);
        }
        
        /// <summary>
        /// Füge Ordnungsstuktur der Ursachen der Zielmenge hinzu
        /// 
        /// </summary>
        /// <returns>EntryBuilder um gegebenenfalls Strukturelemente dem Ziel hinzuzufügen</returns>
        public SimpleEntryBuilder<SimpleTargetBuilder> CausesStructure()
        {
            NksEntry entry = new NksEntry(BasicEntries.CausesStructure);
            _query.AddTarget(entry);
            return new SimpleEntryBuilder<SimpleTargetBuilder>(entry,this);
        }

        /// <summary>
        /// Füge Element mittels seines Konzeptnamens der Zielmenge hinzu
        /// 
        /// </summary>
        /// <param name="cName">der cName oder auch Konzeptname</param> 
        /// <returns>EntryBuilder um gegebenenfalls Strukturelemente dem Ziel hinzuzufügen</returns>
        public SimpleEntryBuilder<SimpleTargetBuilder> Custom(string cName)
        {
            NksEntry entry = new NksEntry(cName);
            _query.AddTarget(entry);
            return new SimpleEntryBuilder<SimpleTargetBuilder>(entry,this);
        }
        
        /// <summary>
        /// Beende das hinzufügen von Elementen zur Zielmenge
        /// 
        /// </summary>
        /// <returns>EntryBuilder um gegebenenfalls Strukturelemente dem Ziel hinzuzufügen</returns>
        public SimpleQueryBuilder Done()
        {
            return _builder;
        }
    }
}