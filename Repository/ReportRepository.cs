using Contracts;
using Entities;
using Entities.Models;
using Entities.RequestFeatures;
using Microsoft.EntityFrameworkCore;
using Repository.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository
{
    public class ReportRepository : RepositoryBase<Report>, IReportRepository
    {
        public ReportRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public async Task<PagedList<Report>> GetReportsAsync(ReportParameters reportParameters, bool trackChanges)
        {
            var report = await FindAll(trackChanges)
            .OrderBy(c => c.CreatedDate)
            .ToListAsync();

            return PagedList<Report>
                .ToPagedList(report, reportParameters.PageNumber, reportParameters.PageSize);
        }

        public async Task<Report> GetReportAsync(Guid reportId, bool trackChanges) =>
            await FindByCondition(c => c.Id.Equals(reportId), trackChanges)
            .SingleOrDefaultAsync();

        public void CreateReport(Report report)
        {
            Create(report);
        }

        public async Task<IEnumerable<Report>> GetByIdsAsync(IEnumerable<Guid> ids, bool trackChanges) =>
            await FindByCondition(x => ids.Contains(x.Id), trackChanges)
            .ToListAsync();

        public void DeleteReport(Report report)
        {
            Delete(report);
        }
    }
}
