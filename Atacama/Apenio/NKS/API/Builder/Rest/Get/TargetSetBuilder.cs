namespace NksAPI.Atacama.Apenio.NKS.API.Builder.Rest.Get
{
    public class TargetSetBuilder
    {
        private string path;

        internal TargetSetBuilder(string path)
        {
            this.path = path;
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