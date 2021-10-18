namespace Entities.RequestFeatures
{
    public class RequestItemParameters : RequestParameters
    {
        public RequestItemParameters()
        {
            OrderBy = "Name";
        }
        public int Status { get; set; }
        public string SearchTerm { get; set; }
    }
}
