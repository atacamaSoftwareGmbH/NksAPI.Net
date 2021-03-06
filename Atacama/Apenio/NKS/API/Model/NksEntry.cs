﻿/// Copyright (c) 2017 atacama | Software GmbH
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
        public HashSet<string> warnings { get; set; }
        public string entryValue { get; set; }
        public string evidence { get; set; }
        public string score { get; set; }
        public List<string> abstracts { get; set; }
        public string noxGrade { get; set; }
        public string htmlContent { get; set; }      
        public string signature { get; set; }
        public string parentSignature { get; set; }
        public HashSet<string> structures { get; set; }
        public Dictionary<string, HashSet<string>> dataRelation { get; set; }
        public Dictionary<string, HashSet<string>> objectRelation { get; set; }
        public Dictionary<int, HashSet<string>> shapes { get; set; }
        public String[] shapeLabel { get; set; }
        
        public HashSet<string> fields { get; set; }
        public HashSet<string> cores { get; set; }
        public Dictionary<NksEntry, double> interceptedEntries { get; set; }
        public HashSet<NksEntry> entries { get; set; }
        public HashSet<NksEntry> folders { get; set; }
        public List<string> titles { get; set; }
        public List<string> texts { get; set; }
        public HashSet<NksEntry> targetsOfShape { get; set; }
        public string careLevel { get; set; }
        public NksEntry superTypeEntry { get; set; }
        public List<string> multiLabel { get; set; }
        public Dictionary<string, string> labelMap { get; set; }

        [JsonConstructor()]
        internal NksEntry(String cName)
        {
            this.cName = cName;
        }

        internal void AddStructure(string structure)
        {
            if (structures == null)
            {
                structures = new HashSet<string>();
            }
            structures?.Add(structure);
        }
    }
}
