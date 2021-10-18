using Entities.Models;
using Entities.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Contracts
{
    public interface ICompanyRepository
    {
        Task<PagedList<Company>> GetCompaniesAsync(CompanyParameters companyParameters, bool trackChanges);
        /*Task<IEnumerable<Company>> GetAllCompaniesAsync(bool trackChanges);*/
        Task<Company> GetCompanyAsync(Guid companyId, bool trackChanges);
        void CreateCompany(Company company);
        Task<IEnumerable<Company>> GetByIdsAsync(IEnumerable<Guid> ids, bool trackChanges);
        void DeleteCompany(Company company);
    }
}
