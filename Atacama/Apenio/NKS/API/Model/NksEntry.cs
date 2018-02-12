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
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Atacama.Apenio.NKS.API.Model
{
    public class NksEntry
    {
        public string type { get; set; }
        public string superType { get; set; }
        public int listIndex { get; set; }
        public string cat { get; set; }
        public string dom { get; set; }
        public string cName { get; set; }
        public string label { get; set; }
        public string lang { get; set; }
        public HashSet<string> warnings { get; set; } = new HashSet<string>();
        public string entryValue { get; set; }
        public string evidence { get; set; }
        public string score { get; set; }
        public List<string> abstracts { get; set; } = new List<string>();
        public string noxGrade { get; set; }
        public string htmlContent { get; set; }      
        internal string signature { get; set; }
        internal string parentSignature { get; set; }
        public HashSet<string> structures { get; set; } = new HashSet<string>();
        public Dictionary<string, HashSet<string>> dataRelation { get; set; } = new Dictionary<string, HashSet<string>>();
        public Dictionary<string, HashSet<string>> objectRelation { get; set; } = new Dictionary<string, HashSet<string>>();

        // Protected fields
        internal HashSet<string> fields { get; set; }
        internal HashSet<string> cores { get; set; }
        internal Dictionary<NksEntry, double> interceptedEntries { get; set; }
        internal HashSet<NksEntry> entries { get; set; }
        internal HashSet<NksEntry> folders { get; set; }
        internal List<string> titles { get; set; }
        internal List<string> texts { get; set; }
        internal HashSet<NksEntry> targetsOfShape { get; set; }
        internal string careLevel { get; set; }
        internal NksEntry superTypeEntry { get; set; }
        internal List<string> multiLabel { get; set; }
        internal Dictionary<string, string> labelMap { get; set; }

        [JsonConstructor()]
        internal NksEntry(String cName)
        {
            this.cName = cName;
        }

        internal void AddStructure(string structure)
        {
            this.structures.Add(structure);
        }
    }
}
