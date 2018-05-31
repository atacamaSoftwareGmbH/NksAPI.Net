using Atacama.Apenio.NKS.API;

namespace NksAPI.Atacama.Apenio.NKS.API.Builder.Rest.Get
{
    public class GetBuilder
    {
        private string path;

        internal GetBuilder(string path)
        {
            this.path = path;
            this.path += NksRestAttributes.get;
        }

        public TargetSetBuilder Interventions()
        {
            return new TargetSetBuilder(this.path+NksRestAttributes.interventions);
        }

        public TargetSetBuilder Shapes()
        {
            return new TargetSetBuilder(this.path+NksRestAttributes.shapes);
        }

        public TargetSetBuilder Phenomenons()
        {
            return new TargetSetBuilder(this.path+NksRestAttributes.phenomenons);
        }

        public TargetSetBuilder BodyLocations()
        {
            return new TargetSetBuilder(this.path+NksRestAttributes.bodylocations);
        }

        public TargetSetBuilder Causes()
        {
            return new TargetSetBuilder(this.path+NksRestAttributes.causes);
        }

        public TargetSetBuilder Appliances()
        {
            return new TargetSetBuilder(this.path+NksRestAttributes.appliances);;
        }

        public UidBuilder CName(string uid)
        {
            return new UidBuilder(this.path + "/" + uid);
        }

        public UidBuilder URI(string uid)
        {
            return new UidBuilder(this.path + "/" + uid);
        }
    }
}