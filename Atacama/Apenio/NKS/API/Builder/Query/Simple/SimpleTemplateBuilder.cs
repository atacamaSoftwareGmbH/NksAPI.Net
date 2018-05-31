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
        
        /// <summary>
        /// Definiere Felder des StandardTemplates
        /// 
        /// </summary>
        /// <returns>Sich selbst für chaining</returns>
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
        
        /// <summary>
        /// Definiere Felder des Templates für Phänomene
        /// 
        /// </summary>
        /// <returns>Sich selbst für chaining</returns>
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

        /// <summary>
        /// Definiere Felder des Templates für Interventionen
        /// 
        /// </summary>
        /// <returns>Sich selbst für chaining</returns>
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

        /// <summary>
        /// Definiere Felder des Templates für Structures
        /// 
        /// </summary>
        /// <returns>Sich selbst für chaining</returns>
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

        /// <summary>
        /// Schließe das Bearbeiten des Templates ab
        /// 
        /// </summary>
        /// <returns>Sich selbst für chaining</returns>
        public SimpleQueryBuilder Done()
        {
            return _builder;
        }

        /// <summary>
        /// Definiere das Label im Template
        /// 
        /// </summary>
        /// <returns>Sich selbst für chaining</returns>
        public SimpleTemplateBuilder SetLabel()
        {
            _entry.label = "";
            return this;
        }
        
        /// <summary>
        /// Definiere die Kategorie im Template
        /// 
        /// </summary>
        /// <returns>Sich selbst für chaining</returns>
        public SimpleTemplateBuilder SetCategory()
        {
            _entry.cat = "";
            return this;
        }
        
        /// <summary>
        /// Definiere den Vorgängertypen im Template
        /// 
        /// </summary>
        /// <returns>Sich selbst für chaining</returns>
        public SimpleTemplateBuilder SetSuperType()
        {
            _entry.superType = "";
            return this;
        }
        
        /// <summary>
        /// Definiere die Domäne im Template
        /// 
        /// </summary>
        /// <returns>Sich selbst für chaining</returns>
        public SimpleTemplateBuilder SetDomain()
        {
            _entry.dom = "";
            return this;
        }
        
        /// <summary>
        /// Definiere den Score im Template
        /// 
        /// </summary>
        /// <returns>Sich selbst für chaining</returns>
        public SimpleTemplateBuilder SetScore()
        {
            _entry.score = "";
            return this;
        }
        
        /// <summary>
        /// Definiere den ListIndex im Template
        /// 
        /// </summary>
        /// <returns>Sich selbst für chaining</returns>
        public SimpleTemplateBuilder SetListIndex()
        {
            _entry.listIndex = 0;
            return this;
        }

        /// <summary>
        /// Definiere die Signatur im Template
        /// 
        /// </summary>
        /// <returns>Sich selbst für chaining</returns>
        public SimpleTemplateBuilder SetSignature()
        {
            _entry.signature = "";
            return null;
        }
        
        /// <summary>
        /// Definiere die Signatur des Vorgängers im Template
        /// 
        /// </summary>
        /// <returns>Sich selbst für chaining</returns>
        public SimpleTemplateBuilder SetParentSignature()
        {
            _entry.parentSignature = "";
            return null;
        }

        /// <summary>
        /// Definiere die Structures im Template
        /// 
        /// </summary>
        /// <returns>Sich selbst für chaining</returns>
        public SimpleTemplateBuilder SetStructures()
        {
            _entry.structures = new HashSet<string>();
            return this;
        }

        /// <summary>
        /// Definiere die Datenrelationen im Template
        /// 
        /// </summary>
        /// <returns>Sich selbst für chaining</returns>
        public SimpleTemplateBuilder SetDataRelation()
        {
            _entry.dataRelation = new Dictionary<string, HashSet<string>>();
            return this;
        }

        /// <summary>
        /// Definiere die Objektrelationen im Template
        /// 
        /// </summary>
        /// <returns>Sich selbst für chaining</returns>
        public SimpleTemplateBuilder SetObjectRelation()
        {
            _entry.objectRelation = new Dictionary<string, HashSet<string>>();
            return this;
        }

        /// <summary>
        /// Definiere bestimmte Datenrelation im Template
        /// 
        /// </summary>
        /// <param name="str">Name der Relation</param> 
        /// <returns>Sich selbst für chaining</returns>
        public SimpleTemplateBuilder AddDataRelation(string str)
        {
            if (_entry.dataRelation == null)
            {
                SetDataRelation();
            }
            _entry.dataRelation?.Add(str, new HashSet<string>());
            return this;
        }

        /// <summary>
        /// Definiere bestimmte Objektrelation im Template
        /// 
        /// </summary>
        /// <param name="str">Name der Relation</param> 
        /// <returns>Sich selbst für chaining</returns>
        public SimpleTemplateBuilder AddObjectRelation(string str)
        {
            if (_entry.objectRelation == null)
            {
                SetObjectRelation();
            }
            _entry.objectRelation?.Add(str, new HashSet<string>());
            return this;
        }

        /// <summary>
        /// Definiere Ausprägungen im Tempate
        /// 
        /// </summary> 
        /// <returns>Sich selbst für chaining</returns>
        public SimpleTemplateBuilder SetShapes()
        {
            _entry.shapes = new Dictionary<int, HashSet<string>>();
            return this;
        }

        /// <summary>
        /// Definiere Label der Ausprägungen im Tempate
        /// 
        /// </summary> 
        /// <returns>Sich selbst für chaining</returns>
        public SimpleTemplateBuilder SetShapeLabel()
        {
            _entry.shapeLabel = new String[]{};
            return this;
        }
    }
}