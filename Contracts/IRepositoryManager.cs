using System.Threading.Tasks;

namespace Contracts
{
    public interface IRepositoryManager
    {
        ICompanyRepository Company { get; }
        IEmployeeRepository Employee { get; }
        IRequestHeaderRepository RequestHeader { get; }
        IRequestItemRepository RequestItem { get; }
        IStoreHeaderRepository StoreHeader { get; }
        IStoreItemRepository StoreItem { get; }
        IStoreRepository Store { get;}
        IReportRepository Report { get; }
        Task SaveAsync();
    }
}
