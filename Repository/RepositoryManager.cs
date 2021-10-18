using Contracts;
using Entities;
using System.Threading.Tasks;

namespace Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private RepositoryContext _repositoryContext;
        private ICompanyRepository _companyRepository;
        private IEmployeeRepository _employeeRepository;
        private IRequestHeaderRepository _requestHeaderRepository;
        private IRequestItemRepository _requestItemRepository;
        private IStoreHeaderRepository _storeHeaderRepository;
        private IStoreItemRepository _storeItemRepository;
        private IStoreRepository _storeRepository;

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }

        public ICompanyRepository Company
        {
            get
            {
                if (_companyRepository == null)
                    _companyRepository = new CompanyRepository(_repositoryContext);

                return _companyRepository;
            }
        }

        public IEmployeeRepository Employee
        {
            get
            {
                if (_employeeRepository == null)
                    _employeeRepository = new EmployeeRepository(_repositoryContext);

                return _employeeRepository;
            }
        }
        public IRequestHeaderRepository RequestHeader
        {
            get
            {
                if (_requestHeaderRepository == null)
                    _requestHeaderRepository = new RequestHeaderRepository(_repositoryContext);

                return _requestHeaderRepository;
            }
        }

        public IRequestItemRepository RequestItem
        {
            get
            {
                if (_requestItemRepository == null)
                    _requestItemRepository = new RequestItemRepository(_repositoryContext);

                return _requestItemRepository;
            }
        }
        public IStoreHeaderRepository StoreHeader
        {
            get
            {
                if (_storeHeaderRepository == null)
                    _storeHeaderRepository = new StoreHeaderRepository(_repositoryContext);

                return _storeHeaderRepository;
            }
        }

        public IStoreItemRepository StoreItem
        {
            get
            {
                if (_requestItemRepository == null)
                    _storeItemRepository = new StoreItemRepository(_repositoryContext);

                return _storeItemRepository;
            }
        }

        public IStoreRepository Store
        {
            get
            {
                if (_storeRepository == null)
                    _storeRepository = new StoreRepository(_repositoryContext);

                return _storeRepository;
            }
        }
        public Task SaveAsync() => _repositoryContext.SaveChangesAsync();
    }
}