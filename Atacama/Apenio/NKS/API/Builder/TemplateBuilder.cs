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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NksAPI.Atacama.Apenio.NKS.API
{
    class TemplateBuilder
    {
        private static string NKS_TEMPLATE = "template"; 

        public static NksEntry DefaultTemplate()
        {
            var entry = new NksEntry(NKS_TEMPLATE);
            entry.label = "";
            entry.cat = "";
            entry.superType = "";
            entry.dom = "";
            entry.score = "";
            entry.listIndex = 0;
            entry.signature = "";
            entry.parentSignature = "";
            return entry;
        }

        public static NksEntry CauseTemplate()
        {
            return DefaultTemplate();
        }

        public static NksEntry InterventionTemplate()
        {
            var entry = new NksEntry(NKS_TEMPLATE);
            entry.label = "";
            entry.cat = "";
            entry.superType = "";
            entry.dom = "";
            entry.score = "";
            entry.listIndex = 0;
            entry.signature = "";
            entry.parentSignature = "";
            entry.dataRelation.Add("caremin",new HashSet<String>());
            entry.dataRelation.Add("icnp", new HashSet<String>());
            entry.dataRelation.Add("ppr", new HashSet<String>());
            entry.dataRelation.Add("lepmin", new HashSet<String>());
            return entry;
        }
    }
}
