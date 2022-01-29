using Entities.Models;
using Entities.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IReportRepository
    {
        Task<PagedList<Report>> GetReportsAsync(ReportParameters reportParameters, bool trackChanges);
        Task<Report> GetReportAsync(Guid reportId, bool trackChanges);
        void CreateReport(Report report);
        Task<IEnumerable<Report>> GetByIdsAsync(IEnumerable<Guid> ids, bool trackChanges);
        void DeleteReport(Report report);
    }
}
