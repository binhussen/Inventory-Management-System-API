namespace Entities.RequestFeatures
{
    public class StoreItemParameters : RequestParameters
    {
        public StoreItemParameters()
        {
            OrderBy = "Name";
        }

        public int Status { get; set; }

        public string SearchTerm { get; set; }
    }
}
