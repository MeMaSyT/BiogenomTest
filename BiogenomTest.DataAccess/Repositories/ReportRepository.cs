using BiogenomTest.DataAccess.Entities;
using BiogenomText.Core.Dto;
using Microsoft.EntityFrameworkCore;

namespace BiogenomTest.DataAccess.Repositories
{
    public class ReportRepository : IReportRepository
    {
        private readonly ProgramDbContext _context;
        public ReportRepository(ProgramDbContext context)
        {
            _context = context;
        }

        public async Task<ReportDto?> GetLastReport()
        {
            ReportEntity? entity = await _context.Reports
                .AsNoTracking()
                .OrderByDescending(r => r.ReportDate)
                .FirstOrDefaultAsync();

            if (entity == null) return null;
            return new ReportDto(
                entity.Id,
                entity.ReportDate,
                entity.Current_VitaminC,
                entity.Current_VitaminD,
                entity.Current_Water,
                entity.Current_Cink,
                entity.Current_Energy,
                entity.New_VitaminD,
                entity.New_Cink,
                entity.New_Iodine,
                entity.New_VitaminB6,
                entity.New_VitaminС);
        }
        public async Task<ReportDto?> GetReport(Guid id)
        {
            ReportEntity? entity = await _context.Reports
                .AsNoTracking()
                .OrderByDescending(x => x.ReportDate)
                .FirstOrDefaultAsync(r => r.Id == id);

            if (entity == null) return null;
            return new ReportDto(
                entity.Id,
                entity.ReportDate,
                entity.Current_VitaminC,
                entity.Current_VitaminD,
                entity.Current_Water,
                entity.Current_Cink,
                entity.Current_Energy,
                entity.New_VitaminD,
                entity.New_Cink,
                entity.New_Iodine,
                entity.New_VitaminB6,
                entity.New_VitaminС);
        }
        public async Task<ReportDto?> CreateNewReport(ReportDto report)
        {
            ReportEntity entity = new ReportEntity
            {
                Id = Guid.NewGuid(),
                ReportDate = DateTime.UtcNow,

                Current_VitaminC = report.Current_VitaminC,
                Current_VitaminD = report.Current_VitaminD,
                Current_Water = report.Current_Water,
                Current_Cink = report.Current_Cink,
                Current_Energy = report.Current_Energy,

                New_VitaminD = report.New_VitaminD,
                New_Cink = report.New_Cink,
                New_Iodine = report.New_Iodine,
                New_VitaminB6 = report.New_VitaminB6,
                New_VitaminС = report.New_VitaminС
            };
            await _context.AddAsync(entity);
            await _context.SaveChangesAsync();

            return new ReportDto(
                entity.Id,
                entity.ReportDate,
                entity.Current_VitaminC,
                entity.Current_VitaminD,
                entity.Current_Water,
                entity.Current_Cink,
                entity.Current_Energy,
                entity.New_VitaminD,
                entity.New_Cink,
                entity.New_Iodine,
                entity.New_VitaminB6,
                entity.New_VitaminС);
        }
    }
}