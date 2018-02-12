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
        internal static string server = "http://nks.atacama.de/NksService/rest";

        static void Main(string[] args)
        {

            ProposeIntTest(server, "Anweisen");
            ProposeIntTest(server, "Säug");

            ProposeWordTest(server, "Säug");
            ProposeWordTest(server, "Alkohol");

            ProposeShapeFotIntText(server, "Füttern");

            ChainSearch(server, "Alkohol");

            LinkIntervention(server, "J44.00");   //COPD(Raucherlunge)
            LinkIntervention(server, "5-820.00"); //Hüfte

            Console.In.ReadLine();
        }

        public static async void GeneralTest()
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


            NksResponse response = await new NksRequest().Search(query);


            new NksJson().Display(response);
            Console.Out.WriteLine("Result Size: " + response.Size);
        }

        public static async void EntrySearchCauseTest(string server)
        {
            var query = new QueryBuilder();
            query.AddTarget(TargetBuilder.Cause());
            query.Mode = 0;
            query.Template = TemplateBuilder.CauseTemplate();
            query.SearchText = "Angst";
            query.SearchDepth = 30;
            NksResponse response = await new NksRequest(server).CatSearch(query);
            new NksJson().Display(response);
        }

        public static async void EntrySearchInterventionTest(string server)
        {
            var query = new QueryBuilder();
            query.Mode = 0;
            query.Language = "de";
            query.TextContext = "thing";
            query.Template = TemplateBuilder.InterventionTemplate();
            query.AddTarget(TargetBuilder.Intervention());
            query.SearchText = "Urin";
            query.SearchDepth = 30;
            query.AddAttribute(AttributeBuilder.HIGH_AGED_ATTRIBUTE);
            query.AddAttribute(AttributeBuilder.MALE_ATTRIBUTE);
            NksResponse response = await new NksRequest(server).CatSearch(query);
            new NksJson().Display(response);
        }

        public static async void LinkIntervention(string server, string cname)
        {
            var query = new QueryBuilder();
            query.Mode = 0;
            query.Language = "de";
            query.Template = TemplateBuilder.InterventionTemplate();
            query.AddTarget(TargetBuilder.Intervention());
            query.AddSimpleConcept(cname);
            NksResponse response = await new NksRequest(server).CatSearch(query);
            new NksJson().Display(response);
        }



        public static async void ProposeIntTest(string server, string searchText)
        {
            var query = new QueryBuilder();
            query.Mode = 0;
            query.Language = "de";
            query.TextContext = "thing";
            query.Template = TemplateBuilder.InterventionTemplate();
            query.AddTarget(TargetBuilder.Intervention());
            query.SearchText = searchText;
            query.SearchDepth = 30;
            NksResponse response = await new NksRequest(server).CatSearch(query);
            new NksJson().Display(response);
        }

        public static async void ProposeWordTest(string server, string searchText)
        {
            var query = new QueryBuilder();
            query.Mode = 0;
            query.Language = "de";
            query.TextContext = "thing";
            query.Template = TemplateBuilder.InterventionTemplate();
            query.AddTarget(TargetBuilder.Intervention());
            query.SearchText = searchText;
            query.SearchDepth = 30;
            NksResponse response = await new NksRequest(server).WordProposal(query);
            new NksJson().Display(response);
        }

       
        public static async void ProposeShapeFotIntText(string server, string searchText)
        {
            var query = new QueryBuilder();
            query.Mode = 1;
            query.Language = "de";
            query.TextContext = "InterventionOrdner";
            query.Template = TemplateBuilder.InterventionTemplate();
            query.AddTarget(TargetBuilder.Shape());
            query.SearchText = searchText;
            query.SearchDepth = 30;
            NksResponse response = await new NksRequest(server).Correlation(query);
            new NksJson().Display(response);
        }

        public static async void ProposePheTest(string server, string searchText)
        {
            var query = new QueryBuilder();
            query.Mode = 0;
            query.Language = "de";
            query.AddTarget(TargetBuilder.Shape());
            query.SearchText = searchText;
            query.SearchDepth = 3;
            NksResponse response = await new NksRequest(server).CatSearch(query);
            new NksJson().Display(response);
        }

        public static async void ChainSearch(string server, string searchText)
        {
            var query = new QueryBuilder();
            query.Mode = 0;
            query.Language = "de";
            query.TextContext = "InterventionOrdner";
            query.AddTarget(TargetBuilder.Shape());
            query.SearchText = searchText;
            query.SearchDepth = 30;
            NksResponse response = await new NksRequest(server).Chain(query);
            new NksJson().Display(response);
        }

        public static async void GetInterventionsTest(string server)
        {
            NksResponse response = await new NksRequest(server).Interventions();
            new NksJson().Display(response);
        }

        public static void LinkIntervention(string server)
        {

        }
    }
}
