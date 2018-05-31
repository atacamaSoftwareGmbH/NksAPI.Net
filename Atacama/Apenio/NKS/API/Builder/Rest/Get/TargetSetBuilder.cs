namespace NksAPI.Atacama.Apenio.NKS.API.Builder.Rest.Get
{
    public class TargetSetBuilder
    {
        private string path;

        internal TargetSetBuilder(string path)
        {
            this.path = path;
        }

        /// <summary>
        /// GET-Zugriff auf Elemelent des Katalogs über seinen Konzept-Namen
        /// </summary>
        public UidBuilder CName(string cname)
        {
            return new UidBuilder(this.path + "/" + cname);
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