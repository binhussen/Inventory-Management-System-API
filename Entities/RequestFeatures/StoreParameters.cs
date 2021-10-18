namespace Entities.RequestFeatures
{
    public class StoreParameters : RequestParameters
    {
        public StoreParameters()
        {
            OrderBy = "Name";
        }

        public string SearchTerm { get; set; }
    }
}
