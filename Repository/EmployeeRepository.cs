using Contracts;
using Entities;
using Entities.Models;
using Entities.RequestFeatures;
using Microsoft.EntityFrameworkCore;
using Repository.Extensions;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Repository
{
    public class EmployeeRepository : RepositoryBase<Employee>, IEmployeeRepository
    {
        private Guid specialId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870");
        public EmployeeRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public async Task<PagedList<Employee>> GetEmployeesAsync(Guid companyId, EmployeeParameters employeeParameters, bool trackChanges)
        {
            var employees = await FindByCondition(e => e.CompanyId.Equals(companyId), trackChanges)
                .FilterEmployees(employeeParameters.MinAge, employeeParameters.MaxAge)
                .Search(employeeParameters.SearchTerm)
                .Sort(employeeParameters.OrderBy)
                .ToListAsync();

            return PagedList<Employee>
                .ToPagedList(employees, employeeParameters.PageNumber, employeeParameters.PageSize);
        }
        
        public async Task<Employee> GetEmployeeAsync(Guid companyId, Guid id, bool trackChanges) =>
            await FindByCondition(e => e.CompanyId.Equals(companyId) && e.Id.Equals(id), trackChanges)
            .SingleOrDefaultAsync();

        public void CreateEmployeeForCompany(Guid companyId, Employee employee)
        {
            employee.CompanyId = companyId;
            Create(employee);
        }

        public void DeleteEmployee(Employee employee)
        {
            Delete(employee);
        }
        /**/
        /**/
        public async Task<PagedList<Employee>> GetEmployees(EmployeeParameters employeeParameters, bool trackChanges)
        {
            var employees = await FindByCondition(e => e.CompanyId.Equals(specialId), trackChanges)
                .Search(employeeParameters.SearchTerm)
                .Sort(employeeParameters.OrderBy)
                .ToListAsync();

            return PagedList<Employee>
                .ToPagedList(employees, employeeParameters.PageNumber, employeeParameters.PageSize);
        }

        public async Task<Employee> GetEmployeeAsync(Guid id, bool trackChanges)
        {

            return await FindByCondition(e => e.CompanyId.Equals(specialId) && e.Id.Equals(id), trackChanges)
             .SingleOrDefaultAsync();
        }

        public async void CreateEmployee(Employee employee)
        {
            employee.CompanyId = specialId;
            Create(employee);
        }
    }
}
