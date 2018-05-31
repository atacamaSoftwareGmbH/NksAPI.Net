using Atacama.Apenio.NKS.API;
using Atacama.Apenio.NKS.API.Model;
using NksAPI.Atacama.Apenio.NKS.API.IO;

namespace NksAPI.Atacama.Apenio.NKS.API.Workflow
{
    public class AssessmentExampleFlowTest
    {
        public const string Server = "http://192.168.0.98:22080";

        public async static void Workflow_001()
        {
            Nks nks = Nks.NewConnection(Server);

            SimpleQueryBuilder phenomenonsRequest = nks.PrepareRequest().Search().Catalog()
                .CreateSimpleQuery()
                .AddTargets().Phenomenons().Done().Done()
                .SetSearchText("Zustand")
                .DefineTemplate().PhenomenonsTemplate().Done();
            
            NksResponse shapes = await phenomenonsRequest.Execute();
            new NksJson().Display(phenomenonsRequest.GetQuery());
            NksEntry shape = shapes.Elements[0];
            new NksJson().Display(shape);
            
            SimpleQueryBuilder linkRequest = nks.PrepareRequest().Search().Link()
                .CreateSimpleQuery()
                .AddConcept(shape)
                .AddConcept("IA123").AddStructure("Blub").SetDomain("welt").Done()
                .AddTargets().Causes().Done().Done();
            
            NksResponse causes = await linkRequest.Execute();
            NksEntry cause = causes.Elements[1];
            
            SimpleQueryBuilder interventionRequest = nks.PrepareRequest().Search().Link()
                .CreateSimpleQuery()
                .AddConcept(cause).AddConcept(shape)
                .AddTargets().Interventions().Done().Done();

            NksResponse interventions = await interventionRequest.Execute();
            //new NksJson().Display(interventions);

            SimpleQueryBuilder correlationRequest = nks.PrepareRequest().Search().Correlation()
                .CreateSimpleQuery()
                .AddConcept(cause)
                .AddTargets().Causes().Done().Done();
            //causes 
            
        }
    }
}