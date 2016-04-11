using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MIRServer.Models
{
    public class Incident
    {
        public string Category { get; set; }
        public string Location { get; set; }
        public string Details { get; set; }
        public string IncidentDate { get; set; }
        public string IncidentTime { get; set; }
    }
}