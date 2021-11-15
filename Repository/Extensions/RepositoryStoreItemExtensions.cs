using Entities.Models;
using Repository.Extensions.Utility;
using System.Linq;
using System.Linq.Dynamic.Core;

namespace Repository.Extensions
{
    public static class RepositoryStoreItemExtensions
    {
        public static IQueryable<StoreItem> FilterStoreItems(this IQueryable<StoreItem> storeItems, uint min, uint max) =>
            storeItems.Where(e => (e.QtyReceived >= max && e.QtyReceived <= max));

        public static IQueryable<StoreItem> Search(this IQueryable<StoreItem> storeItems, string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
                return storeItems;

            var lowerCaseTerm = searchTerm.Trim().ToLower();

            return storeItems.Where(e => e.Name.ToLower().Contains(lowerCaseTerm));
        }

        public static IQueryable<StoreItem> Sort(this IQueryable<StoreItem> storeItems, string orderByQueryString)
        {
            if (string.IsNullOrWhiteSpace(orderByQueryString))
                return storeItems.OrderBy(e => e.Name);

            var orderQuery = OrderQueryBuilder.CreateOrderQuery<StoreItem>(orderByQueryString);

            if (string.IsNullOrWhiteSpace(orderQuery))
                return storeItems.OrderBy(e => e.Name);

            return storeItems.OrderBy(orderQuery);
        }
    }
}
