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
        
        public SimpleEntryBuilder<SimpleTargetBuilder> Root()
        {
            NksEntry entry = new NksEntry(BasicEntries.Root);
            _query.AddTarget(entry);
            return new SimpleEntryBuilder<SimpleTargetBuilder>(entry,this);
        }
        
        public SimpleEntryBuilder<SimpleTargetBuilder> ExpertStandard()
        {
            NksEntry entry = new NksEntry(BasicEntries.ExpertStandard);
            _query.AddTarget(entry);
            return new SimpleEntryBuilder<SimpleTargetBuilder>(entry,this);
        }
        
        public SimpleEntryBuilder<SimpleTargetBuilder> Interventions()
        {
            NksEntry entry = new NksEntry(BasicEntries.Interventions);
            _query.AddTarget(entry);
            return new SimpleEntryBuilder<SimpleTargetBuilder>(entry,this);
        }
        
        public SimpleEntryBuilder<SimpleTargetBuilder> InterventionsStructure()
        {
            NksEntry entry = new NksEntry(BasicEntries.InterventionsStructure);
            _query.AddTarget(entry);
            return new SimpleEntryBuilder<SimpleTargetBuilder>(entry,this);
        }
        
        public SimpleEntryBuilder<SimpleTargetBuilder> Shapes()
        {
            NksEntry entry = new NksEntry(BasicEntries.Shapes);
            _query.AddTarget(entry);
            return new SimpleEntryBuilder<SimpleTargetBuilder>(entry,this);
        }
        
        public SimpleEntryBuilder<SimpleTargetBuilder> Phenomenons()
        {
            NksEntry entry = new NksEntry(BasicEntries.Phaenomenoms);
            _query.AddTarget(entry);
            return new SimpleEntryBuilder<SimpleTargetBuilder>(entry,this);
        }
        
        public SimpleEntryBuilder<SimpleTargetBuilder> BodyLocations()
        {
            NksEntry entry = new NksEntry(BasicEntries.BodyLocations);
            _query.AddTarget(entry);
            return new SimpleEntryBuilder<SimpleTargetBuilder>(entry,this);
        }
        
        public SimpleEntryBuilder<SimpleTargetBuilder> BodyLocationsStructure()
        {
            NksEntry entry = new NksEntry(BasicEntries.BodyLocationsStructure);
            _query.AddTarget(entry);
            return new SimpleEntryBuilder<SimpleTargetBuilder>(entry,this);
        }
        
        public SimpleEntryBuilder<SimpleTargetBuilder> Appliances()
        {
            NksEntry entry = new NksEntry(BasicEntries.Appliances);
            _query.AddTarget(entry);
            return new SimpleEntryBuilder<SimpleTargetBuilder>(entry,this);
        }
        
        public SimpleEntryBuilder<SimpleTargetBuilder> AppliancesStructure()
        {
            NksEntry entry = new NksEntry(BasicEntries.AppliancesStructure);
            _query.AddTarget(entry);
            return new SimpleEntryBuilder<SimpleTargetBuilder>(entry,this);
        }
        
        public SimpleEntryBuilder<SimpleTargetBuilder> Causes()
        {
            NksEntry entry = new NksEntry(BasicEntries.Causes);
            _query.AddTarget(entry);
            return new SimpleEntryBuilder<SimpleTargetBuilder>(entry,this);
        }
        
        public SimpleEntryBuilder<SimpleTargetBuilder> CausesStructure()
        {
            NksEntry entry = new NksEntry(BasicEntries.CausesStructure);
            _query.AddTarget(entry);
            return new SimpleEntryBuilder<SimpleTargetBuilder>(entry,this);
        }

        public SimpleEntryBuilder<SimpleTargetBuilder> Custom(string str)
        {
            NksEntry entry = new NksEntry(str);
            _query.AddTarget(entry);
            return new SimpleEntryBuilder<SimpleTargetBuilder>(entry,this);
        }
        
        public SimpleQueryBuilder Done()
        {
            return _builder;
        }
    }
}