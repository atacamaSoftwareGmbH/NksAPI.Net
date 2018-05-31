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
using Atacama.Apenio.NKS.API.Error;
using Atacama.Apenio.NKS.API.IO.Net;
using System;
using System.Threading.Tasks;
using System.Web;

namespace Atacama.Apenio.NKS.API
{
    /// <summary>
    /// Hauptklasse um mit einem NKS Server zu kommunizieren.
    /// </summary>
    /// <remarks>
    /// Vor dem Benutzen einer Funktion des NKS muss eine valide URL
    /// zu einem NKS-Server gesetzt werden.Die URL muss folgende Form haben:
    ///
    /// http://[Adresse]:[Port]/[Projektname]/rest
    ///
    /// Für die Suche wird ein QueryBuilder verwendet, der es erleichtert eine
    /// valide Anfrage an den Server zu stellen.
    /// 
    /// Das Rückgabeformat ist eine NksResponse.
    ///
    /// Die Methodem können außerdem Ausnahmen des Typs RuntimeException werfen.
    /// Diese sollten für korrekte Fehlerbehandlung gefangen werden. 
    /// </remarks>
    public struct NksRestAttributes
    {
        [Obsolete] 
        private const string search = "/search";

        //Remote
        public const string publicServer = "http://nks.atacama.de";

        public const string servicePath = "/NksService/rest";

        //V2
        public const string v2 = "/v2";

        //Get

        public const string get = "/get";

        public const string tree = "/tree";
        
        public const string list = "/list";

        public const string interventions = "/interventions";

        public const string shapes = "/shapes";

        public const string phenomenons = "/phenomenons";

        public const string bodylocations = "/bodylocations";

        public const string causes = "/causes";

        public const string appliances = "/appliances";
        
        //private const string interventions = "/v2/get/interventions/";

        //Search

        public const string Search = "/search";
        
        
        public const string Ahi = "/ahi";

        public const string Correlation = "/correlation";

        public const string Catalog = "/catalog";

        public const string Chain = "/chain";

        public const string Link = "/link";

        public const string Prop = "/proposal";

        public const string WordProp = "/proposal/word";

        //access
        public const string access = "/access";

        public const string element = "/element";
        private const string elementAccess = "/v2/access/element";

        //inference
        
        public const string Inference = "/inference";
        
        public const string PInference = "/p";
       
        public const string CInference = "/c";

        //LongTerm
        public const string LongTerm = "/lt";
        
        public const string Risk = "/risk";

        public const string InterventionProposal = "/ltci";

/*

        /// <summary>
        /// Die valide URL zu einem NKS Server
        /// </summary>
        /// <remarks>
        /// Vor dem Benutzen einer Funktion des NKS muss eine valide URL
        /// zu einem NKS-Server gesetzt werden. Die URL muss folgende Form haben:
        /// 
        /// http://[Adresse]:[Port]/[Projektname]/rest
        /// </remarks>
        public string Url { get; set; } = "http://nks.atacama.de/NksService/rest";

        public NksRequest(string url) {
            Url = url;
        }

        public NksRequest()
        {       
        }

        /// <summary>
        /// Bietet Zugriff auf die semantische Suche (FindSem) des NKS.
        /// </summary>
        /// <remarks>
        /// Hier wird, wie in der offiziellen Schnittstellenbeschreibung angegeben,
        /// eine Anfrage übergeben, die mit einem QueryBuilder erstellt wird.
        /// Wird keine Ausnahme geworfen, ist das Ergebnis ein NksResponse.
        /// Darin enthalten sind evtl. Warnungen und die gefundenen Einträge.
        /// </remarks>
        /// <param name="query">Eine Query über die <see cref="QueryBuilder"/> Klasse</param>
        /// <returns>Ein <see cref="NksResponse"/> mit den Ergebnissen oder Fehlern</returns>
        [Obsolete]
        public async Task<NksResponse> Search(QueryBuilder query) => await Post(query.Create(), search);

        public async Task<NksResponse> CatSearch(QueryBuilder query) => await Post(query.Create(), catSearch);

        public async Task<NksResponse> WordProposal(QueryBuilder query) => await Post(query.Create(), wordProp);

        public async Task<NksResponse> Correlation(QueryBuilder query) => await Post(query.Create(), correlation);

        public async Task<NksResponse> Chain(QueryBuilder query) => await Post(query.Create(), chain);

        public async Task<NksResponse> Link(QueryBuilder query) => await Post(query.Create(), link);

        public async Task<NksResponse> Interventions() => await Get(interventions);

        internal async Task<NksResponse> Post(NksQuery query, string urlAddition)
        {
            if (String.IsNullOrWhiteSpace(Url) || !Url.EndsWith("rest"))
                throw new NksException("Please define the URL to the NKS in this scheme   http://[Adresse]:[Port]/[Projektname]/rest");
            return  await RestClient.Instance.Post(query, Url + urlAddition);
        }

        internal async Task<NksResponse> Get(string urlAddition)
        {
            if (String.IsNullOrWhiteSpace(Url) || !Url.EndsWith("rest"))
                throw new NksException("Please define the URL to the NKS in this scheme   http://[Adresse]:[Port]/[Projektname]/rest");
            return await RestClient.Instance.Get(Url + urlAddition);
        }*/
    }
}
