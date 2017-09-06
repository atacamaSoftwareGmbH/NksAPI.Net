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
using Atacama.Apenio.NKS.API;
using NksAPI.Atacama.Apenio.NKS.API.IO;
using System;

namespace NksAPI.Atacama.Apenio.NKS.API
{
    class Example
    {
        static void Main(string[] args)
        {
            var query = new QueryBuilder
            {
                Language = "de",
                SearchDepth = 1,
                SearchText = "Blutbild abnehmen"
            };

            query.AddTarget(new TargetBuilder("InterventionOrdner").AddStructure("AkutPflege_"));
            query.AddAttribute("MännlichGeschlecht_");
            query.AddAttribute("HochaltrigeAlter_");
            query.AddSimpleConcept("UA1732");
            query.AddSimpleConcept("PC1234");


            NksResponse response = new NksRequest().Search(query);


            new NksJson().Display(response);
            Console.Out.WriteLine("Result Size: " + response.Size);

            Console.In.ReadLine();
        }
    }
}
