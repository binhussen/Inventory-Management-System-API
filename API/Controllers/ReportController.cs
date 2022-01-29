using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using API.ActionFilters;
using Contracts;
using Entities.DataTransferObjects;
using Entities.Models;
using Entities.RequestFeatures;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Authorization;

namespace API.Controllers
{
    [Route("api/reports")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public ReportController(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet, Authorize]
        [HttpHead]
        public async Task<IActionResult> GetReports([FromQuery] ReportParameters reportParameters)
        {
            var reports = await _repository.Report.GetReportsAsync(reportParameters, trackChanges: false);

            Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(reports.MetaData));

            var report = _mapper.Map<IEnumerable<ReportDto>>(reports);

            return Ok(report);
        }

        [HttpGet("{id}", Name = "GetReport"), Authorize]
        public async Task<IActionResult> GetReport(Guid id)
        {
            var report = await _repository.Report.GetReportAsync(id, trackChanges: false);
            if (report == null)
            {
                _logger.LogInfo($"Report with id: {id} doesn't exist in the database.");
                return NotFound();
            }
            else
            {
                var reportDto = _mapper.Map<ReportDto>(report);
                return Ok(reportDto);
            }
        }

        [HttpPost, Authorize]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> CreateReport([FromBody] ReportForCreationDto report)
        {
            var reportEntity = _mapper.Map<Report>(report);

            _repository.Report.CreateReport(reportEntity);
            await _repository.SaveAsync();

            var reportToReturn = _mapper.Map<ReportDto>(reportEntity);

            return CreatedAtRoute("GetReport", new { id = reportToReturn.Id }, reportToReturn);
        }

        [HttpDelete("{id}"), Authorize]
        [ServiceFilter(typeof(ValidateReportExistsAttribute))]
        public async Task<IActionResult> DeleteReport( Guid id)
        {
            var report = HttpContext.Items["report"] as Report;

            _repository.Report.DeleteReport(report);
            await _repository.SaveAsync();

            return NoContent();
        }

        [HttpPut("{id}"), Authorize]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [ServiceFilter(typeof(ValidateReportExistsAttribute))]
        public async Task<IActionResult> UpdateReport(Guid id, [FromBody] ReportForUpdateDto report)
        {
            var reportEntity = HttpContext.Items["report"] as Report;

            _mapper.Map(report, reportEntity);
            await _repository.SaveAsync();

            return NoContent();
        }

        
    }
}