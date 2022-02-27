namespace BerkshireRoyals.Website.Server.Controllers
{
    using BerkshireRoyals.Website.Shared.Model;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using System.Collections.Generic;

    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class MetricController : ControllerBase
    {
        private readonly ILogger<MetricController> _logger;

        public MetricController(ILogger<MetricController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Player> GetAttendance()
        {
            return null;
        }

        [HttpGet]
        public IEnumerable<Player> GetMostWins()
        {
            return null;
        }

        [HttpGet]
        public IEnumerable<Player> GetCatches()
        {
            return null;
        }

        [HttpGet]
        public IEnumerable<Player> GetHits()
        {
            return null;
        }

        [HttpGet]
        public IEnumerable<Player> GetLastMan()
        {
            return null;
        }

        [HttpGet]
        public IEnumerable<Player> GetMvp()
        {
            return null;
        }
    }
}