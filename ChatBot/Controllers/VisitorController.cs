using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChatBot.Repository;
using ChatBot.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace ChatBot.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VisitorController : ControllerBase
    {
        private readonly IVisitorService _visitorService;
        private readonly IConfiguration _config;
        public VisitorController(IVisitorService visitorService, IConfiguration config)
        {
            this._config = config;
            _visitorService = visitorService;
        }

        [HttpPost]
        public ActionResult Post([FromBody]Visitor visitor)
        {
            if (visitor == null)
                return BadRequest();
            return Ok(_visitorService.UpsertVisitors(visitor));
        }
    }
}