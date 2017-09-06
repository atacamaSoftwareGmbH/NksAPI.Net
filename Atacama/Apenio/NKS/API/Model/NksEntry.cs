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
        public string Type { get; set; }
        public string SuperType { get; set; }
        public int ListIndex { get; set; }
        public string Cat { get; set; }
        public string Dom { get; set; }
        public string CName { get; set; }
        public string Label { get; set; }
        public string Lang { get; set; }
        public HashSet<string> Warnings { get; set; } = new HashSet<string>();
        public string EntryValue { get; set; }
        public string Evidence { get; set; }
        public string Score { get; set; }
        public List<string> Abstracts { get; set; } = new List<string>();
        public string NoxGrade { get; set; }
        public string HtmlContent { get; set; }
        public HashSet<string> Structures { get; set; } = new HashSet<string>();
        public Dictionary<string, HashSet<string>> DataRelation { get; set; } = new Dictionary<string, HashSet<string>>();
        public Dictionary<string, HashSet<string>> ObjectRelation { get; set; } = new Dictionary<string, HashSet<string>>();

        // Protected fields
        internal HashSet<string> Fields { get; set; }
        internal HashSet<string> Cores { get; set; }
        internal Dictionary<NksEntry, double> InterceptedEntries { get; set; }
        internal HashSet<NksEntry> Entries { get; set; }
        internal HashSet<NksEntry> Folders { get; set; }
        internal List<string> Titles { get; set; }
        internal List<string> Texts { get; set; }
        internal HashSet<NksEntry> TargetsOfShape { get; set; }
        internal string CareLevel { get; set; }
        internal NksEntry SuperTypeEntry { get; set; }
        internal List<string> MultiLabel { get; set; }
        internal Dictionary<string, string> LabelMap { get; set; }

        [JsonConstructor()]
        internal NksEntry(String cName)
        {
            CName = cName;
        }

        internal void AddStructure(string structure)
        {
            Structures.Add(structure);
        }
    }
}
