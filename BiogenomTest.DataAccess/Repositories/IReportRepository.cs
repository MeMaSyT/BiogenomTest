using BiogenomText.Core.Dto;

namespace BiogenomTest.DataAccess.Repositories
{
    public interface IReportRepository
    {
        Task<ReportDto?> CreateNewReport(ReportDto report);
        Task<ReportDto?> GetReport(Guid id);
        Task<ReportDto?> GetLastReport();
    }
}