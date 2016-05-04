using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MIRServer.Models;
using MIRServer.Infrastructure;

namespace MIRServer.Controllers
{
    public class IncidentsController : ApiController
    {
        public IHttpActionResult GetIncident(int i)
        {
            return Ok(i);
        }

        [HttpPost]
        public void Incident(Incident i)
        {
            Email.emailIncident(i);
        }
    }
}
