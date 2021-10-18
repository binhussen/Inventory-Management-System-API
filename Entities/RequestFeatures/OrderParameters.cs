namespace Entities.RequestFeatures
{
    public class OrderParameters : RequestParameters
    {
        public OrderParameters()
        {
            OrderBy = "Name";
        }

        public string SearchTerm { get; set; }
    }
}
