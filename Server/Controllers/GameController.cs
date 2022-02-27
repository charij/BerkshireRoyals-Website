namespace BerkshireRoyals.Website.Server.Controllers
{
    using BerkshireRoyals.Website.Shared.Model;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using System;
    using System.Collections.Generic;

    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class GameController : ControllerBase
    {
        private readonly ILogger<GameController> _logger;

        public GameController(ILogger<GameController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Game> Get()
        {
            return null;
        }

        [HttpGet]
        public Game Get(Guid gameId)
        {
            return null;
        }

        [HttpPost]
        public ActionResult Submit(Game game)
        {
            return Ok();
        }
    }
}