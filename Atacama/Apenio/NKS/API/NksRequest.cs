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
    public class NksRequest
    {
        private const string search = "/search";

        /// <summary>
        /// Die valide URL zu einem NKS Server
        /// </summary>
        /// <remarks>
        /// Vor dem Benutzen einer Funktion des NKS muss eine valide URL
        /// zu einem NKS-Server gesetzt werden. Die URL muss folgende Form haben:
        /// 
        /// http://[Adresse]:[Port]/[Projektname]/rest
        /// </remarks>
        public string Url { get; set; } = "http://apenioapp02:19080/NksService/rest";

        public NksRequest() { }

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
        public NksResponse Search(QueryBuilder query) => Request(query.Create(), search);

        internal NksResponse Request(NksQuery query, string urlAddition)
        {
            if (String.IsNullOrWhiteSpace(Url) || !Url.EndsWith("rest"))
                throw new NksException("Please define the URL to the NKS in this scheme   http://[Adresse]:[Port]/[Projektname]/rest");
            return RestClient.Instance.request(query, Url + urlAddition);
        }
    }
}
