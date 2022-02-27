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
    public class SessionController : ControllerBase
    {
        private readonly ILogger<SessionController> _logger;

        public SessionController(ILogger<SessionController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Session> Get()
        {
            return null;
        }

        [HttpGet]
        public IEnumerable<Session> Get(Guid sessionId)
        {
            return null;
        }

        [HttpPost]
        public ActionResult Create(Session session)
        {
            return Ok();
        }

        [HttpPost]
        public ActionResult Update(Session session)
        {
            return Ok();
        }

        [HttpPost]
        public ActionResult Cancel(Guid sessionId)
        {
            return Ok();
        }

        [HttpPost]
        public ActionResult Register(Guid sessionId)
        {
            return Ok();
        }

        [HttpPost]
        public ActionResult UnRegister(Guid sessionId)
        {
            return Ok();
        }

        [HttpPost]
        public ActionResult Attend(Guid sessionId)
        {
            return Ok();
        }

        [HttpPost]
        public ActionResult Depart(Guid sessionId)
        {
            return Ok();
        }

        [HttpPost]
        public ActionResult Vote(Guid sessionId, Guid playerId)
        {
            return Ok();
        }
    }
}