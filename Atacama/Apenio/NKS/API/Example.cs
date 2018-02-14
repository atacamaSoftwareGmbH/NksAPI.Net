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
using Atacama.Apenio.NKS.API.Model;
using NksAPI.Atacama.Apenio.NKS.API.IO;
using System;

namespace NksAPI.Atacama.Apenio.NKS.API
{
    class Example
    {
        internal static string server = "http://nks.atacama.de/NksService/rest";

        static void Main(string[] args)
        {

            //ProposeIntTest(server, "Anweisen");
            //ProposeIntTest(server, "Säug");

            //ProposeWordTest(server, "Säug");
            //ProposeWordTest(server, "Alkohol");

            //ProposeShapeFotIntText(server, "Füttern");

            ChainSearch(server, "Diabetes Mellitus",TargetBuilder.Shape(),null);

            //LinkIntervention(server, "J44.00");   //COPD(Raucherlunge)
            //LinkIntervention(server, "5-820.00"); //Hüfte

            Console.In.ReadLine();
        }

        /// <summary>
        /// Schreibt Code, Signatur und Label in die Console.
        /// </summary>
        /// <param name="response">Response welche in der Console ausgegeben werden soll</param>
        private static void print(NksResponse response)
        {
            foreach(NksEntry entry in response.Elements)
            {
                Console.Out.WriteLine(entry.cName + ":"+entry.signature+":"+entry.label);
            }
        }

        /// <summary>
        /// Ein genereller Test in welchem ein NksQuery gebaut wird
        /// </summary>
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

        /// <summary>
        /// Ein Testfall in dem die Ursachen als Target gesetzt werden und nach dem Text 'Angst' gesucht wird.
        /// Hierfür wird die Katalogsuche benutzt. 
        /// </summary>
        /// <param name="server">Server an den die Anfrage geschickt werden soll.</param>
        public static async void EntrySearchCauseTest(string server)
        {
            var query = new QueryBuilder();
            query.AddTarget(TargetBuilder.Cause());
            query.Mode = 0;
            query.Template = TemplateBuilder.CauseTemplate();
            query.SearchText = "Angst";
            query.SearchDepth = 30;
            NksResponse response = await new NksRequest(server).Catalog(query);
            print(response);
        }

        /// <summary>
        /// Ein Testfall in dem die Interventionen als Target gesetzt werden und nach dem Text 'Urin' gesucht wird.
        /// Zusätzlich werden einige Attribute gesetzt.
        /// Hierfür wird die Katalogsuche benutzt. 
        /// </summary>
        /// <param name="server">Server an den die Anfrage geschickt werden soll.</param>
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
            NksResponse response = await new NksRequest(server).Catalog(query);
            print(response);
        }

        /// <summary>
        /// Suche zu einem gewünschten Konzept entsprechende verlinkte Konzepte.
        /// </summary>
        /// <param name="server">Server an den die Anfrage geschickt werden soll.</param>
        /// <param name="cname">Name des Koncepts wessen Verlinkungen gesucht werden sollen.</param>
        public static async void LinkIntervention(string server, string cname)
        {
            var query = new QueryBuilder();
            query.Mode = 0;
            query.Language = "de";
            query.Template = TemplateBuilder.InterventionTemplate();
            query.AddTarget(TargetBuilder.Intervention());
            query.AddSimpleConcept(cname);
            NksResponse response = await new NksRequest(server).Catalog(query);
            print(response);
        }

        /// <summary>
        /// Suche Vorschläge zu einem bestimmten Target.
        /// </summary>
        /// <param name="server">Server an den die Anfrage geschickt werden soll.</param>
        /// <param name="searchText">Text nach dem Gesucht werden soll.</param>
        /// <param name="server">Template für die Ergebnisse.</param>
        /// <param name="target">Target in dem gesucht werden soll.</param> 
        public static async void Propose(string server, string searchText, NksEntry template, TargetBuilder target)
        {
            var query = new QueryBuilder();
            query.Mode = 0;
            query.Language = "de";
            query.TextContext = "thing";
            query.Template = template;
            query.AddTarget(target);
            query.SearchText = searchText;
            query.SearchDepth = 30;
            NksResponse response = await new NksRequest(server).Proposal(query);
            print(response);
        }

        /// <summary>
        /// Suche Katalogeinträge zu einem bestimmten Target.
        /// </summary>
        /// <param name="server">Server an den die Anfrage geschickt werden soll.</param>
        /// <param name="searchText">Text nach dem Gesucht werden soll.</param>
        /// <param name="template">Template für die Ergebnisse.</param>
        /// <param name="target">Target in dem gesucht werden soll.</param> 
        public static async void Catalog(string server, string searchText, NksEntry template, TargetBuilder target)
        {
            var query = new QueryBuilder();
            query.Mode = 0;
            query.Language = "de";
            query.TextContext = "thing";
            query.Template = template;
            query.AddTarget(target);
            query.SearchText = searchText;
            query.SearchDepth = 30;
            NksResponse response = await new NksRequest(server).Catalog(query);
            print(response);
        }


        /// <summary>
        /// Suche Interventionsvorschläge.
        /// </summary>
        /// <param name="server">Server an den die Anfrage geschickt werden soll.</param>
        /// <param name="searchText">Text nach dem Gesucht werden soll.</param>
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
            NksResponse response = await new NksRequest(server).Proposal(query);
            print(response);
        }

        /// <summary>
        /// Suche Worvorschlagsobjekte.
        /// </summary>
        /// <param name="server">Server an den die Anfrage geschickt werden soll.</param>
        /// <param name="searchText">Text nach dem Gesucht werden soll.</param>
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
            print(response);
        }

        /// <summary>
        /// Suche element welche mit dem Interventionskontext korrelieren.
        /// </summary>
        /// <param name="server">Server an den die Anfrage geschickt werden soll.</param>
        /// <param name="searchText">Text nach dem Gesucht werden soll.</param>
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
            print(response);
        }

        /// <summary>
        /// Suche Phänomenvorschläge.
        /// </summary>
        /// <param name="server">Server an den die Anfrage geschickt werden soll.</param>
        /// <param name="searchText">Text nach dem Gesucht werden soll.</param>
        public static async void ProposePheTest(string server, string searchText)
        {
            var query = new QueryBuilder();
            query.Mode = 0;
            query.Language = "de";
            query.AddTarget(TargetBuilder.Shape());
            query.SearchText = searchText;
            query.SearchDepth = 3;
            NksResponse response = await new NksRequest(server).Proposal(query);
            print(response);
        }


        /// <summary>
        /// Kettensuche eines bestimmten Targets in einem beliebigen Kontext.
        /// </summary>
        /// <param name="server">Server an den die Anfrage geschickt werden soll.</param>
        /// <param name="searchText">Text nach dem Gesucht werden soll.</param>
        /// <param name="target">Target in dem gesucht werden soll.</param>
        /// <param name="textContext">Kontext in dem gesucht werden soll.</param>
        public static async void ChainSearch(string server, string searchText, TargetBuilder target, string textContext)
        {
            var query = new QueryBuilder();
            query.Mode = 0;
            query.Language = "de";
            if(textContext == null)
            {
                query.TextContext = "thing";
            } else
            {
                query.TextContext = textContext;
            }
            query.AddTarget(TargetBuilder.Shape());
            query.Template = TemplateBuilder.DefaultTemplate();
            query.SearchText = searchText;
            query.SearchDepth = 30;
            NksResponse response = await new NksRequest(server).Chain(query);
            print(response);
        }
        /// <summary>
        /// Zeige alle oder eine bestimmte Intervention
        /// </summary>
        /// <param name="server">Server an den die Anfrage geschickt werden soll.</param>
        /// <param name="code">Code welcher angegeben werden soll. Null falls alle angezeigt werden sollen</param> 
        public static async void GetInterventions(string server, string code)
        {
            NksResponse response;
            if (code == null)
            {
                response = await new NksRequest(server).Interventions();
            }
            else
            {
                response = await new NksRequest(server).Interventions(code);
            }
            print(response);
        }

        /// <summary>
        /// Zeige alle oder eine bestimmtes Phänomen.
        /// </summary>
        /// <param name="server">Server an den die Anfrage geschickt werden soll.</param>
        /// <param name="code">Code welcher angegeben werden soll. Null falls alle angezeigt werden sollen</param> 
        public static async void GetPhenomenons(string server, string code)
        {
            NksResponse response;
            if (code == null)
            {
                response = await new NksRequest(server).Phenomenons();
            }
            else
            {
                response = await new NksRequest(server).Phenomenons(code);
            }
            print(response);
        }

        /// <summary>
        /// Zeige alle oder eine bestimmte Ausprägung.
        /// </summary>
        /// <param name="server">Server an den die Anfrage geschickt werden soll.</param>
        /// <param name="code">Code welcher angegeben werden soll. Null falls alle angezeigt werden sollen</param> 
        public static async void GetShapes(string server, string code)
        {
            NksResponse response;
            if (code == null)
            {
                response = await new NksRequest(server).Shapes();
            }
            else
            {
                response = await new NksRequest(server).Shapes(code);
            }
            print(response);
        }

        /// <summary>
        /// Zeige alle oder eine bestimmte Ursache.
        /// </summary>
        /// <param name="server">Server an den die Anfrage geschickt werden soll.</param>
        /// <param name="code">Code welcher angegeben werden soll. Null falls alle angezeigt werden sollen</param> 
        public static async void GetCauses(string server, string code)
        {
            NksResponse response;
            if (code == null)
            {
                response = await new NksRequest(server).Causes();
            }
            else
            {
                response = await new NksRequest(server).Causes(code);
            }
            print(response);
        }

        /// <summary>
        /// Zeige alle oder einen bestimmten Körperort.
        /// </summary>
        /// <param name="server">Server an den die Anfrage geschickt werden soll.</param>
        /// <param name="code">Code welcher angegeben werden soll. Null falls alle angezeigt werden sollen</param>
        public static async void GetBodylocations(string server, string code)
        {
            NksResponse response;
            if (code == null)
            {
                response = await new NksRequest(server).Bodylocations();
            }
            else
            {
                response = await new NksRequest(server).Bodylocations(code);
            }
            print(response);
        }

        /// <summary>
        /// Zeige alle oder ein bestimmtes Hilfsmittel.
        /// </summary>
        /// <param name="server">Server an den die Anfrage geschickt werden soll.</param>
        /// <param name="code">Code welcher angegeben werden soll. Null falls alle angezeigt werden sollen</param>
        public static async void GetAppliances(string server, string code)
        {
            NksResponse response;
            if (code == null)
            {
                response = await new NksRequest(server).Appliances();
            }
            else
            {
                response = await new NksRequest(server).Appliances(code);
            }
            print(response);
        }
    }
}
