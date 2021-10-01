using Entities.Models;
using Repository.Extensions.Utility;
using System.Linq;
using System.Linq.Dynamic.Core;

namespace Repository.Extensions
{
    public static class RepositoryRequestItemExtensions
    {
        public static IQueryable<RequestItem> FilterRequestItems(this IQueryable<RequestItem> RequestItems, uint min, uint max) =>
            RequestItems.Where(e => (e.Qty >= min && e.Qty <= max));

        public static IQueryable<RequestItem> Search(this IQueryable<RequestItem> RequestItems, string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
                return RequestItems;

            var lowerCaseTerm = searchTerm.Trim().ToLower();

            return RequestItems.Where(e => e.Name.ToLower().Contains(lowerCaseTerm));
        }

        public static IQueryable<RequestItem> Sort(this IQueryable<RequestItem> RequestItems, string orderByQueryString)
        {
            if (string.IsNullOrWhiteSpace(orderByQueryString))
                return RequestItems.OrderBy(e => e.Name);

            var orderQuery = OrderQueryBuilder.CreateOrderQuery<RequestItem>(orderByQueryString);

            if (string.IsNullOrWhiteSpace(orderQuery))
                return RequestItems.OrderBy(e => e.Name);

            return RequestItems.OrderBy(orderQuery);
        }
    }
}
