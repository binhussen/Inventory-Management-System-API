namespace Entities.RequestFeatures
{
    public class RequestItemParameters : RequestParameters
    {
        public RequestItemParameters()
        {
            OrderBy = "Name";
        }
        public uint min { get; set; }
        public uint max { get; set; }

        public string SearchTerm { get; set; }
    }
}
