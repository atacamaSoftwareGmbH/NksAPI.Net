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
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Atacama.Apenio.NKS.API
{
    /// <summary>
    /// Interne repräsentation der Anfrage.
    /// </summary>
    public class NksQuery
    {
        [JsonProperty()]
        internal string Lang { get; set; } = "de";

        [JsonProperty()]
        internal int Depth { get; set; } = 0;

        [JsonProperty()]
        internal HashSet<NksEntry> TargetSet { get; set; } = new HashSet<NksEntry>();

        [JsonProperty()]
        internal HashSet<NksEntry> Attributes { get; set; } = new HashSet<NksEntry>();

        [JsonProperty()]
        internal HashSet<NksEntry> CombinatedConcept { get; set; } = new HashSet<NksEntry>();

        [JsonProperty()]
        internal string Text { get; set; } = "";

        [JsonProperty()]
        internal string SessionId { get; set; }

        [JsonProperty()]
        internal Boolean DoBayes { get; set; } = true;

        [JsonProperty()]
        internal NksEntry Template { get; set; }

        [JsonProperty()]
        internal string TextContext { get; set; }

        [JsonProperty()]
        internal string MetaContext { get; set; }

        [JsonProperty()]
        internal string Hierarchy { get; set; }

        [JsonProperty()]
        internal int Mode { get; set; }

        internal NksQuery() { }

        internal void AddTarget(NksEntry target)
        {
            TargetSet.Add(target);
        }

        internal void AddAttribute(NksEntry attribute)
        {
            Attributes.Add(attribute);
        }

        internal void AddConcept(NksEntry combinatedConcept)
        {
            CombinatedConcept.Add(combinatedConcept);
        }
    }
}
