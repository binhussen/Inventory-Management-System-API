namespace Entities.RequestFeatures
{
    public class StoreItemParameters : RequestParameters
    {
        public StoreItemParameters()
        {
            OrderBy = "Name";
        }
        public uint min { get; set; }
        public uint max { get; set; }

        public string SearchTerm { get; set; }
    }
}
