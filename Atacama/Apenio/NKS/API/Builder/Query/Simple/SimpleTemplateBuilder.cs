using System;
using System.Collections.Generic;
using Atacama.Apenio.NKS.API.Model;

namespace Atacama.Apenio.NKS.API
{
    public class SimpleTemplateBuilder
    {
        private readonly NksEntry _entry;

        private readonly SimpleQueryBuilder _builder;

        internal SimpleTemplateBuilder(NksQuery query, SimpleQueryBuilder builder)
        {
            _entry = new NksEntry(BasicEntries.Template);
            _builder = builder;
            query.template = _entry;
        }
        
        public SimpleTemplateBuilder DefaultTemplate()
        {
            SetLabel();
            SetCategory();
            SetSuperType();
            SetDomain();
            SetScore();
            SetListIndex();
            SetSignature();
            SetParentSignature();
            return this;
        }
        
        public SimpleTemplateBuilder PhenomenonsTemplate()
        {
            SetLabel();
            SetCategory();
            SetSuperType();
            SetDomain();
            SetScore();
            SetListIndex();
            SetSignature();
            SetParentSignature();
            SetShapeLabel();
            SetShapes();
            return this;
        }

        public SimpleTemplateBuilder InterventionTemplate()
        {
            SetLabel();
            SetCategory();
            SetSuperType();
            SetDomain();
            SetScore();
            SetListIndex();
            SetSignature();
            SetParentSignature();
            AddDataRelation("caremin");
            AddDataRelation("icnp");
            AddDataRelation("ppr");
            AddDataRelation("lepmin");
            return this;
        }

        public SimpleTemplateBuilder StructureTemplate()
        {
            SetLabel();
            SetCategory();
            SetSuperType();
            SetDomain();
            SetScore();
            SetListIndex();
            SetSignature();
            SetParentSignature();
            SetStructures();
            return this;
        }

        public SimpleQueryBuilder Done()
        {
            return _builder;
        }

        public SimpleTemplateBuilder SetLabel()
        {
            _entry.label = "";
            return this;
        }
        
        public SimpleTemplateBuilder SetCategory()
        {
            _entry.cat = "";
            return this;
        }
        
        public SimpleTemplateBuilder SetSuperType()
        {
            _entry.superType = "";
            return this;
        }
        
        public SimpleTemplateBuilder SetDomain()
        {
            _entry.dom = "";
            return this;
        }
        
        public SimpleTemplateBuilder SetScore()
        {
            _entry.score = "";
            return this;
        }
        
        public SimpleTemplateBuilder SetListIndex()
        {
            _entry.listIndex = 0;
            return this;
        }

        public SimpleTemplateBuilder SetSignature()
        {
            _entry.signature = "";
            return null;
        }
        
        public SimpleTemplateBuilder SetParentSignature()
        {
            _entry.parentSignature = "";
            return null;
        }

        public SimpleTemplateBuilder SetStructures()
        {
            _entry.structures = new HashSet<string>();
            return this;
        }

        public SimpleTemplateBuilder SetDataRelation()
        {
            _entry.dataRelation = new Dictionary<string, HashSet<string>>();
            return this;
        }

        public SimpleTemplateBuilder SetObjectRelation()
        {
            _entry.objectRelation = new Dictionary<string, HashSet<string>>();
            return this;
        }

        public SimpleTemplateBuilder AddDataRelation(string str)
        {
            if (_entry.dataRelation == null)
            {
                SetDataRelation();
            }
            _entry.dataRelation?.Add(str, new HashSet<string>());
            return this;
        }

        public SimpleTemplateBuilder AddObjectRelation(string str)
        {
            if (_entry.objectRelation == null)
            {
                SetObjectRelation();
            }
            _entry.objectRelation?.Add(str, new HashSet<string>());
            return this;
        }

        public SimpleTemplateBuilder SetShapes()
        {
            _entry.shapes = new Dictionary<int, HashSet<string>>();
            return this;
        }

        public SimpleTemplateBuilder SetShapeLabel()
        {
            _entry.shapeLabel = new String[]{};
            return this;

        }
    }
}