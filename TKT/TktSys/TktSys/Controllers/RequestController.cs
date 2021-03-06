﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TktSys.Business.Entities;
using TktSys.DeskPro;
using TktSys.ZenPro;

namespace TktSys.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestController : ControllerBase
    {
        //ITicketService ticketService;
        //public RequestController(ITicketService _ticketService)
        //{
        //    ticketService = _ticketService;
        //}

        //private readonly IEnumerable<ITicketService> ticketServices;
        //public RequestController(IEnumerable<ITicketService> _ticketServices)
        //{
        //    ticketServices = _ticketServices;
        //}

        private Func<TicketSystemTypeEnum, ITicketService> ticketServiceDelegate;

        public RequestController(Func<TicketSystemTypeEnum, ITicketService> _ticketServiceDelegate)
        {
            ticketServiceDelegate = _ticketServiceDelegate;

        }

        // GET: api/Request
        [HttpGet]
        //public IEnumerable<string> Get()
        public Request Get()
        {
            //return new string[] { "value1", "value2" };
            Request request = new Request();
            request.RequestUId = Guid.NewGuid();
            request.Status = StatusEnum.Active;
            request.RequestResourceId = Guid.NewGuid();
            request.TicketSystemType = TicketSystemTypeEnum.DeskPro;
            request.CreatedDate = DateTime.Now;
            return request;
        }

        // GET: api/Request/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Request
        [HttpPost]
        public IActionResult Post([FromBody] Request request)
        {
            Guid requestId = Guid.Empty;
            //var ticketService = ticketServices.Where(x => x.TicketType == request.TicketSystemType).FirstOrDefault();
            ITicketService ticketService = ticketServiceDelegate(request.TicketSystemType);
            requestId = ticketService.CreateTicket(request);
            return Ok(requestId);
        }

        // PUT: api/Request/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
