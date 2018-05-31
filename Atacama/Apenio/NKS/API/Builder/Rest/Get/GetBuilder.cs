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
        /// <summary>
        /// GET-Zugriff auf Interventionen
        /// </summary>
        public TargetSetBuilder Interventions()
        {
            return new TargetSetBuilder(this.path+NksRestAttributes.interventions);
        }

        /// <summary>
        /// GET-Zugriff auf Ausprägungen
        /// </summary>
        public TargetSetBuilder Shapes()
        {
            return new TargetSetBuilder(this.path+NksRestAttributes.shapes);
        }

        /// <summary>
        /// GET-Zugriff auf Phänomene
        /// </summary>
        public TargetSetBuilder Phenomenons()
        {
            return new TargetSetBuilder(this.path+NksRestAttributes.phenomenons);
        }

        /// <summary>
        /// GET-Zugriff auf Körperorte
        /// </summary>
        public TargetSetBuilder BodyLocations()
        {
            return new TargetSetBuilder(this.path+NksRestAttributes.bodylocations);
        }

        /// <summary>
        /// GET-Zugriff auf Ursachen
        /// </summary>
        public TargetSetBuilder Causes()
        {
            return new TargetSetBuilder(this.path+NksRestAttributes.causes);
        }

        /// <summary>
        /// GET-Zugriff auf Hilsmittel
        /// </summary>
        public TargetSetBuilder Appliances()
        {
            return new TargetSetBuilder(this.path+NksRestAttributes.appliances);;
        }

        /// <summary>
        /// GET-Zugriff auf Elemelent des Katalogs über seinen Konzept-Namen
        /// </summary>
        public UidBuilder CName(string uid)
        {
            return new UidBuilder(this.path + "/" + uid);
        }
        
        /// <summary>
        /// GET-Zugriff auf Element des Katalogs über seine URI
        /// </summary>
        public UidBuilder URI(string uid)
        {
            return new UidBuilder(this.path + "/" + uid);
        }
    }
}