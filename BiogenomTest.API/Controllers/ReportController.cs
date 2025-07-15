using BiogenomTest.DataAccess.Repositories;
using BiogenomText.Core.Dto;
using Microsoft.AspNetCore.Mvc;

namespace BiogenomTest.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReportController : Controller
    {
        private readonly IReportRepository _reportRepository;
        public ReportController(IReportRepository reportRepository)
        {
            _reportRepository = reportRepository;
        }

        [HttpGet("GetLastReport")]
        public ActionResult<ReportDto> GetLastReport()
        {
            ReportDto? report = _reportRepository.GetLastReport().Result;

            if (report == null) return NotFound("You dont have reports");
            return Ok(report);
        }
        [HttpGet("{id}", Name = "GetReport")]
        public ActionResult<ReportDto> GetReport(Guid id)
        {
            ReportDto? report = _reportRepository.GetReport(id).Result;

            if (report == null) return NotFound("Report not found");
            return Ok(report);
        }

        [HttpPost]
        public ActionResult<ReportDto> CreateNewReport([FromBody] ReportDto request)
        {
            ReportDto? createResult = _reportRepository.CreateNewReport(request).Result;

            if (createResult == null) return BadRequest("Error while creating report");
            return CreatedAtRoute("GetReport", new { id = createResult.Id}, createResult);
        }
    }
}
