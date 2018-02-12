/// Copyright (c) 2017 atacama | Software GmbH
/// 
/// Permission is hereby granted, free of charge, to any person obtaining a copy
/// of this software and associated documentation files (the "Software"), to deal
/// in the Software without restriction, including without limitation the rights
/// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
/// copies of the Software, and to permit persons to whom the Software is
/// furnished to do so, subject to the following conditions:
///
/// The above copyright notice and this permission notice shall be included in all
/// copies or substantial portions of the Software.
///
/// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
/// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
/// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
/// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
/// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
/// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
/// SOFTWARE.
using Atacama.Apenio.NKS.API.Model;
using Atacama.Apenio.NKS.API.Error;

namespace Atacama.Apenio.NKS.API
{
    /// <summary>
    /// Erleichtert das Erstellen einer Anfrage an den NKS
    /// </summary>
    public class QueryBuilder
    {
        private NksQuery query = new NksQuery();

        public QueryBuilder() { }

        /// <summary>
        /// Die Sprache der Antwort
        /// </summary>
        public string Language { set { query.lang = value; } }

        /// <summary>
        /// Der Text, nachdem gesucht werden soll
        /// </summary>
        public string SearchText { set { query.text = value; } }

        /// <summary>
        /// Der Textcontext, nachdem gesucht werden soll
        /// </summary>
        public string TextContext { set { query.textContext = value; } }

        /// <summary>
        /// Die Tiefe, die maximal in der Ontologie gesucht werden soll
        /// </summary>
        public int SearchDepth { set { query.depth = value; } }

        /// <summary>
        /// Die Tiefe, die maximal in der Ontologie gesucht werden soll
        /// </summary>
        public NksEntry Template { set { query.template = value; } }

        /// <summary>
        /// Modus in dem Gesucht werden soll
        /// </summary>
        public int Mode { set { query.mode = value; } }

        /// <summary>
        /// Fügt ein einfaches Konzept über den Namen hinzu
        /// </summary>
        /// <param name="conceptName">der cName bzw Konzeptname</param>
        /// <returns>Sich selbst für chaining</returns>
        public QueryBuilder AddSimpleConcept(string conceptName)
        {
            query.AddConcept(new NksEntry(conceptName));
            return this;
        }

        /// <summary>
        /// Fügt ein Attribut über den Konzeptnamen hinzu.
        /// 
        /// </summary>
        /// <param name="conceptName">der cName oder auch Konzeptname</param>
        /// <returns>Sich selbst für chaining</returns>
        public QueryBuilder AddAttribute(string conceptName)
        {
            query.AddAttribute(new NksEntry(conceptName));
            return this;
        }

        /// <summary>
        /// Fügt der Anfrage eine Zielmengenbegrenzung hinzu
        /// </summary>
        /// <param name="targetBuilder">Eine Begrenzung der Zielmenge über ein <see cref="TargetBuilder"/> Objekt</param>
        /// <returns>Sich selbst für chaining</returns>
        public QueryBuilder AddTarget(TargetBuilder targetBuilder)
        {
            query.AddTarget(targetBuilder.Create());
            return this;
        }

        internal NksQuery Create()
        {
            Validate();
            return query;
        }

        private void Validate()
        {
           /* foreach (NksEntry entry in query.TargetSet)
                if (entry.Structures.Count == 0)
                    throw new QueryException("As of now, every target of a query needs at least one structure.");*/
        }
    }
}
