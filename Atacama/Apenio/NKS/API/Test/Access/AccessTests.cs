using System;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Messaging;
using System.Threading.Tasks;
using Atacama.Apenio.NKS.API;
using NksAPI.Atacama.Apenio.NKS.API.IO;

namespace NksAPI.Atacama.Apenio.NKS.API.Test.Access
{
    public class AccessTests
    {
        private const string Server = "http://192.168.0.98:22080";

        //ACC000_00_0V
        public static async Task<NksResponse> Access_000_00_0V()
        {
            SimpleQueryBuilder builder = Nks.NewConnection(Server).PrepareRequest().Access().Element()
                .CreateSimpleQuery()
                .AddTargets().Interventions().Done().Done()
                .AddConcept(BasicEntries.InterventionsStructure).Done();
            return await builder.Execute();
        }

        //ACC000_00_01
        public static async Task<NksResponse> Access_000_00_01()
        {
            SimpleQueryBuilder builder = Nks.NewConnection(Server).PrepareRequest().Access().Element()
                .CreateSimpleQuery()
                .AddTargets().Interventions().Done().Done()
                .AddConcept(BasicEntries.InterventionsStructure).Done()
                .SetOrder().List();
            Console.Out.WriteLine(builder.GetPath());
            new NksJson().Display(builder.GetQuery());
            return await builder.Execute();
        }

        //ACC000_00_02
        public static async Task<NksResponse> Access_000_00_02()
        {
            SimpleQueryBuilder builder = Nks.NewConnection(Server).PrepareRequest().Access().Element()
                .CreateSimpleQuery()
                .AddTargets()
                .Interventions().Done()
                .InterventionsStructure().Done()
                .Done()
                .AddConcept(BasicEntries.InterventionsStructure).Done()
                .SetOrder().Tree();
            Console.Out.WriteLine(builder.GetPath());
            new NksJson().Display(builder.GetQuery());
            return await builder.Execute();
        }

        //ACC000_00_03
        public static async Task<NksResponse> Access_000_00_03()
        {
            SimpleQueryBuilder builder = Nks.NewConnection(Server).PrepareRequest().Access().Element()
                .CreateSimpleQuery()
                .AddTargets().Phenomenons().Done().Done()
                .AddConcept(BasicEntries.Phaenomenoms).Done()
                .SetOrder().Tree();
            return await builder.Execute();
        }
        
        //ACC000_00_03
        public static async Task<NksResponse> Access_000_00_04()
        {
            SimpleQueryBuilder builder = Nks.NewConnection(Server).PrepareRequest().Access().Element()
                .CreateSimpleQuery()
                .AddTargets().Shapes().Done().Done()
                //.AddConcept(BasicEntries.Phaenomenoms).Done()
                .SetOrder().Tree();
            return await builder.Execute();
        }
    }
}