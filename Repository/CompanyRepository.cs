using Contracts;
using Entities;
using Entities.Models;
using Entities.RequestFeatures;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository
{
    public class CompanyRepository : RepositoryBase<Company>, ICompanyRepository
    {
        Guid specialId = Guid.Parse("f3f9725a-f5dc-4dff-2748-08d995ecf82a");
        public CompanyRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public async Task<PagedList<Company>> GetCompaniesAsync(CompanyParameters companyParameters, bool trackChanges)
        {
            var companies = await FindByCondition(c => !c.Id.Equals(specialId), trackChanges)
           .OrderBy(c => c.Name)
           .ToListAsync();

            return PagedList<Company>
                .ToPagedList(companies, companyParameters.PageNumber, companyParameters.PageSize);
        }
        /*public async Task<IEnumerable<Company>> GetAllCompaniesAsync(bool trackChanges) =>
           await FindAll(trackChanges)
           .OrderBy(c => c.Name)
           .ToListAsync();*/

        public async Task<Company> GetCompanyAsync(Guid companyId, bool trackChanges) =>
            await FindByCondition(c => c.Id.Equals(companyId)&& !c.Id.Equals(specialId), trackChanges)
            .SingleOrDefaultAsync();

        public async Task<IEnumerable<Company>> GetByIdsAsync(IEnumerable<Guid> ids, bool trackChanges) =>
            await FindByCondition(x => ids.Contains(x.Id), trackChanges)
            .ToListAsync();

        public void CreateCompany(Company company) => Create(company);

        public void DeleteCompany(Company company)
        {
            Delete(company);
        }
    }
}
