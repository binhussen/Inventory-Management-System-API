namespace Entities.RequestFeatures
{
    public class ReportParameters : RequestParameters
    {
        public ReportParameters()
        {
            OrderBy = "CreatedDate";
        }

        public string SearchTerm { get; set; }
    }
}
