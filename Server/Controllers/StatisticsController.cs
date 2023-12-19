using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Handball_Shopv1.Server.Services.Stats_Service;

namespace Handball_Shopv1.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatisticsController : ControllerBase
    {
        public readonly IStats_Service_srv stats_service;
        public StatisticsController(IStats_Service_srv stats)
        {
            stats_service = stats;
        }

        [HttpGet]
        public async Task<ActionResult<int>> GetUserVisits()
        {
            return await stats_service.GetVisits();
        }

        [HttpPost]
        public async Task IncrementUserVisits()
        {
            await stats_service.IncrementVisits();
        }
    }
}
